using ArcabiaLasHistoriasOcultas.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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

        public static bool addHistoriaNuevaLocal(Historia historia, List<Acto> listaActos)
        {
            bool exito = false;
            string html = "", json = "", directorioCompleto; //HTML Y JSON Sería el contenido que se sacaría de la BBDD.
            int index = 0;
            List<Historia> listaHistorias = getHistorias();
            DirectoryInfo directorioHistoria, directorioActo;

            directorioHistoria = Directory.CreateDirectory(@"..\..\Archivos\Historias\Historia_" + historia.id); //Crea el directorio de la historia.
            crearYEscribirHTML(directorioHistoria.FullName, "acto", historia.id, html);
            foreach (Acto acto in listaActos)
            {
                directorioActo = Directory.CreateDirectory(directorioHistoria.FullName + @"\Acto_" + (acto.id + 1)); //Crea cada directorio de cada acto.
                crearYEscribirHTML(directorioActo.FullName, "acto", (acto.id + 1), html); //Llama al método para crear el archivo
                foreach (Opcion opcion in listaActos[index].opciones) //Por cada opción dentro de el respectivo acto se hace lo mismo:
                {
                    crearYEscribirHTML(directorioActo.FullName, "opcion", (opcion.id + 1), html); //Método para crear el archivo.
                }
                
            }

            crearYEscribirJSON(directorioHistoria.FullName, listaActos); //Crea el Json de las instrucciones.
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
