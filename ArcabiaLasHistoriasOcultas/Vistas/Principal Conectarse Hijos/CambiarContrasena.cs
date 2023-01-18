using ArcabiaLasHistoriasOcultas.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Vistas.Principal_Conectarse_Hijos
{
    public partial class CambiarContrasena : Form
    {
        Principal_Conectarse padre;
        Principal padre_bienvenida;
        Bienvenida bienvenida;
        string nombreUsuario;
        public CambiarContrasena(Principal_Conectarse padre, Bienvenida bienvenida, Principal padre_bienvenida, string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.padre = padre;
            this.bienvenida = bienvenida;
            this.padre_bienvenida = padre_bienvenida;
        }

        public bool ValidarContraseñas()
        {
            bool noHayError = true;
            lblErrorContraseñas.Visible = false;
            if (txtContraseña.Text != txtRepetirContraseña.Text)
            {
                lblErrorContraseñas.Visible = true;
                txtRepetirContraseña.Focus();
                noHayError = false;
            }
            return noHayError;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarContraseñas())
            {
                ControladorUsuarios.actualizarContraseña(nombreUsuario, txtContraseña.Text);
                Iniciar_Sesion iniSes = new Iniciar_Sesion(padre, bienvenida, padre_bienvenida);
                iniSes.MdiParent = padre;
                iniSes.Show();
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Iniciar_Sesion iniciar_Sesion = new Iniciar_Sesion(padre, bienvenida, padre_bienvenida);
            iniciar_Sesion.MdiParent = padre;
            iniciar_Sesion.Show();
            this.Close();
        }
    }
}
