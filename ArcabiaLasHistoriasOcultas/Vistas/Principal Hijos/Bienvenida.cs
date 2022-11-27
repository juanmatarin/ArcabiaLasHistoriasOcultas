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

namespace ArcabiaLasHistoriasOcultas.Vistas
{
    public partial class Bienvenida : Form
    {
        Principal padre; //Esto es la ventana padre que se va pasando entre los hijos para que salgan todos dentro de principal con los botones de la vista que se carga dentro
        public Bienvenida(Principal padre)
        {
            InitializeComponent();
            this.padre = padre; //Recibe la vista padre
        }

        private void nuevaPartidaBTN_Click(object sender, EventArgs e)
        {
            Seleccion_Historias seleccion_Historias = new Seleccion_Historias(padre);
            seleccion_Historias.MdiParent = padre; //Se establece la vista padre como MdiParent
            //seleccion_Historias = (Seleccion_Historias) centrarVentana(seleccion_Historias);
            seleccion_Historias.Show(); //Al mostrarla se mostrará dentro de Principal
            this.Close();
        }

        private void cargarPartidaBTN_Click(object sender, EventArgs e)
        {
            Seleccion_Partidas_Guardadas seleccion_Partidas_Guardadas = new Seleccion_Partidas_Guardadas(padre);
            seleccion_Partidas_Guardadas.MdiParent = padre;
            //seleccion_Partidas_Guardadas = (Seleccion_Partidas_Guardadas) centrarVentana(seleccion_Partidas_Guardadas);
            seleccion_Partidas_Guardadas.Show();
            this.Close();
        }

        private void continuarPartidaBTN_Click(object sender, EventArgs e)
        {
            Juego juego = new Juego(padre, "Historia_1", 0);
            juego.MdiParent = padre;
            //juego = (Juego) centrarVentana(juego);
            juego.Show();
            this.Close();
        }

        private void conectarseBTN_Click(object sender, EventArgs e)
        {
            Principal_Conectarse conectarse = new Principal_Conectarse();
            conectarse.Show();
        }

        private void salirBTN_Click(object sender, EventArgs e)
        {
            Confirmacion_Salir confirmacion_Salir = new Confirmacion_Salir();
            confirmacion_Salir.Show();
        }

        private Form centrarVentana(Form vista)
        {
            Form aux = vista;
            aux.StartPosition = FormStartPosition.Manual;
            aux.Location = new Point((this.ClientSize.Width - vista.Width) / 2,
                                            (this.ClientSize.Height - vista.Height) / 2); //Esto es porque, de otra forma no se centra el hijo dentro del padre (desconozco el motivo de esto).
            return aux;
        }
    }
}
