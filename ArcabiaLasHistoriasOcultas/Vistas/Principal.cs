using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            //Principal hace de contenedor para el resto de ventanas poniendo cada una como vistas hijas de principal
            Bienvenida bienvenida = new Bienvenida(this);
            bienvenida.MdiParent = this;
            bienvenida.StartPosition = FormStartPosition.Manual;
            bienvenida.Location = new Point((this.ClientSize.Width - bienvenida.Width) / 2, 
                                            (this.ClientSize.Height - bienvenida.Height) / 2); //Esto es porque, de otra forma no se centra el hijo dentro del padre (desconozco el motivo de esto).
            bienvenida.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
