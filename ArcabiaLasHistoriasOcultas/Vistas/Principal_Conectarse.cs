using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Vistas
{
    public partial class Principal_Conectarse : Form
    {
        Principal padre;
        public Principal_Conectarse(Principal padre)
        {
            InitializeComponent();
            this.padre = padre; //Recibe el MDI Parent de Bienvenida, para ser usado más adelante
        }

        private void Principal_Conectarse_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls) 
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.FromArgb(240, 240, 240);
                }
            }
            Conectarse conectarse = new Conectarse(this, padre);
            conectarse.MdiParent = this;
            conectarse.Show();
        }
    }
}
