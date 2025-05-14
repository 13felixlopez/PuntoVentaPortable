using iTextSharp.text;
using iTextSharp.text.pdf;
using Proyecto.Formularios.Modales;
using Proyecto.Herramientas;
using Proyecto.Herrarmientas;
using Proyecto.Modelo;
using ProyectoVenta.Logica;
using SkiaSharp;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using Rectangle = iTextSharp.text.Rectangle;

namespace Proyecto.Formularios.Productos
{
    public partial class frmGenerarBarras : Form
    {
        private static string rutaguardado = "";
        private static int valorCodigo = -1;
        private bool verticalDocumento;
        private string rutaGuardar;

        public frmGenerarBarras()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGenerarBarras_Load(object sender, EventArgs e)
        {
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = BarcodeFormat.CODE_128, Texto = "CODE_128" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = BarcodeFormat.CODE_39, Texto = "CODE_39" });
            //cbotipocodigo.Items.Add(new OpcionCombo() { Valor = BarcodeFormat.EAN_13, Texto = "EAN_13" });
            //cbotipocodigo.Items.Add(new OpcionCombo() { Valor = BarcodeFormat.EAN_8, Texto = "EAN_8" });
            //cbotipocodigo.Items.Add(new OpcionCombo() { Valor = BarcodeFormat.ITF, Texto = "ITF" });
            //cbotipocodigo.Items.Add(new OpcionCombo() { Valor = BarcodeFormat.UPC_A, Texto = "UPC_A" });
            //cbotipocodigo.Items.Add(new OpcionCombo() { Valor = BarcodeFormat.UPC_E, Texto = "UPC_E" });
            //cbotipocodigo.Items.Add(new OpcionCombo() { Valor = BarcodeFormat.CODABAR, Texto = "CODABAR" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = BarcodeFormat.QR_CODE, Texto = "QR_CODE" });
            //cbotipocodigo.Items.Add(new OpcionCombo() { Valor = BarcodeFormat.MSI, Texto = "MSI" });
            //cbotipocodigo.Items.Add(new OpcionCombo() { Valor = BarcodeFormat.PLESSEY, Texto = "PLESSEY" });


            cbotipocodigo.DisplayMember = "Texto";
            cbotipocodigo.ValueMember = "Valor";
            cbotipocodigo.SelectedItem = 0;

            // Inicialización de combobox de orientación
            cboorientacion.Items.Add(new OpcionCombo() { Valor = false, Texto = "Vertical" }); // false para vertical
            cboorientacion.Items.Add(new OpcionCombo() { Valor = true, Texto = "Horizontal" }); // true para horizontal
            cboorientacion.DisplayMember = "Texto";
            cboorientacion.ValueMember = "Valor";
            cboorientacion.SelectedIndex = 0;
        }

        private void btngenerarimagen_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() != "")
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = $"{txtcodigo.Text.Trim()}.png";
                savefile.Filter = "Files|*.png";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Crear código de barras
                        BarcodeWriter writer = new BarcodeWriter
                        {
                            Format = (BarcodeFormat)((OpcionCombo)cbotipocodigo.SelectedItem).Valor,
                            Options = new EncodingOptions
                            {
                                Width = 400,
                                Height = 100,
                                Margin = 1
                            }
                        };

                        Bitmap barcodeBitmap = writer.Write(txtcodigo.Text.Trim());

                        // Si hay descripción, combinarla con el código
                        Bitmap finalImage;
                        if (chkmostrardescripcion.Checked)
                        {
                            Bitmap descripcion = ConvertirBitMap.convertirTextoImagen(txtdescripcion.Text.Trim());
                            int width = Math.Max(barcodeBitmap.Width, descripcion.Width);
                            int height = barcodeBitmap.Height + descripcion.Height;

                            finalImage = new Bitmap(width, height);
                            using (Graphics g = Graphics.FromImage(finalImage))
                            {
                                g.Clear(Color.White);
                                g.DrawImage(descripcion, new Point(0, 0));
                                g.DrawImage(barcodeBitmap, new Point(0, descripcion.Height));
                            }

                            descripcion.Dispose();
                        }
                        else
                        {
                            finalImage = new Bitmap(barcodeBitmap);
                        }

                        finalImage.Save(savefile.FileName, System.Drawing.Imaging.ImageFormat.Png);

                        barcodeBitmap.Dispose();
                        finalImage.Dispose();

                        MessageBox.Show("Etiqueta generada!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btngenerardocumento_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un código", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(cbotipocodigo.SelectedItem is OpcionCombo opcionCodigo) ||
                !(cboorientacion.SelectedItem is OpcionCombo opcionOrientacion))
            {
                MessageBox.Show("Seleccione tipo de código y orientación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            valorCodigo = (int)opcionCodigo.Valor;
            verticalDocumento = (bool)opcionOrientacion.Valor; // Ahora es bool

            SaveFileDialog savefile = new SaveFileDialog
            {
                FileName = $"{txtcodigo.Text.Trim()}.pdf",
                Filter = "Pdf Files|*.pdf"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                rutaguardado = savefile.FileName;
                progressBar1.Maximum = (int)txtnumeroetiquetas.Value;
                progressBar1.Value = 0;
                // Establecer el máximo ANTES de iniciar el backgroundWorker
                progressBar1.Maximum = (int)txtnumeroetiquetas.Value;
                progressBar1.Value = 0; // Reiniciar a 0
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private async Task GenerarDocumentoPDF(string codigo, string descripcion, bool mostrarDescripcion,
            BarcodeFormat tipoCodigo, bool esHorizontal, int numeroEtiquetas, string rutaDestino)
        {
            try
            {
                // Configuración del writer
                var writer = new BarcodeWriter
                {
                    Format = tipoCodigo,
                    Options = new EncodingOptions
                    {
                        Width = 400,
                        Height = 100,
                        Margin = 1
                    }
                };

                using (var stream = new FileStream(rutaDestino, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    var pageSize = esHorizontal ? PageSize.A4.Rotate() : PageSize.A4;
                    var doc = new Document(pageSize);
                    var pdfWriter = PdfWriter.GetInstance(doc, stream);
                    doc.Open();

                    for (int i = 1; i <= numeroEtiquetas; i++)
                    {
                        // Generar código de barras
                        using (var barcodeBitmap = writer.Write(codigo))
                        {
                            // Combinar con descripción si aplica
                            using (var finalImage = mostrarDescripcion ?
                                CombinarConDescripcion(barcodeBitmap, descripcion) :
                                new Bitmap(barcodeBitmap))
                            {
                                // Agregar al PDF
                                var img = iTextSharp.text.Image.GetInstance(finalImage, ImageFormat.Png);
                                img.Alignment = Element.ALIGN_CENTER;
                                doc.Add(img);

                                // Agregar nueva página si no es la última etiqueta
                                if (i < numeroEtiquetas)
                                {
                                    doc.NewPage();
                                }
                            }
                        }

                        // Actualizar progreso en el hilo UI
                        this.Invoke((Action)(() => progressBar1.Value = i));
                    }

                    doc.Close();
                }

                this.Invoke((Action)(() =>
                    MessageBox.Show("Documento generado correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)));
            }
            catch (Exception ex)
            {
                this.Invoke((Action)(() =>
                    MessageBox.Show($"Error al generar el documento:\n{ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
        }

        private Bitmap CombinarConDescripcion(Bitmap barcodeBitmap, string descripcion)
        {
            Bitmap descripcionBitmap = ConvertirBitMap.convertirTextoImagen(descripcion.Trim());
            try
            {
                int width = Math.Max(barcodeBitmap.Width, descripcionBitmap.Width);
                int height = barcodeBitmap.Height + descripcionBitmap.Height;

                var finalImage = new Bitmap(width, height);
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    g.Clear(Color.White);
                    g.DrawImage(descripcionBitmap, new Point(0, 0));
                    g.DrawImage(barcodeBitmap, new Point(0, descripcionBitmap.Height));
                }

                return finalImage;
            }
            finally
            {
                descripcionBitmap.Dispose();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var tipoCodigo = (BarcodeFormat)valorCodigo;
                var writer = new BarcodeWriter
                {
                    Format = tipoCodigo,
                    Options = new EncodingOptions { Width = 400, Height = 100, Margin = 1 }
                };

                // Configuración de tamaños
                int widthImage = verticalDocumento ? 230 : 170;
                int heightImage = verticalDocumento ? 110 : 80;
                float sizeFont = 8; // Tamaño de fuente pequeño
                float qrCodeSizeMultiplier = 1.5f; // Aumentar tamaño para QR

                using (var stream = new FileStream(rutaguardado, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    // Configuración del documento
                    iTextSharp.text.Rectangle orientacionDocumento = verticalDocumento ? PageSize.A4.Rotate() : PageSize.A4;
                    Document pdfDoc = new Document(orientacionDocumento, 15, 15, 15, 15);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Configuración de la tabla principal con bordes visibles
                    PdfPTable table = new PdfPTable(3);
                    table.WidthPercentage = 100;
                    table.DefaultCell.Border = Rectangle.BOX;
                    table.DefaultCell.BorderWidth = 0.5f;
                    table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.DefaultCell.Padding = 5;

                    int numeroEtiquetas = (int)txtnumeroetiquetas.Value;
                    int numeroEtiquetasOrigen = numeroEtiquetas;
                    numeroEtiquetas = (numeroEtiquetas % 3) > 0 ? (3 * totalFilas()) : numeroEtiquetas;

                    for (int i = 1; i <= numeroEtiquetas; i++)
                    {
                        PdfPCell celda = new PdfPCell();
                        celda.Border = Rectangle.BOX;
                        celda.BorderWidth = 0.5f;
                        celda.HorizontalAlignment = Element.ALIGN_CENTER;
                        celda.VerticalAlignment = Element.ALIGN_MIDDLE;
                        celda.Padding = 5;

                        if (i > numeroEtiquetasOrigen)
                        {
                            celda.AddElement(new Paragraph(""));
                        }
                        else
                        {
                            using (var barcodeBitmap = writer.Write(txtcodigo.Text.Trim()))
                            {
                                PdfPTable innerTable = new PdfPTable(1);
                                innerTable.WidthPercentage = 100;
                                innerTable.DefaultCell.Border = Rectangle.NO_BORDER;
                                innerTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

                                // Descripción (si está marcado)
                                if (chkmostrardescripcion.Checked)
                                {
                                    Paragraph descripcion = new Paragraph(txtdescripcion.Text.Trim());
                                    descripcion.Font = FontFactory.GetFont(FontFactory.HELVETICA, sizeFont);
                                    descripcion.Alignment = Element.ALIGN_CENTER;
                                    innerTable.AddCell(descripcion);
                                }

                                // Ajustar tamaño para QR Code
                                float scaleWidth = widthImage;
                                float scaleHeight = heightImage;

                                if (tipoCodigo == BarcodeFormat.QR_CODE)
                                {
                                    scaleWidth *= qrCodeSizeMultiplier;
                                    scaleHeight *= qrCodeSizeMultiplier;
                                }

                                // Imagen del código
                                using (var ms = new MemoryStream())
                                {
                                    barcodeBitmap.Save(ms, ImageFormat.Png);
                                    var img = iTextSharp.text.Image.GetInstance(ms.ToArray());
                                    img.ScaleToFit(scaleWidth, scaleHeight);
                                    img.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                                    innerTable.AddCell(img);
                                }

                                // Código de producto (si está marcado y no es QR)
                                if (chkmostrarcodigo.Checked)
                                {
                                    Paragraph codigo = new Paragraph(txtcodigo.Text.Trim());
                                    codigo.Font = FontFactory.GetFont(FontFactory.HELVETICA, sizeFont);
                                    codigo.Alignment = Element.ALIGN_CENTER;

                                    // Solo agregar si no es QR o si es QR y queremos mostrarlo igual
                                    if (tipoCodigo != BarcodeFormat.QR_CODE)
                                    {
                                        innerTable.AddCell(codigo);
                                    }
                                    else
                                    {
                                        // Para QR, agregar el código como texto debajo
                                        innerTable.AddCell(codigo);
                                    }
                                }

                                celda.AddElement(innerTable);
                            }
                        }

                        table.AddCell(celda);
                        backgroundWorker1.ReportProgress(i);
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                }

                this.Invoke((MethodInvoker)delegate {
                    var result = MessageBox.Show("Documento generado correctamente. ¿Desea abrir el documento ahora?",
                                              "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(rutaguardado);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"No se pudo abrir el documento: {ex.Message}",
                                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    progressBar1.Value = 0;
                    rutaguardado = "";
                    valorCodigo = -1;
                    verticalDocumento = false;
                });
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate {
                    MessageBox.Show($"Error al generar el documento: {ex.Message}",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                });
            }
        }
        private int totalFilas()
        {
            int numeroEtiquetas = (int)txtnumeroetiquetas.Value;
            int numeroColumna = 1;
            int numeroFila = 1;

            for (int i = 1; i <= numeroEtiquetas; i++)
            {
                if (numeroColumna == 3)
                {
                    numeroFila++;
                    numeroColumna = 1;
                }
                else
                {
                    numeroColumna++;
                }
            }

            return numeroFila;
        }
        private void CrearDocumentoPDFConImagen(Bitmap imagen, string rutaDestino, bool esHorizontal)
        {
            using (var stream = new FileStream(rutaDestino, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                var pageSize = esHorizontal ? PageSize.A4.Rotate() : PageSize.A4;
                var doc = new Document(pageSize);
                var writer = PdfWriter.GetInstance(doc, stream);
                doc.Open();

                var img = iTextSharp.text.Image.GetInstance(imagen, ImageFormat.Png);
                img.Alignment = Element.ALIGN_CENTER;
                doc.Add(img);

                doc.Close();
            }
        }

        private void AgregarImagenAPDF(Bitmap imagen, string rutaPdf, bool esHorizontal)
        {
            using (var fs = new FileStream(rutaPdf, FileMode.Open, FileAccess.ReadWrite))
            using (var reader = new PdfReader(fs))
            using (var ms = new MemoryStream())
            {
                using (var stamper = new PdfStamper(reader, ms))
                {
                    var pageSize = esHorizontal ? PageSize.A4.Rotate() : PageSize.A4;
                    stamper.InsertPage(reader.NumberOfPages + 1, pageSize);

                    var cb = stamper.GetOverContent(reader.NumberOfPages);
                    using (var msImage = new MemoryStream())
                    {
                        imagen.Save(msImage, ImageFormat.Png);
                        var img = iTextSharp.text.Image.GetInstance(msImage.ToArray());
                        img.ScaleToFit(pageSize.Width - 40, pageSize.Height - 40);
                        img.SetAbsolutePosition(
                            (pageSize.Width - img.ScaledWidth) / 2,
                            (pageSize.Height - img.ScaledHeight) / 2);
                        cb.AddImage(img);
                    }
                }
                File.WriteAllBytes(rutaPdf, ms.ToArray());
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Asegurarse que el valor esté dentro del rango permitido
            if (e.ProgressPercentage >= progressBar1.Minimum && e.ProgressPercentage <= progressBar1.Maximum)
            {
                progressBar1.Value = e.ProgressPercentage;
            }
            else
            {
                // Si excede el máximo, establecerlo al máximo permitido
                progressBar1.Value = progressBar1.Maximum;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var Iform = new mdProductos())
            {
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Producto objeto = Iform._Producto;
                    txtcodigo.BackColor = Color.Honeydew;
                    txtcodigo.Text = objeto.Codigo;
                    txtdescripcion.Text = objeto.Descripcion;
                }
            }
        }

        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            string mensaje = string.Empty;
            if (e.KeyData == Keys.Enter)
            {
                Producto pr = ProductoLogica.Instancia.Listar(out mensaje).Where(p => p.Codigo.ToUpper() == txtcodigo.Text.Trim().ToUpper()).FirstOrDefault();
                if (pr != null)
                {
                    txtcodigo.BackColor = Color.Honeydew;
                    txtcodigo.Text = pr.Codigo;
                    txtdescripcion.Text = pr.Descripcion;
                }
                else
                {
                    txtcodigo.BackColor = Color.MistyRose;
                }

            }
        }
    }
}
