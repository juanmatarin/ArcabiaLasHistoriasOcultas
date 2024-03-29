﻿using ArcabiaLasHistoriasOcultas.Controladores;
using ArcabiaLasHistoriasOcultas.Properties;
using ArcabiaLasHistoriasOcultas.Vistas.Principal_Conectarse_Hijos;
using System;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Vistas
{
    public partial class Iniciar_Sesion : Form
    {
        Principal_Conectarse padre;
        Principal padre_bienvenida;
        Bienvenida bienvenida;
        FormCollection listaInterfaces;
        int index, contadorError;
        bool salir;
        public Iniciar_Sesion(Principal_Conectarse padre, Bienvenida bienvenida, Principal padre_bienvenida)
        {
            InitializeComponent();
            this.padre = padre;
            this.padre_bienvenida = padre_bienvenida;
            this.bienvenida = bienvenida;
        }

        private void Iniciar_Sesion_Load(object sender, EventArgs e)
        {
            listaInterfaces = Application.OpenForms;
            index = 0;
            contadorError = 0;
            salir = false;
        }

        private void inisesBTN_Click(object sender, EventArgs e)
        {

            //Si coinciden usuario y contraseña, sino mostramos error
            if (validarCampos())
            {
                if (ControladorUsuarios.comprobarSiUsuarioExiste(txtUsuario.Text))
                {
                    if (ControladorUsuarios.validarLogin(txtUsuario.Text, txtContraseña.Text))
                    {
                        MessageBox.Show("Has iniciado sesion");
                        borrarVentana(bienvenida);
                        Bienvenida bienvenida1 = new Bienvenida(padre_bienvenida, txtUsuario.Text, true);
                        bienvenida1.MdiParent = padre_bienvenida;
                        this.Close();
                        borrarVentana(padre);
                        bienvenida1.Show();
                    }
                    else
                    {
                        lblError.Visible = true;
                        contadorError++;
                        if (contadorError >= 3)
                        {
                            linkLabelContrasenaOlvidada.Visible = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El usuario introducido no existe");
                }
            }
        }


        private void volverBTN_Click(object sender, EventArgs e)
        {
            Conectarse conectarse = new Conectarse(padre, bienvenida, padre_bienvenida);
            conectarse.MdiParent = padre;
            conectarse.Show();
            this.Close();
        }


        private void borrarVentana(Form Ventana)
        {
            while (!salir)
            {
                if (listaInterfaces[index].GetType().Equals(Ventana.GetType())) //Busca la interfaz que sea de tipo Juego
                {
                    salir = true;
                    listaInterfaces[index].Close(); //Si la encuentra sale del bucle y cierra la interfaz encontrada
                    index = 0;
                }
                else
                {
                    if (index == listaInterfaces.Count)
                    {
                        salir = true; //Si llega al tope de la lista, sale del bucle
                        index = 0;
                    }
                    else
                    {
                        ++index; //Si no, se sigue buscando en la lista
                    }
                }
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
            Registrarse registrarse = new Registrarse(padre, bienvenida, padre_bienvenida);
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

        private void linkLabelContrasenaOlvidada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CambiarContrasena cambiarContrasena = new CambiarContrasena(padre, bienvenida, padre_bienvenida, txtUsuario.Text);
            cambiarContrasena.MdiParent = padre;
            this.Close();
            cambiarContrasena.Show();
        }

        private void volverBTN_MouseLeave(object sender, EventArgs e)
        {
            volverBTN.BackgroundImage = Resources.Volver_No_Pulsado;
            volverBTN.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private bool validarCampos()
        {
            bool noHayError = true;

            //comprobamos el Nombre
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("El usuario no puede estar vacío");
                txtUsuario.SelectAll();
                txtUsuario.Focus();
                noHayError = false;
            }
            //comprobamos la Contraseña
            if (txtContraseña.Text.Trim() == "")
            {
                MessageBox.Show("La contraseña no puede estar vacía");
                txtContraseña.SelectAll();
                txtContraseña.Focus();
                noHayError = false;
            }
            return noHayError;
        }

    }
}
