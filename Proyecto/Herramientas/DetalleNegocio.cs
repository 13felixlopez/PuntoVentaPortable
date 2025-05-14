using FontAwesome.Sharp;
using ProyectoVenta.Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Herramientas
{
    public class DetalleNegocio
    {
        public void Logo(PictureBox pb,Label lbl)
        {
            try
            {
                bool obtenido = true;
                byte[] byteimage = DatoLogica.Instancia.ObtenerLogo(out obtenido);

                // Limpiar imagen anterior si existe
                if (pb.Image != null)
                {
                    var oldImage = pb.Image;
                    pb.Image = null;
                    oldImage.Dispose();
                }

                if (obtenido && byteimage?.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(byteimage))
                    {
                        pb.Image = Image.FromStream(ms);
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                else
                {
                    // Opcional: Asignar una imagen por defecto
                    pb.Image = Properties.Resources.LogoCanal;
                }
                string Nombre = DatoLogica.Instancia.Obtener().RazonSocial;
                if (Nombre != null)
                {
                    lbl.Text = Nombre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar logo: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pb.Image = null;
            }
        }
    }
}
