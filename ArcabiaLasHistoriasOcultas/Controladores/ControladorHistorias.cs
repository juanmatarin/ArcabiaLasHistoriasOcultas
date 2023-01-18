using ArcabiaLasHistoriasOcultas.Clases;
using ArcabiaLasHistoriasOcultas.Clases.DAO;
using ArcabiaLasHistoriasOcultas.Clases.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public class ControladorHistorias
    {
        static DAOHistoria daoHistoria;

        public static List<Historia> getHistorias()
        {
            List<Historia> listaHistorias = new List<Historia>();
            string ruta = @"..\..\Archivos\Historias\historias.json";
            try
            {
                if (File.Exists(ruta))
                {
                    var contenido = File.ReadAllBytes(ruta);
                    listaHistorias = JsonSerializer.Deserialize<List<Historia>>(contenido);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo json " + e.Message);
            }
            return listaHistorias;
        }

        public static void addHistoriaNuevaLocal()
        {
            daoHistoria = new DAOHistoria();

            //Declaramos las variables que vayamos a usar
            string html = "", nombreHistoria, rutaImagen = "", directorioHistoria = "", directorioActo = ""; //HTML Sería el contenido que se sacaría de la BBDD.
            int idHistoria;
            Historia historiaNueva;
            List<Historia> listaHistorias = getHistorias(); //Recibimos la historia/s en local
            List<Historia> listaHistoriasBD = getHistoriasBD(); //Recibimos la historia/s de la base de datos

            //Declaramos las listas de actos que vamos a usar
            List<DTOActo> listaActosBD = null;
            List<Acto> actosJson = null;
            int contadorHistoriasNuevas = 0;

            foreach (Historia historia in listaHistoriasBD)
            {
                if (comprobarHistoriaDescargada(listaHistorias, historia.id) == false)
                {
                    idHistoria = listaHistorias.Count + 1;//La historia recibida de la BD puede tener un id diferente al que hay que usar para crear la historia en local,
                                                          //Por ejemplo, en la BD la historia que recibimos puede tener id=1, pero si en local ya existen 3 partidas, esta historia pasará a tener id=4, por lo que se actualiza en la bd
                    nombreHistoria = "Historia_" + idHistoria;//Lo mismo ocurre con su nombre
                    rutaImagen = historia.rutaImagen;

                    historiaNueva = new Historia(idHistoria, nombreHistoria, rutaImagen);//Creamos una historia nueva con los datos de la historia que está recorriendo el foreach

                    directorioHistoria = ControladorIO.crearDirectorio(@"..\..\Archivos\Historias\Historia_", historiaNueva.id); //Crea el directorio de la historia.

                    listaActosBD = ControladorActos.getActosBD(historia.id);//Recibimos los actos que tengan este id historia de la base de datos
                    actosJson = new List<Acto>();//Lista de actos que vamos a usar para crear el json

                    foreach (DTOActo dtoacto in listaActosBD)//Recorremos la lista de actos de la base de dato
                    {

                        directorioActo = ControladorIO.crearDirectorio(directorioHistoria + @"\Acto_", (dtoacto.id + 1));//Crea un directorio de cada acto.
                        ControladorIO.escribirHTML(directorioActo, "acto", (dtoacto.id + 1), dtoacto.contenidoHTML); //Llama al método para crear el archivo

                        List<Opcion> opcionesBD = ControladorOpciones.getOpcionesBD(dtoacto.id);//Cogemos las opciones que tenga este idActo de la base de datos
                        List<Opcion> opcionesJSON = new List<Opcion>();//Esta lista de opciones será la que vamos a usar para escribir el json

                        string rutaActoJson = "..\\..\\Archivos\\Historias\\" + nombreHistoria + @"\Acto_" + (dtoacto.id + 1) + @"\acto" + (dtoacto.id + 1) + ".html";//Creamos ka
                        Acto actoJson = null;
                        Opcion opcionJson = null;
                        int contadorOpcionHTML = 1; int contadorOpcionJSON = 0;
                        string htmlOpcion;

                        foreach (Opcion opcion in opcionesBD) //Recorremos la lista de opciones que hemos declarado antes
                        {
                            //Si la opción es tipo opción o tipo decisión, se crea su html
                            if (opcion.tipo.Equals("opcion"))
                            {
                                htmlOpcion = ControladorOpciones.cargarHtml(opcion.id);
                                ControladorIO.escribirHTML(directorioActo, "opcion", contadorOpcionHTML, htmlOpcion); //Método para crear el archivo.
                                opcionJson = new Opcion(contadorOpcionJSON, opcion.descripcion, opcion.ruta, opcion.tipo, opcion.descripcionOpcion,
                                opcion.siguienteActo, opcion.decisionCondicionante, opcion.decisionElegida, opcion.decisionAConsiderarActo, opcion.decisionAConsiderarOpcion, opcion.opcionAMostrar);
                                contadorOpcionJSON++; //Vamos actualizando el contador de las opciones que guardamos en el json
                            }
                            else if (opcion.tipo.Equals("acto"))
                            {
                                opcionJson = new Opcion(contadorOpcionJSON, opcion.descripcion, opcion.ruta, opcion.tipo, opcion.descripcionOpcion,
                                opcion.siguienteActo, opcion.decisionCondicionante, opcion.decisionElegida, opcion.decisionAConsiderarActo, opcion.decisionAConsiderarOpcion, opcion.opcionAMostrar);
                                contadorOpcionJSON++; //Vamos actualizando el contador de las opciones que guardamos en el json
                            }
                            else if (opcion.tipo.Equals("decision"))
                            {
                                htmlOpcion = ControladorOpciones.cargarHtml(opcion.id);
                                ControladorIO.escribirHTML(directorioActo, "opcion", contadorOpcionHTML, htmlOpcion);
                                opcionJson = new Opcion(contadorOpcionJSON, opcion.descripcion, opcion.ruta, opcion.tipo, opcion.descripcionOpcion,
                                opcion.siguienteActo, opcion.decisionCondicionante, opcion.decisionElegida, opcion.decisionAConsiderarActo, opcion.decisionAConsiderarOpcion, opcion.opcionAMostrar);
                                contadorOpcionJSON++;
                            }

                            opcionesJSON.Add(opcionJson);
                            actoJson = new Acto(dtoacto.id, rutaActoJson, opcionesJSON); //Creamos el acto que se va a guardar en lista que se usará para crear el json
                            contadorOpcionHTML++; //Actualizamos este contador, que se usa para crear el html de las opciones

                        }

                        actosJson.Add(actoJson); //Vamos añadiendo cada actoJson creado en la lista de actosJson
                    }

                    listaHistorias.Add(historiaNueva); //Añadimos esta historia a la lista de historias local
                    contadorHistoriasNuevas++;
                }
                if (contadorHistoriasNuevas > 0)
                {
                    ControladorIO.escribirJSON(directorioHistoria, actosJson); //Crea el Json de las instrucciones.
                    guardarHistorias(listaHistorias);
                }


            }
            if (contadorHistoriasNuevas == 0)
            {
                MessageBox.Show("Todas las partidas de la base de datos están descargadas");
            }

        }

        public static bool guardarHistorias(List<Historia> listaHistorias)
        {
            string ruta = @"..\..\Archivos\Historias\historias.json";
            bool exito = false;
            try
            {
                if (File.Exists(ruta))
                {
                    var contenido = JsonSerializer.SerializeToUtf8Bytes(listaHistorias);
                    File.WriteAllBytes(ruta, contenido);
                    exito = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo json " + e.Message);
            }
            return exito;
        }

        private static void crearYEscribirJSON(string ruta, List<Acto> listaActos)
        {
            string rutaCompleta = ruta + @"instrucciones.json", json;
            File.Create(rutaCompleta);
            json = JsonSerializer.Serialize(listaActos);
            File.WriteAllText(rutaCompleta, json);
        }

        private static void crearYEscribirHTML(string ruta, string tipo, int numero, string contenido)
        {
            ruta = ruta + @"\" + tipo + numero + ".html";
            File.WriteAllText(ruta, contenido);
        }

        public static List<Historia> getHistoriasBD()
        {
            daoHistoria = new DAOHistoria();
            List<DTOHistoria> listaHistoriaBD = daoHistoria.select();
            List<Historia> listaHistorias = new List<Historia>();

            foreach (DTOHistoria dtoHistoria in listaHistoriaBD)
            {
                int id = dtoHistoria.id;
                string nombre = dtoHistoria.nombre;
                string rutaImagen = dtoHistoria.rutaImagen;

                Historia historiaAGuardar = new Historia(id, nombre, rutaImagen);
                listaHistorias.Add(historiaAGuardar);

            }
            return listaHistorias;
        }
        public static int getIdHistoria()
        {
            daoHistoria = new DAOHistoria();
            var consulta = daoHistoria.getId();
            int id = 0;
            foreach (var ids in consulta)
            {
                id = ids.GetValue<int>("id");
                break;
            }
            return id;
        }

        public static bool comprobarHistoriaDescargada(List<Historia> listaHistoriasLocal, int idHistoriaBD)
        {
            bool partidaDescargada = false;

            foreach (Historia historiaLocal in listaHistoriasLocal)
            {
                if (historiaLocal.id == idHistoriaBD)
                {
                    partidaDescargada = true;
                }

            }
            return partidaDescargada;
        }
    }
}
