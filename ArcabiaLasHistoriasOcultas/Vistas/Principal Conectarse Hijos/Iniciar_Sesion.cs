﻿using ArcabiaLasHistoriasOcultas.Controladores;
using ArcabiaLasHistoriasOcultas.Properties;
using System;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Vistas
{
    public partial class Iniciar_Sesion : Form
    {
        Principal_Conectarse padre;
        FormCollection listaInterfaces;
        int index;
        bool salir;
        public Iniciar_Sesion(Principal_Conectarse padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void Iniciar_Sesion_Load(object sender, EventArgs e)
        {
            listaInterfaces = Application.OpenForms;
            index = 0;
            salir = false;
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

            //Si coinciden usuario y contraseña, sino mostramos error
           if (ControladorUsuarios.ValidarLogin(txtUsuario.Text, txtContraseña.Text))
           {
                MessageBox.Show("Has iniciado sesion");
                Bienvenida bienvenida = new Bienvenida(padre,txtUsuario.Text);
                this.Close();
                
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

        //MouseHover
        private void inisesBTN_MouseHover(object sender, EventArgs e)
        {
            inisesBTN.BackgroundImage = Resources.IniSes_Pulsado;
            inisesBTN.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void volverBTN_MouseHover(object sender, EventArgs e)
        {
            volverBTN.BackgroundImage = Resources.Volver_Pulsado;
            volverBTN.BackgroundImageLayout= ImageLayout.Stretch;
        }

        private void inisesBTN_MouseLeave(object sender, EventArgs e)
        {
            inisesBTN.BackgroundImage = Resources.IniSes_No_Pulsado;
            inisesBTN.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void volverBTN_MouseLeave(object sender, EventArgs e)
        {
            volverBTN.BackgroundImage = Resources.Volver_No_Pulsado;
            volverBTN.BackgroundImageLayout = ImageLayout.Stretch;
        }
    
    }
}
