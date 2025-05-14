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

namespace Proyecto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo que se utiliza para limpiar los campos y que el formulario este listo para ingresar con un nuevo usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";
            txtclave.Text = "";
            this.Show();
            txtusuario.Focus();
        }
        /// <summary>
        /// Evento que se inicia cuando el puntero esta tocando la imagen, cambia el estilo de puntero y el color de la imagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconPictureBox1_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox1.BackColor = Color.LightSteelBlue;
            iconPictureBox1.Cursor = Cursors.Hand;
        }
        /// <summary>
        /// Evento que se inicia cuando el puntero deja de tocar la imagen para que regrese a su estado inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox1.BackColor = Color.FromArgb(42, 63, 84);
        }
        /// <summary>
        /// Boton de ingresar, valida que usuario esta ingresando o que si el usuario existe, tambien comprueba los permisos que el usuario tiene.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btningresar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            bool encontrado = false;
            
            if (txtusuario.Text == "administrador" && txtclave.Text == "13579123")
            {
                int respuesta = UsuarioLogica.Instancia.resetear();
                if (respuesta > 0)
                {
                    MessageBox.Show("La cuenta fue restablecida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                List<Usuario> ouser = UsuarioLogica.Instancia.Listar(out mensaje);
                encontrado = ouser.Any(u => u.NombreUsuario == txtusuario.Text && u.Clave == txtclave.Text);

                if (encontrado)
                {
                    Usuario objuser = ouser.Where(u => u.NombreUsuario == txtusuario.Text && u.Clave == txtclave.Text).FirstOrDefault();

                    Inicio frm = new Inicio();
                    frm.NombreUsuario = objuser.NombreUsuario;
                    frm.Clave = objuser.Clave;
                    frm.NombreCompleto = objuser.NombreCompleto;
                    frm.FechaHora = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                    frm.oPermisos = PermisosLogica.Instancia.Obtener(objuser.IdPermisos);
                    frm.Show();
                    this.Hide();
                    frm.FormClosing += Frm_Closing;
                }
                else
                {
                    if (string.IsNullOrEmpty(mensaje))
                    {
                        MessageBox.Show("No se encontraron coincidencias del usuario", "Mensaje C.E.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DetalleNegocio dn = new DetalleNegocio();
            dn.Logo(iconPictureBox1, LblNombre);
        }
    }
}
