﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Proyecto.Herramientas;
using Proyecto.Modelo;
using ProyectoVenta.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Formularios.Compras
{
    public partial class frmBuscarCompra : Form
    {
        public frmBuscarCompra()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBuscarCompra_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();
            DetalleNegocio dn = new DetalleNegocio();
            dn.Logo(iconPictureBox1, label2);
            label2.Text = "Buscar Compra " + label2.Text;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscarcompra();
        }

        private void buscarcompra() {
            if (txtbusqueda.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el numero de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Compra obj = CompraLogica.Instancia.Obtener(txtbusqueda.Text);

            if (obj != null)
            {
                txtfecharegistro.Text = obj.FechaRegistro;
                txtnumerodocumento.Text = obj.NumeroDocumento;
                txtusuarioregistro.Text = obj.UsuarioRegistro;
                txtdocproveedor.Text = obj.DocumentoProveedor;
                txtnombreproveedor.Text = obj.NombreProveedor;

                List<DetalleCompra> olista = CompraLogica.Instancia.ListarDetalle(obj.IdCompra);
                dgvdata.Rows.Clear();
                foreach (DetalleCompra de in olista)
                {
                    dgvdata.Rows.Add(new object[] { de.DescripcionProducto, de.Cantidad, de.PrecioCompra, de.SubTotal });
                }

                lbltotal.Text = obj.MontoTotal;
            }
            else
            {
                limpiar();
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbusqueda.Select();
            }
        }

        private void limpiar(bool busqueda=false)
        {
            if(busqueda)
                txtbusqueda.Text = "";

            txtnumerodocumento.Text = "";
            txtfecharegistro.Text = "";
            txtusuarioregistro.Text = "";
            txtdocproveedor.Text = "";
            txtnombreproveedor.Text = "";
            dgvdata.Rows.Clear();
            lbltotal.Text = "0.00";
            txtbusqueda.Select();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            limpiar(true);
        }

        private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buscarcompra();
            }
        }

        private void btndescargarpdf_Click(object sender, EventArgs e)
        {
            if (txtnumerodocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaCompra.ToString();
            Datos odatos = DatoLogica.Instancia.Obtener();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.RazonSocial.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumerodocumento.Text);

            Texto_Html = Texto_Html.Replace("@docproveedor", txtdocproveedor.Text);
            Texto_Html = Texto_Html.Replace("@nombreproveedor", txtnombreproveedor.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecharegistro.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtusuarioregistro.Text);


            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", lbltotal.Text);


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", txtnumerodocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteimage = DatoLogica.Instancia.ObtenerLogo(out obtenido);
                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteimage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
