using ArcabiaLasHistoriasOcultas.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public class ControladorHistorias
    {
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

        public static bool addHistoriaNuevaLocal(List<Acto> listaActos)
        {
            bool exito = false;
            string html = "", directorioCompleto, nombreHistoria, rutaImagen = ""; //HTML Sería el contenido que se sacaría de la BBDD.
            int index = 0, idHistoria;
            Historia historiaNueva;
            List<Historia> listaHistorias = getHistorias();
            DirectoryInfo directorioHistoria, directorioActo;

            idHistoria = listaHistorias.Count + 1;
            nombreHistoria = "Historia_" + idHistoria;
            //rutaImagen se saca de la BBDD
            historiaNueva = new Historia(idHistoria, nombreHistoria, rutaImagen);
            listaHistorias.Add(historiaNueva);

            directorioHistoria = Directory.CreateDirectory(@"..\..\Archivos\Historias\Historia_" + historiaNueva.id); //Crea el directorio de la historia.
            foreach (Acto acto in listaActos)
            {
                directorioActo = Directory.CreateDirectory(directorioHistoria.FullName + @"\Acto_" + (acto.id + 1)); //Crea cada directorio de cada acto.
                crearYEscribirHTML(directorioActo.FullName, "acto", (acto.id + 1), html); //Llama al método para crear el archivo
                if (acto.opciones.Count != 0)
                {
                    foreach (Opcion opcion in listaActos[index].opciones) //Por cada opción dentro de el respectivo acto se hace lo mismo:
                    {
                        crearYEscribirHTML(directorioActo.FullName, "opcion", (opcion.id + 1), html); //Método para crear el archivo.
                    }
                }
            }

            crearYEscribirJSON(directorioHistoria.FullName, listaActos); //Crea el Json de las instrucciones.
            guardarHistorias(listaHistorias);
            
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
            File.Create(ruta + "acto" + numero + ".html");
            File.WriteAllText(ruta, contenido);
        }
    }
}
