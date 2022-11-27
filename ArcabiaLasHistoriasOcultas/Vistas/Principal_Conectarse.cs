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
    public partial class Principal_Conectarse : Form
    {
        public Principal_Conectarse()
        {
            InitializeComponent();
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
            Conectarse conectarse = new Conectarse(this);
            conectarse.MdiParent = this;
            conectarse.Show();
        }
    }
}
