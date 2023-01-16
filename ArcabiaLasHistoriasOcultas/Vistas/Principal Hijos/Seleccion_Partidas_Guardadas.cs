using ArcabiaLasHistoriasOcultas.Clases;
using ArcabiaLasHistoriasOcultas.Clases.DTO;
using ArcabiaLasHistoriasOcultas.Controladores;
using ArcabiaLasHistoriasOcultas.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Vistas
{
    public partial class Seleccion_Partidas_Guardadas : Form
    {
        Principal padre;
        List<Partida> listaPartidas;
        FormCollection listaInterfaces;
        int index;
        bool salir, partidaEmpezada, haIniciadoSesion;
        int idUsuarioConectado;
        public Seleccion_Partidas_Guardadas(Principal padre, bool partidaEmpezada)
        {
            InitializeComponent();
            this.padre = padre;
            this.partidaEmpezada = partidaEmpezada;
        }
        public Seleccion_Partidas_Guardadas(Principal padre, bool partidaEmpezada, bool haIniciadoSesion, int idUsuarioConectado)
        {
            InitializeComponent();
            this.padre = padre;
            this.partidaEmpezada = partidaEmpezada;
            this.haIniciadoSesion = haIniciadoSesion;
            this.idUsuarioConectado = idUsuarioConectado;
        }
        private void Seleccion_Partidas_Guardadas_Load(object sender, EventArgs e)
        {
            listaInterfaces = Application.OpenForms;
            cargarLista();
            salir = false;
            index = 0;
        }

        public void cargarLista()
        {
            if (haIniciadoSesion)
            {
                listaPartidas = ControladorPartidas.getPartidas(haIniciadoSesion);
                listaPartidas.Sort((x, y) => DateTime.Compare(x.fechaGuardado, y.fechaGuardado));
                PartidasLST.DataSource = listaPartidas;
                PartidasLST.DisplayMember = "nombreCompleto";
            }
            else
            {
                listaPartidas = ControladorPartidas.getPartidas(haIniciadoSesion);
                listaPartidas.Sort((x, y) => DateTime.Compare(x.fechaGuardado, y.fechaGuardado));
                PartidasLST.DataSource = listaPartidas;
                PartidasLST.DisplayMember = "nombreCompleto";
            }
            
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
                        index = 0;
                    }
                    else
                    {
                        if (index == listaPartidas.Count)
                        {
                            salir = true; //Si llega al tope de la lista, sale del bucle
                            index = 0;
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

        private void borrarBTN_Click(object sender, EventArgs e)
        {
            if (!partidaEmpezada)
            {
                if (MessageBox.Show("¿Está seguro que quiere borrar esta partida? Esta acción no se puede deshacer", "Arcabia: Las Historias Ocultas",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Partida elegida = (Partida)PartidasLST.SelectedValue;
                    salir = false;
                    while (!salir)
                    {
                        if (listaPartidas[index].id == elegida.id)
                        {
                            //Hay que borrar la partida en local, y en la base de datos, aunque no esté conectado
                            if (haIniciadoSesion)
                            {
                                if (ControladorPartidas.comprobarIdPartida(elegida.id))//Si esta partida existe en la base de datos, y estamos conectados, es borrada
                                {
                                    ControladorPartidas.borrarPartidaBD(elegida.id);
                                    ControladorIO.borrarPartidaLocal(elegida.id);
                                    listaPartidas.Remove(listaPartidas[index]);//También la borramos en local
                                    ControladorPartidas.guardarPartidas(listaPartidas);
                                    MessageBox.Show("Partida borrada en local y en la base de datos con éxito.");
                                }
                                else
                                {
                                    MessageBox.Show("Esta partida no se puede borrar al no haber iniciado sesión ya que se creó en la nube.");
                                }
                            }
                            else//Si esta partida no está en la base de datos, solo se borra de local
                            {
                                ControladorIO.borrarPartidaLocal(elegida.id);
                                listaPartidas.Remove(listaPartidas[index]);//También la borramos en local
                                ControladorPartidas.guardarPartidas(listaPartidas);
                                MessageBox.Show("Partida borrada en local con éxito.");
                            }
                            
                            
                            cargarLista();
                            salir = true;
                            index = 0;
                            if (listaPartidas.Count == 0)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            if (index == listaPartidas.Count)
                            {
                                salir = true; //Si llega al tope de la lista, sale del bucle
                                index = 0;
                            }
                            else
                            {
                                ++index; //Si no, se sigue buscando en la lista
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pueden eliminar partidas cuando hay una en transcurso. Accede a esta opción desde el menú principal");
            }
            
        }

        private void volverBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
