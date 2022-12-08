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
    public partial class Conectarse : Form
    {
        Principal_Conectarse padre;
        public Conectarse(Principal_Conectarse padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void iniciarSesionBTN_Click(object sender, EventArgs e)
        {
            Iniciar_Sesion iniSes = new Iniciar_Sesion(padre);
            iniSes.MdiParent = padre;
            iniSes.Show();
            this.Close();
        }

        private void registrarseBTN_Click(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse(padre);
            registrarse.MdiParent = padre;
            registrarse.Show();
            this.Close();
        }

        private void salirBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            padre.Close();
        }

        private void Conectarse_Load(object sender, EventArgs e)
        {

        }
    }
}
