using ArcabiaLasHistoriasOcultas.Controladores;
using ArcabiaLasHistoriasOcultas.Vistas.Principal_Hijos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Vistas
{
    public partial class Iniciar_Sesion : Form
    {
        Principal_Conectarse padre;
        public Iniciar_Sesion(Principal_Conectarse padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void Iniciar_Sesion_Load(object sender, EventArgs e)
        {
        
        }

        private void volverBTN_Click(object sender, EventArgs e)
        {
            Conectarse conectarse = new Conectarse(padre);
            conectarse.MdiParent = padre;
            conectarse.Show();
            this.Close();
        }

        private void inisesBTN_Click(object sender, EventArgs e)
        {
            //Globales.GrabarLog("Usuario " + txtUsuario.Text + " intentando entrar");

            //Si coinciden usuario y contraseña, sino mostramos error
            if (ControladorUsuarios.ValidarLogin(txtUsuario.Text, txtContraseña.Text))
            {
                MessageBox.Show("Has iniciado sesion");
                this.Close();
                Bienvenida_Conectado bienvenida = new Bienvenida_Conectado(padre,txtUsuario.Text);
                bienvenida.Show();

            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void usuarioTXTB_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void contrasenaTXTB_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void linkLabelCrearUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarse registrarse = new Registrarse(padre);
            this.Close();
            registrarse.Show();
        }
    }
}
