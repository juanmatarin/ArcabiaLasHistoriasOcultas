using ArcabiaLasHistoriasOcultas.Vistas.Varios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Vistas.Principal_Hijos
{
    public partial class Bienvenida_Conectado : Form
    {
        Principal_Conectarse padre;
        string usuario;
        public Bienvenida_Conectado(Principal_Conectarse padre, string usuario_recibido)
        {
            InitializeComponent();
            this.usuario = usuario_recibido;
        }

        private void Bienvenida_Conectado_Load(object sender, EventArgs e)
        {
            toolStripLblUsuario.Text = usuario;
        }

   
    }
}
