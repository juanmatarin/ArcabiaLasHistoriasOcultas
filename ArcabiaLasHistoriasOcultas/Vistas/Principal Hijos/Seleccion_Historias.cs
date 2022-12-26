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
            listaHistorias = ControladorHistorias.getHistorias();
            listaOpciones = new List<Button>();
            cargarBotones();
            foreach (Button button in listaOpciones)
            {
                button.Click += delegate (object s, EventArgs ev) { accionBoton(sender, ev, button.Tag + ""); };
            }
        }

        private void aplicarFondos()
        {
            this.BackgroundImage = Resources.FondoVentanas;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            panel.BackgroundImage = Resources.FondoListas2;
            panel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void cargarBotones()
        {
            foreach (Historia historia in listaHistorias)
            {
                Button botonHistoria = new System.Windows.Forms.Button();
                panel.Controls.Add(botonHistoria);
                botonHistoria.Location = new System.Drawing.Point(ejeX, ejeY);
                botonHistoria.Name = historia.id + "";
                botonHistoria.Size = new System.Drawing.Size(200, 300);
                botonHistoria.TabIndex = 0;
                botonHistoria.Tag = "Historia_" + (historia.id + 1);
                botonHistoria.BackgroundImage = Image.FromFile(@"" + historia.rutaImagen);
                botonHistoria.BackgroundImageLayout = ImageLayout.Stretch;
                botonHistoria.UseVisualStyleBackColor = true;
                botonHistoria.Anchor = AnchorStyles.Right;
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
