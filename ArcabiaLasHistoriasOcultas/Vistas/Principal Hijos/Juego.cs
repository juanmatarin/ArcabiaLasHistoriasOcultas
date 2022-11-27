using ArcabiaLasHistoriasOcultas.Clases;
using ArcabiaLasHistoriasOcultas.Controladores;
using Gremlin.Net.Process.Traversal;
using Markdig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Vistas
{
    public partial class Juego : Form
    {
        Principal padre;
        List<Button> listaOpciones;
        List<Acto> listaActos;
        int ejeY, numeroActo;
        string historia;
        bool haSeleccionadoOpcion;
        public Juego(Principal padre, string historia, int numeroActo)
        {
            InitializeComponent();
            this.padre = padre;
            this.ejeY = 27;
            this.historia = historia;
            this.numeroActo = numeroActo;
        }
        private void Juego_Load(object sender, EventArgs e)
        {
            listaActos = ControladorActos.getListaActos(historia);
            listaOpciones = new List<Button>();
            numeroActo = 0;
            haSeleccionadoOpcion = false;
            cargarActo();
        }

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

        private void accionBoton(object sender, EventArgs e, Opcion op)
        {
            
            if (op.siguienteActo != 0) //Si el siguienteActo (variable de op) es 0, significa que la historia se ha acabado. 
            {
                if (op.tipo.Equals("opcion") && haSeleccionadoOpcion == false) //Si la opcion es una entre varias (pudiendo desenvocar en distintos resultados)
                                                                               //y es la primera vez que se selecciona
                                                                               //(ya que, en el json debe de acceder a su propia ruta para mostrar el texto) accede al condicionante.
                {
                    haSeleccionadoOpcion = true; //Se marca a true para indicar que se ha seleccionado una opcion.
                    cargarOpcion(op); //Se carga un método especifico para las opciones.
                }
                else
                {
                    haSeleccionadoOpcion = false; //Se marca false de nuevo ya que se va a pasar a otro acto
                    numeroActo = op.siguienteActo; //La variable que marca el index pasa a ser el siguiente acto que marca la opcion
                    cargarActo(); //Se carga el acto
                }
                
            }
            else //Si no se cumplen las opciones, significa que la historia ha acabado y vuelve al menú principal.
            {
                MessageBox.Show("Has terminado la Historia.");
                Bienvenida bienvenida = new Bienvenida(padre);
                bienvenida.MdiParent = padre;
                bienvenida.Show();
                this.Close();
            }
        }

        private void crearOpcíones(List<Opcion> opciones)
        {
            string descripcion;
            foreach (Opcion op in opciones) //Se crea un botón por cada opción de la lista de opciones.
            {
                if (op.tipo.Equals("opcion") && haSeleccionadoOpcion == true) //Si es de tipo opción y ya se ha seleccionado dicha opción...
                {
                    descripcion = op.descripcionOpcion; //...o bien pasa a tener la descripción resultante de la opción elegida...
                }
                else
                {
                    descripcion = op.descripcion; //... o se queda con la descripción normal.
                }

                Button opcion = new Button();
                panel1.Controls.Add(opcion);
                opcion.Location = new System.Drawing.Point(167, ejeY); //ejeY es una variable ya que se irá sumando según se vayan creando botones.
                opcion.Name = "opcion" + op.id;
                opcion.Size = new System.Drawing.Size(103, 34);
                opcion.TabIndex = 9;
                opcion.Text = descripcion;
                opcion.Tag = op.id;
                opcion.UseVisualStyleBackColor = true;
                ejeY += 40;
                listaOpciones.Add(opcion);
            }
        }
        private void borrarOpciones()
        {
            foreach (Button btn in listaOpciones) //Se borran todos los botones.
            {
                panel1.Controls.Remove(btn);
            }
            ejeY = 27; //Se pone el ejeY a la posición original.
        }

        private void salirBTN_Click(object sender, EventArgs e)
        {
            Bienvenida bienvenida = new Bienvenida(padre);
            bienvenida.MdiParent = padre;
            bienvenida.Show();
            this.Close();
        }
    }
}
