using ArcabiaLasHistoriasOcultas.Clases;
using ArcabiaLasHistoriasOcultas.Controladores;
using ArcabiaLasHistoriasOcultas.Properties;
using Cassandra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Vistas.Principal_Hijos
{
    public partial class Perfil_Usuario : Form
    {
        string nombreUsuario;
        public Perfil_Usuario(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            mostrarDatosUsuario();//Muestra los datos en los campos de texto
        }
        private void LimpiarErrores()
        {
            lblErrorNombre.Visible = false;
            lblErrorApellidos.Visible = false;
            lblErrorNombreUsuario.Visible = false;
            lblErrorCorreo.Visible = false;
        }

        private void Perfil_Usuario_Load(object sender, EventArgs e)
        {
            
            
        }
        public void mostrarDatosUsuario()
        {
            Usuario usuario = ControladorUsuarios.CargarUsuario(nombreUsuario);//consulta recibe el valor de una serie de datos del usuario con el nombreUsuario enviado por parámetro

            //Los mostramos en los campos de texto
            txtId.Text = "" + usuario.id + "";
            txtNombre.Text = usuario.nombre;
            txtApellidos.Text = usuario.apellidos;
            txtNombreUsuario.Text = usuario.nombreUsuario;
            txtCorreo.Text = usuario.correo;
 
        }

        private bool ValidarDatos()
        {
            bool noHayError = true;
            LimpiarErrores();

            //comprobamos el Nombre
            if (txtNombre.Text.Trim() == "")
            {
                lblErrorNombre.Visible = true;
                MessageBox.Show("El nombre no puede estar vacío");
                txtNombre.SelectAll();
                txtNombre.Focus();
                noHayError = false;
            }
            //comprobamos los apellidos
            if (txtApellidos.Text.Trim() == "")
            {
                lblErrorApellidos.Visible = true;
                MessageBox.Show("Debes poner al menos un apellido");
                txtApellidos.SelectAll();
                txtApellidos.Focus();
                noHayError = false;
            }

            //comprobamos el nombre de usuario
            if (txtNombreUsuario.Text.Trim() == "")
            {
                lblErrorNombreUsuario.Visible = true;
                MessageBox.Show("Debes introducir un nombre de usuario");
                txtNombreUsuario.SelectAll();
                txtNombreUsuario.Focus();
                noHayError = false;
            }



            //comprobamos el correo electronico
            if (txtCorreo.Text.Trim() == "")
            {
                lblErrorCorreo.Visible = true;
                MessageBox.Show("Debes introducir un correo");
                txtCorreo.Focus();
                noHayError = false;
            }
            else
            {
                if (!Regex.IsMatch(txtCorreo.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    lblErrorCorreo.Visible = true;
                    MessageBox.Show("Correo inválido");
                    txtCorreo.Focus();
                    noHayError = false;
                }
            }

            return noHayError;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                ControladorUsuarios.ActualizarUsuario(txtNombre.Text, txtApellidos.Text, txtNombreUsuario.Text, txtCorreo.Text, nombreUsuario);
                MessageBox.Show("El usuario " + nombreUsuario + " ha sido actualizado");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)//Hasta no clickar en el botón editar, no podemos editar ningún campo de texto
        {
            txtNombre.ReadOnly= false;
            txtApellidos.ReadOnly= false;
            txtNombreUsuario.ReadOnly = false;
            txtCorreo.ReadOnly= false; 
            btnGuardar.Enabled= true;    
        }

        //MouseHover

        private void btnEditar_MouseHover(object sender, EventArgs e)
        {
            btnEditar.BackgroundImage = Resources.Editar_Pulsado;
            btnEditar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            btnGuardar.BackgroundImage = Resources.Guardar_Pulsado;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImage = Resources.Volver_Pulsado;
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        //MouseLeave
        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.BackgroundImage = Resources.Editar_No_Pulsado;
            btnEditar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackgroundImage = Resources.Guardar_No_Pulsado;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImage = Resources.Volver_No_Pulsado;
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
