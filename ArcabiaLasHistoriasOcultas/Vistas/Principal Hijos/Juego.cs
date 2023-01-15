using ArcabiaLasHistoriasOcultas.Clases;
using ArcabiaLasHistoriasOcultas.Controladores;
using ArcabiaLasHistoriasOcultas.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Vistas
{
    public partial class Juego : Form
    {
        Principal padre;
        List<Button> listaOpciones;
        List<Acto> listaActos;
        List<Partida> listaPartidas;
        int ejeX, ejeY, numeroActo;
        string rutaPartida, historia;
        bool haSeleccionadoOpcion, partidaNueva, haGuardado;

        //Constructor
        public Juego(Principal padre, string historia, int numeroActo, bool partidaNueva, string rutaPartida)
        {
            InitializeComponent();
            this.padre = padre;
            this.ejeY = ( panel1.Height * 20 ) / 100;
            this.ejeX = (panel1.Width * 40) / 100;
            this.numeroActo = numeroActo;
            this.partidaNueva = partidaNueva;
            this.rutaPartida = rutaPartida;
            this.historia = historia;
        }

        //Load
        private void Juego_Load(object sender, EventArgs e)
        {
            listaActos = ControladorActos.getListaActos(rutaPartida);
            ControladorHistorias.addHistoriaNuevaLocal(listaActos);
            listaOpciones = new List<Button>();
            listaPartidas = ControladorPartidas.getPartidas();
            haSeleccionadoOpcion = false;
            if (partidaNueva)
            {
                haGuardado = false; //Si la partida es nueva se marca el guardado como false (Para que se tenga en cuenta si se guarda o no)
            }
            else
            {
                haGuardado = true; //Si la partida no es nueva se marca el guardado como true (Ya que existe un archivo de guardado)
            }
            cargarActo();
        }

        //Click
        private void cargarBTN_Click(object sender, EventArgs e)
        {
            if (listaPartidas.Count != 0)
            {
                Seleccion_Partidas_Guardadas seleccion_Partidas_Guardadas = new Seleccion_Partidas_Guardadas(padre, true); //True es para determinar que se cambia de partida en medio de otra.
                seleccion_Partidas_Guardadas.MdiParent = padre;
                seleccion_Partidas_Guardadas.Show(); //Carga la interfaz dentro del MdiParent
            }
            else
            {
                MessageBox.Show("No hay partidas guardadas.");
            }
        }
        private void GuardarBTN_Click(object sender, EventArgs e)
        {
            int id;
            if (listaPartidas.Count > 0)
            {
                id = listaPartidas.Max(x => x.id) + 1;
            }
            else
            {
                id = 1;
            }
            Partida partidaGuardada = new Partida(id, historia, numeroActo, rutaPartida);
            if (partidaNueva) //Si la partida es una comenzada de nuevo...
            {
                partidaGuardada.rutaInstrucciones = ControladorDirectorios.crearDirectorio(@"..\..\Archivos\Partidas\Partida_", id); //... se crea un directorio para la nueva partida a guardar.

            }
            listaPartidas.Add(partidaGuardada);

            if (ControladorPartidas.guardarPartidas(listaPartidas)) //Comprueba si no hay ningún fallo al guardar
            {
                if (ControladorActos.guardarListaActos(listaActos, partidaGuardada.rutaInstrucciones))
                {
                    MessageBox.Show("Partida guardada con éxito");
                    haGuardado = true; //Se confirma que se ha guardado la partida.
                    listaPartidas = ControladorPartidas.getPartidas();
                }
                else
                {
                    MessageBox.Show("ERROR al guardar el json con las decisiones.");
                }
            }
            else
            {
                MessageBox.Show("ERROR al guardar en el json de partidas.");
            }

        }
        private void salirBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //MouseHover
        private void GuardarBTN_MouseHover(object sender, EventArgs e)
        {
            GuardarBTN.BackgroundImage = Resources.Guardar_Pulsado;
            GuardarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        private void cargarBTN_MouseHover(object sender, EventArgs e)
        {
            cargarBTN.BackgroundImage = Resources.Cargar_Pulsado;
            cargarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        private void salirBTN_MouseHover(object sender, EventArgs e)
        {
            salirBTN.BackgroundImage = Resources.SalirMenu_Pulsado;
            salirBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        //MouseLeave
        private void GuardarBTN_MouseLeave(object sender, EventArgs e)
        {
            GuardarBTN.BackgroundImage = Resources.Guardar_No_Pulsado;
            GuardarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void cargarBTN_MouseLeave(object sender, EventArgs e)
        {
            cargarBTN.BackgroundImage = Resources.Cargar_No_Pulsado;
            cargarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void salirBTN_MouseLeave(object sender, EventArgs e)
        {
            salirBTN.BackgroundImage = Resources.SalirMenu_No_Pulsado;
            salirBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        //Form Closing
        private void Juego_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!haGuardado) //Si no ha guardado la partida, sale una ventana preguntando si está seguro de que desea salir de la partida.
            {
                if (MessageBox.Show("No se ha guardado el progreso. ¿Continuar?", "Arcabia: Las Historias Ocultas",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        //Métodos Varios
        private void cargarActo() 
        {
            borrarOpciones(); //Se borran los botones del panel
            ventanaTexto.DocumentText = ControladorActos.getTexto(listaActos[numeroActo].ruta); //Se carga en el webBrowser el archivo en la ruta especificada en el acto correspondiente (controlado por numeroActo).
            crearOpcíones(listaActos[numeroActo].opciones); //Se crean los botones con todas las opciones.
            foreach (Button button in listaOpciones)
            {
                button.Click += delegate (object sender, EventArgs ev) { accionBoton(sender, ev, listaActos[numeroActo].opciones[Int32.Parse(button.Tag.ToString())]); }; //Se añaden las acciones a cada botón.
            }
        }
        private void cargarOpcion(Opcion op) //Esto se carga en caso de que un acto tenga varias opciones.
        {
            List<Opcion> aux = new List<Opcion>(); //Se crea una lista auxiliar.
            aux.Add(op); //Se añade la opcion recibida.
            borrarOpciones(); //Se borran las anteriores opciones.
            ventanaTexto.DocumentText = ControladorActos.getTexto(op.ruta); //Se carga el texto de la ruta especificada de la opcion.
            crearOpcíones(aux); //Se crean los botones.
            foreach (Button button in listaOpciones)
            {
                button.Click += delegate (object sender, EventArgs ev) { accionBoton(sender, ev, listaActos[numeroActo].opciones[Int32.Parse(button.Tag.ToString())]); }; //Acciones para cada botón.
            }
        }
        private void cargarOpcionNoValida(int opcionAMostrar, int opcionAOcultar)
        {
            Opcion op = listaActos[numeroActo].opciones[opcionAMostrar]; //Se carga la opción que se debe de mostrar el texto
            ventanaTexto.DocumentText = ControladorActos.getTexto(op.ruta); //Se carga en el webBrowser
            borrarOpcionIndividual(opcionAOcultar); //Se borra la opción ya elegida
        }
        private void borrarOpciones()
        {
            foreach (Button btn in listaOpciones) //Se borran todos los botones.
            {
                panel1.Controls.Remove(btn);
            }
        }
        private void borrarOpcionIndividual(int opcionAOcultar)
        {
            foreach (Button btn in listaOpciones)
            {
                if (Int32.Parse(btn.Name) == opcionAOcultar) //Si el id del botón (el cual es el id de la opcion) coincide con el recibido, se borra del control.
                {
                    panel1.Controls.Remove(btn);
                }
            }
        }
        private void accionBoton(object sender, EventArgs e, Opcion op)
        {
            
            if (!listaActos[numeroActo].ruta.Equals("[FIN]")) //Si el siguienteActo (variable de op) es 0, significa que la historia se ha acabado. 
            {
                if (op.tipo.Equals("opcion") && haSeleccionadoOpcion == false) //Si la opcion es una entre varias (pudiendo desenvocar en distintos resultados)
                                                                               //y es la primera vez que se selecciona
                                                                               //(ya que, en el json debe de acceder a su propia ruta para mostrar el texto) accede al condicionante.
                {
                    if (op.decisionCondicionante)
                    {
                        listaActos[numeroActo].opciones[op.id].decisionElegida = true; //Si la opción que se ha elegido es una decisión que se debe de guardar,
                                                                                       //pone el valor decisionElegida a True
                    }

                    if (op.decisionAConsiderarActo != 0) //Si la decision a considerar es distinto de 0,
                                                         //significa que el resultado cambiará si se ha hecho una decisión anteriormente
                    {
                        if (!listaActos[op.decisionAConsiderarActo].opciones[op.decisionAConsiderarOpcion].decisionElegida) //Si la decisión que indica la opción no se ha marcado con anterioridad,
                                                                                                                            //esta opción se elimina y muestra un texto distinto
                        {
                            cargarOpcionNoValida(listaActos[numeroActo].opciones[op.id].opcionAMostrar, op.id); //Se pasa a este método la opcion resultante y la opción elegida
                        }
                        else
                        {
                            haSeleccionadoOpcion = true; //Se marca a true para indicar que se ha seleccionado una opcion.
                            haGuardado = false; //Marca que no se ha guardado la partida, puesto que ha avanzado la historia desde que se ha guardado.
                            cargarOpcion(op); //Se carga un método especifico para las opciones.
                        }
                    }
                    else
                    {
                        haSeleccionadoOpcion = true; //Se marca a true para indicar que se ha seleccionado una opcion.
                        haGuardado = false; //Marca que no se ha guardado la partida, puesto que ha avanzado la historia desde que se ha guardado.
                        cargarOpcion(op); //Se carga un método especifico para las opciones.
                    }
                }
                else
                {
                    if (op.siguienteActo == 0) //Si el siguiente acto es igual a 0 significa que la historia ha acabado
                    {
                        MessageBox.Show("Has terminado la Historia.");
                        Bienvenida bienvenida = new Bienvenida(padre);
                        bienvenida.MdiParent = padre;
                        bienvenida.Show();
                        haGuardado = true;
                        this.Close(); //Muestra un mensaje y cierra la ventana
                    }
                    else
                    {
                        haSeleccionadoOpcion = false; //Se marca false de nuevo ya que se va a pasar a otro acto
                        numeroActo = op.siguienteActo; //La variable que marca el index pasa a ser el siguiente acto que marca la opcion
                        haGuardado = false; //Marca que no se ha guardado la partida, puesto que ha avanzado la historia desde que se ha guardado.
                        cargarActo(); //Se carga el acto
                    }
                }
                
            }
        }
        private void crearOpcíones(List<Opcion> opciones)
        {
            string descripcion;
            bool masDeUnaOpcion;

            if (opciones.Count > 1) //Si hay más de una opción...
            {
                ejeX = ejeX - (30 * opciones.Count); //Se divide ej eje de inicio entre 30 * el número de opciones que haya en la lista.
                masDeUnaOpcion = true;
            }
            else
            {
                masDeUnaOpcion = false;
            }

            foreach (Opcion op in opciones) //Se crea un botón por cada opción de la lista de opciones.
            {
                if (!op.tipo.Equals("decision"))
                {
                    if (op.tipo.Equals("opcion") && haSeleccionadoOpcion == true) //Si es de tipo opción y ya se ha seleccionado dicha opción...
                    {
                        descripcion = op.descripcionOpcion; //...o bien pasa a tener la descripción resultante de la opción elegida...
                        ejeX = (panel1.Width * 40) / 100;
                    }
                    else
                    {
                        descripcion = op.descripcion; //... o se queda con la descripción normal.
                    }

                    Button opcion = new Button();
                    panel1.Controls.Add(opcion);
                    opcion.Location = new System.Drawing.Point(ejeX, ejeY); //ejeX es una variable ya que se irá sumando según se vayan creando botones.
                    opcion.Name = op.id + "";
                    opcion.Size = new System.Drawing.Size(120, 80);
                    opcion.TabIndex = 9;
                    opcion.Text = descripcion;
                    opcion.Font = new Font("Perpetua", 12);
                    opcion.Tag = op.id;
                    opcion.UseVisualStyleBackColor = true;
                    if (masDeUnaOpcion)
                    {
                        ejeX += 120;
                    }
                    else
                    {
                        ejeX = (panel1.Width * 40) / 100;
                    }
                    listaOpciones.Add(opcion);
                }
            }
        }
        
    }
}
