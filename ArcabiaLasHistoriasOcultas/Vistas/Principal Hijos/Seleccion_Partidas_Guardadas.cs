using ArcabiaLasHistoriasOcultas.Clases;
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

namespace ArcabiaLasHistoriasOcultas.Vistas
{
    public partial class Seleccion_Partidas_Guardadas : Form
    {
        Principal padre;
        List<Partida> listaPartidas;
        FormCollection listaInterfaces;
        int index;
        bool salir, partidaEmpezada;
        public Seleccion_Partidas_Guardadas(Principal padre, bool partidaEmpezada)
        {
            InitializeComponent();
            this.padre = padre;
            this.partidaEmpezada = partidaEmpezada;
        }
        private void Seleccion_Partidas_Guardadas_Load(object sender, EventArgs e)
        {
            listaPartidas = ControladorPartidas.getPartidas();
            listaInterfaces = Application.OpenForms;
            listaPartidas.Sort((x, y) => DateTime.Compare(x.fechaGuardado, y.fechaGuardado));
            PartidasLST.DataSource = listaPartidas;
            PartidasLST.DisplayMember = "nombreCompleto";
            salir = false;
            index = 0;
        }

        private void seleccionarBTN_Click(object sender, EventArgs e)
        {

            if (partidaEmpezada) //Si es una partida nueva empezada, hace lo siguiente:
            {
                while (!salir) //Si salir está a false, no sale del bucle
                {
                    if (listaInterfaces[index].GetType().Equals(typeof(Juego))) //Busca la interfaz que sea de tipo Juego
                    {
                        salir = true;
                        listaInterfaces[index].Close(); //Si la encuentra sale del bucle y cierra la interfaz encontrada
                    }
                    else
                    {
                        if (index == listaInterfaces.Count)
                        {
                            salir = true; //Si llega al tope de la lista, sale del bucle
                        }
                        else
                        {
                            ++index; //Si no, se sigue buscando en la lista
                        }
                    }
                }
            }

            Partida partidaSeleccionada = PartidasLST.SelectedValue as Partida; //Se coge el valor seleccionado en la lista
            Juego juego = new Juego(padre, partidaSeleccionada.historia, partidaSeleccionada.numeroActo, false, partidaSeleccionada.rutaInstrucciones);
            juego.MdiParent = padre;
            juego.Show();
            this.Close(); //Abre la pestaña nueva y se cierra la ventana
        }

        private void volverBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
