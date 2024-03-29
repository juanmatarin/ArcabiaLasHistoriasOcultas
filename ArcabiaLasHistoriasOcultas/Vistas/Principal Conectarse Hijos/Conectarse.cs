﻿using ArcabiaLasHistoriasOcultas.Properties;
using System;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Vistas.Principal_Conectarse_Hijos
{
    public partial class Conectarse : Form
    {
        Principal_Conectarse padre;
        Principal padre_bienvenida;
        Bienvenida bienvenida;

        //Constructores
        public Conectarse(Principal_Conectarse padre, Bienvenida bienvenida, Principal padre_bienvenida)
        {
            InitializeComponent();
            this.padre = padre;
            this.padre_bienvenida = padre_bienvenida;
            this.bienvenida = bienvenida;
        }
        public Conectarse(Principal_Conectarse padre)
        {
            InitializeComponent();
            this.padre = padre;
        }


        //Load
        private void Conectarse_Load(object sender, EventArgs e)
        {

        }

        //Click
        private void iniciarSesionBTN_Click(object sender, EventArgs e)
        {
            Iniciar_Sesion iniSes = new Iniciar_Sesion(padre, bienvenida, padre_bienvenida);
            iniSes.MdiParent = padre;
            iniSes.Show();
            this.Close();
        }

        private void registrarseBTN_Click(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse(padre, bienvenida, padre_bienvenida);
            registrarse.MdiParent = padre;
            registrarse.Show();
            this.Close();
        }

        private void salirBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            padre.Close();
        }

        //MouseHover
        private void iniciarSesionBTN_MouseHover(object sender, EventArgs e)
        {
            iniciarSesionBTN.BackgroundImage = Resources.IniSesConectarse_Pulsado;
            iniciarSesionBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void registrarseBTN_MouseHover(object sender, EventArgs e)
        {
            registrarseBTN.BackgroundImage = Resources.Registrar_Pulsado;
            registrarseBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void salirBTN_MouseHover(object sender, EventArgs e)
        {
            salirBTN.BackgroundImage = Resources.VolverCon_Pulsado;
            salirBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        //MouseLeave 

        private void iniciarSesionBTN_MouseLeave(object sender, EventArgs e)
        {
            iniciarSesionBTN.BackgroundImage = Resources.IniSesConectarse_No_Pulsado;
            iniciarSesionBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void registrarseBTN_MouseLeave(object sender, EventArgs e)
        {
            registrarseBTN.BackgroundImage = Resources.Registrar_No_Pulsado_png;
            registrarseBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void salirBTN_MouseLeave(object sender, EventArgs e)
        {
            salirBTN.BackgroundImage = Resources.VolverCon_No_Pulsado;
            salirBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
