using ArcabiaLasHistoriasOcultas.Clases;
using ArcabiaLasHistoriasOcultas.Controladores;
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

namespace ArcabiaLasHistoriasOcultas.Vistas
{
    public partial class Registrarse : Form
    {
        Principal_Conectarse padre;
        public Registrarse(Principal_Conectarse padre)
        {
            InitializeComponent();
            this.padre = padre;
        }
        private void LimpiarErrores()
        {
            lblErrorNombre.Visible = false;
            lblErrorApellidos.Visible = false;
            lblErrorUsername.Visible = false;
            lblErrorEdad.Visible = false;
            lblErrorCorreo.Visible = false;
            lblErrorContraseña.Visible = false;
        }


        private void cancelarBTN_Click(object sender, EventArgs e)
        {
            Conectarse conectarse = new Conectarse(padre);
            conectarse.MdiParent = padre;
            conectarse.Show();
            this.Close();
        }
        private void registrarseBTN_Click(object sender, EventArgs e)
        {

            Usuario nuevoUsuario = new Usuario(txtNombre.Text, txtApellidos.Text, txtUsername.Text, dtpFechaNacimiento.Value, txtCorreo.Text, txtContraseña.Text);
            if (ValidarDatos() && ControladorUsuarios.AñadirUsuario(nuevoUsuario))
            {
                MessageBox.Show("Usuario registrado");
                this.Close();
            }
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

            //comprobamos los apellidos
            if (txtUsername.Text.Trim() == "")
            {
                lblErrorUsername.Visible = true;
                MessageBox.Show("Debes introducir un nombre de usuario");
                txtUsername.SelectAll();
                txtUsername.Focus();
                noHayError = false;
            }

            if (dtpFechaNacimiento.Value >= DateTime.Now.AddYears(-15))
            {
                lblErrorEdad.Visible = true;
                MessageBox.Show("La fecha de nacimiento tiene que ser inferior a hoy");
                dtpFechaNacimiento.Focus();
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

            if (txtContraseña.Text != txtRepetirContraseña.Text)
            {
                lblErrorContraseña.Visible = true;
                MessageBox.Show("Las contraseñas no coinciden");
                txtRepetirContraseña.Focus();
                noHayError = false;
            }

            return noHayError;
        }

    }
}
