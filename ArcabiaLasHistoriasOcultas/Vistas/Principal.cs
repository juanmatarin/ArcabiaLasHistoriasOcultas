using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Vistas
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            Image imagenDeFondo = Properties.Resources.Fondo;
            this.BackgroundImage = imagenDeFondo;//redimensionarImagen(imagenDeFondo);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackColor = Color.Black;

            //Principal hace de contenedor para el resto de ventanas poniendo cada una como vistas hijas de principal
            Bienvenida bienvenida = new Bienvenida(this);
            bienvenida.MdiParent = this;
            bienvenida.StartPosition = FormStartPosition.Manual;
            bienvenida.Location = new Point((this.ClientSize.Width - bienvenida.Width) / 2, 
                                            (this.ClientSize.Height - bienvenida.Height) / 2); //Esto es porque, de otra forma no se centra el hijo dentro del padre (desconozco el motivo de esto).
            bienvenida.Show();
        }

        private Image redimensionarImagen(Image imagen)
        {
            Bitmap b = new Bitmap(imagen.Width, imagen.Height);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            var altura = imagen.Height; /// this.Height;
            var anchura = imagen.Width; /// this.Width;
            // Draw image with new width and height  
            g.DrawImage(imagen, 0, 0, altura, anchura);
            g.Dispose();
            
            return b;
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
