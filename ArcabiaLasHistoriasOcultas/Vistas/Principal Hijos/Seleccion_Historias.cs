using ArcabiaLasHistoriasOcultas.Clases;
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
    public partial class Seleccion_Historias : Form
    {
        Principal padre;
        List<Historia> listaHistorias;
        List<Button> listaOpciones;
        int ejeX, ejeY;
        public Seleccion_Historias(Principal padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void Seleccion_Historias_Load(object sender, EventArgs e)
        {
            aplicarFondos();
            ajustarBarraConPanel();
            listaHistorias = ControladorHistorias.getHistorias();
            listaOpciones = new List<Button>();
            cargarBotones();
            foreach (Button button in listaOpciones)
            {
                button.Click += delegate (object s, EventArgs ev) { accionBoton(sender, ev, button.Tag + ""); };
            }
        }

        private void ajustarBarraConPanel()
        {
            barraLateral.Value = panel.VerticalScroll.Value;
            barraLateral.Minimum = panel.VerticalScroll.Minimum;
            barraLateral.Maximum = panel.VerticalScroll.Maximum;
            panel.ControlAdded += Panel_ControlAdded;
            barraLateral.Scroll += BarraLateral_Scroll;
            ejeX = (panel.Size.Width * 60) / 100;
            ejeY = (panel.Size.Height * 60) / 100;
        }

        private void aplicarFondos()
        {
            this.BackgroundImage = Resources.FondoVentanas;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            panel.BackgroundImage = Resources.FondoListas;
            panel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void BarraLateral_Scroll(object sender, ScrollEventArgs e)
        {
            barraLateral.Value = panel.VerticalScroll.Value;
        }

        private void Panel_ControlAdded(object sender, ControlEventArgs e)
        {
            barraLateral.Maximum = panel.VerticalScroll.Maximum;
        }

        private void cargarBotones()
        {
            foreach (Historia historia in listaHistorias)
            {
                Button botonHistoria = new System.Windows.Forms.Button();
                panel.Controls.Add(botonHistoria);
                botonHistoria.Location = new System.Drawing.Point(ejeX, ejeY);
                botonHistoria.Name = historia.id + "";
                botonHistoria.Size = new System.Drawing.Size(88, 100);
                botonHistoria.TabIndex = 0;
                botonHistoria.Tag = "Historia_" + (historia.id + 1);
                botonHistoria.Text = historia.nombre;
                botonHistoria.UseVisualStyleBackColor = true;
                ejeX += 60;
                if (ejeX > (this.Size.Width * 80) / 100)
                {
                    ejeX = 100;
                }
                listaOpciones.Add(botonHistoria);
            }
        }

        private void accionBoton(object sender, EventArgs e, string numeroHistoria)
        {
            Juego juego = new Juego(padre, "Historia_" + numeroHistoria, 0, true, @"..\..\Archivos\Historias\" + numeroHistoria);
            juego.MdiParent = padre;
            juego.Show();
            this.Close();
        }
    }
}
