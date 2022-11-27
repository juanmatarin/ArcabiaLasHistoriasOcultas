using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Vistas.Varios
{
    public partial class Confirmacion_Salir : Form
    {
        public Confirmacion_Salir()
        {
            InitializeComponent();
        }

        private void siBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NoBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
