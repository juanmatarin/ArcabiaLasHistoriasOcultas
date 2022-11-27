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
    public partial class Registrarse : Form
    {
        Principal_Conectarse padre;
        public Registrarse(Principal_Conectarse padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void cancelarBTN_Click(object sender, EventArgs e)
        {
            Conectarse conectarse = new Conectarse(padre);
            conectarse.MdiParent = padre;
            conectarse.Show();
            this.Close();
        }
    }
}
