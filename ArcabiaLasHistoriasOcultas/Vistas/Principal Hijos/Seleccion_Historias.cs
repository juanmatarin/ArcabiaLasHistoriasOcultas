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
        public Seleccion_Historias(Principal padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void historias_sahir_Click(object sender, EventArgs e)
        {
            Juego juego = new Juego(padre, "Historia_1", 0);
            juego.MdiParent = padre;
            juego.Show();
            this.Close();
        }
    }
}
