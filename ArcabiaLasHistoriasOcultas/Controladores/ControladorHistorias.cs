using ArcabiaLasHistoriasOcultas.Clases;
using ArcabiaLasHistoriasOcultas.Clases.DAO;
using ArcabiaLasHistoriasOcultas.Clases.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

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

        public static bool addHistoriaNuevaLocal()
        {
            daoHistoria = new DAOHistoria();
            bool exito = false;
            string html = "", nombreHistoria, rutaImagen = ""; //HTML Sería el contenido que se sacaría de la BBDD.
            int idHistoria;
            Historia historiaNueva;
            List<Historia> listaHistorias = getHistorias();
            DirectoryInfo directorioHistoria, directorioActo;

            //Hay que coger la historia/s de la base de datos
            List<Historia> listaHistoriasBD = getHistoriasBD();
            
            foreach (Historia historia in listaHistoriasBD)
            {
                
                idHistoria = listaHistorias.Count + 1;//La historia recibida de la BD puede tener un id diferente al que hay que usar para crear la historia en local,
                //Por ejemplo, en la BD la historia que recibimos puede tener id=1, pero si en local ya existen 3 partidas, esta historia pasará a tener id=4, por lo que se actualiza en la bd
                nombreHistoria = "Historia_" + idHistoria;//Lo mismo ocurre con su nombre
                
                rutaImagen = historia.rutaImagen;
                historiaNueva = new Historia(idHistoria, nombreHistoria, rutaImagen);

                directorioHistoria = Directory.CreateDirectory(@"..\..\Archivos\Historias\Historia_" + historiaNueva.id); //Crea el directorio de la historia.

                List<Acto> listaActosBD = ControladorActos.getActosBD(historia.id); 
                foreach (Acto acto in listaActosBD)
                {
                    //int idHistoria = acto.idHistoria;
                    int idActo = acto.id;
                    string htmlActo = acto.contenidoHTML;
                    directorioActo = Directory.CreateDirectory(directorioHistoria.FullName + @"\Acto_" + acto.id); //Crea cada directorio de cada acto.
                    crearYEscribirHTML(directorioActo.FullName, "acto", (acto.id ), htmlActo); //Llama al método para crear el archivo
                    
                    
                    if (acto.opciones.Count != 0)
                    {
                        
                        foreach (Opcion opcion in acto.opciones) //Por cada opción dentro del respectivo acto se hace lo mismo:
                        {
                            if (!opcion.tipo.Equals("acto"))
                            {
                                string htmlOpcion = opcion.contenidoHTML;
                                crearYEscribirHTML(directorioActo.FullName, opcion.tipo, (opcion.id + 1), htmlOpcion); //Método para crear el archivo.
                            }
                            
                        }
                    }
                }

                listaHistorias.Add(historiaNueva);
            }
           
/*
            crearYEscribirJSON(directorioHistoria.FullName, listaActos); //Crea el Json de las instrucciones.
            guardarHistorias(listaHistorias);
*/
            
            return exito;
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
    }
}
