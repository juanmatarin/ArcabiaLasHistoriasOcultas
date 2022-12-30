﻿using ArcabiaLasHistoriasOcultas.Clases;
using ArcabiaLasHistoriasOcultas.Controladores;
using ArcabiaLasHistoriasOcultas.Properties;
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
    public partial class Bienvenida : Form
    {
        Principal padre; //Esto es la ventana padre que se va pasando entre los hijos para que salgan todos dentro de principal con los botones de la vista que se carga dentro
        List<Partida> listaPartidas;

        //Constructor
        public Bienvenida(Principal padre)
        {
            InitializeComponent();
            this.padre = padre; //Recibe la vista padre
        }

        //Load
        private void Bienvenida_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.FondoVentanas;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Resources.Título_de_inicio;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.Transparent;
            usuarioConectado.Visible = false;
        }

        //Click
        private void nuevaPartidaBTN_Click(object sender, EventArgs e)
        {
            Seleccion_Historias seleccion_Historias = new Seleccion_Historias(padre);
            seleccion_Historias.MdiParent = padre; //Se establece la vista padre como MdiParent
            seleccion_Historias.Show(); //Al mostrarla se mostrará dentro de Principal
        }
        private void cargarPartidaBTN_Click(object sender, EventArgs e)
        {
            listaPartidas = ControladorPartidas.getPartidas();
            if (listaPartidas.Count != 0) //Si hay partidas guardadas muestra la ventana de manera normal
            {
                Seleccion_Partidas_Guardadas seleccion_Partidas_Guardadas = new Seleccion_Partidas_Guardadas(padre, false); //False es para determinar que no está en una partida ya empezada.
                seleccion_Partidas_Guardadas.MdiParent = padre;
                seleccion_Partidas_Guardadas.Show();
            }
            else
            {
                MessageBox.Show("No hay partidas guardadas", "Arcabia: Las Historias Ocultas"); //Si no hay partidas, muestra un mensaje.
            }
        }
        private void continuarPartidaBTN_Click(object sender, EventArgs e)
        {
            listaPartidas = ControladorPartidas.getPartidas(); //Carga la lista de partidas
            if (listaPartidas.Count != 0) //Si es mayor de 0 compara las fechas de la lista para ordenarlas por fecha
                                          //y sacar la última partida guardada por fecha
            {
                listaPartidas.Sort((x, y) => DateTime.Compare(x.fechaGuardado, y.fechaGuardado));
                Partida partida = listaPartidas.Last();
                Juego juego = new Juego(padre, partida.historia, partida.numeroActo, false, partida.rutaInstrucciones);
                juego.MdiParent = padre;
                //juego = (Juego) centrarVentana(juego);
                juego.Show();
            }
            else
            {
                MessageBox.Show("No hay partidas guardadas", "Arcabia: Las Historias Ocultas"); //Si no hay partidas en la lista, muestra un mensaje.
            }

        }
        private void conectarseBTN_Click(object sender, EventArgs e)
        {
            if (ControladorBaseDeDatos.comprobarConexión())
            {
                Principal_Conectarse conectarse = new Principal_Conectarse();
                conectarse.Show();
            }
            else
            {
                MessageBox.Show("Error al conectarse a la Base de Datos.", "Arcabia: Las Historias Ocultas");
            }
            
        }
        private void salirBTN_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Sale de la aplicación
        }

        //MouseHover
        private void salirBTN_MouseHover(object sender, EventArgs e)
        {
            salirBTN.BackgroundImage = Resources.SalirJuego_Pulsado;
            salirBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        private void cargarPartidaBTN_MouseHover(object sender, EventArgs e)
        {
            cargarPartidaBTN.BackgroundImage = Resources.CargarPartida_Pulsado;
            cargarPartidaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        private void continuarPartidaBTN_MouseHover(object sender, EventArgs e)
        {
            continuarPartidaBTN.BackgroundImage = Resources.ContinuarPartida_Pulsado;
            continuarPartidaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        private void nuevaPartidaBTN_MouseHover(object sender, EventArgs e)
        {
            nuevaPartidaBTN.BackgroundImage = Resources.NuevaPartida_Pulsado;
            nuevaPartidaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }


        //MouseLeave
        private void salirBTN_MouseLeave(object sender, EventArgs e)
        {
            salirBTN.BackgroundImage = Resources.SalirJuego_No_Pulsado;
            salirBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        private void cargarPartidaBTN_MouseLeave(object sender, EventArgs e)
        {
            cargarPartidaBTN.BackgroundImage = Resources.CargarPartida_No_Pulsado;
            cargarPartidaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        private void continuarPartidaBTN_MouseLeave(object sender, EventArgs e)
        {
            continuarPartidaBTN.BackgroundImage = Resources.ContinuarPartida_No_Pulsado;
            continuarPartidaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        private void nuevaPartidaBTN_MouseLeave(object sender, EventArgs e)
        {
            nuevaPartidaBTN.BackgroundImage = Resources.NuevaPartida_No_Pulsado;
            nuevaPartidaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        //FormClosing
        private void Bienvenida_FormClosing(object sender, FormClosingEventArgs e) //Esto se ejecuta en el momento que se va a cerrar la ventana.
        {
            if (MessageBox.Show("¿Seguro que quiere salir del juego?", "Arcabia: Las Historias Ocultas",
                    MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
