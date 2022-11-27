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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls) //Este foreach hace que el color de fondo del MDIParent sea el mismo que el predeterminado de Windows Forms
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.FromArgb(240, 240, 240);
                }
            }
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
