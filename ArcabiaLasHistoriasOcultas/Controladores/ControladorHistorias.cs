using ArcabiaLasHistoriasOcultas.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
            string html = "", nombreHistoria, rutaImagen = "", directorioHistoria = "", directorioActo = ""; //HTML Sería el contenido que se sacaría de la BBDD.
            int idHistoria;
            Historia historiaNueva;
            List<Historia> listaHistorias = getHistorias();

            idHistoria = listaHistorias.Count + 1;
            nombreHistoria = "Historia_" + idHistoria;
            //rutaImagen se saca de la BBDD
            historiaNueva = new Historia(idHistoria, nombreHistoria, rutaImagen);
            listaHistorias.Add(historiaNueva);

            directorioHistoria = ControladorIO.crearDirectorio(@"..\..\Archivos\Historias\Historia_", historiaNueva.id);
            foreach (Acto acto in listaActos)
            {
                directorioActo = ControladorIO.crearDirectorio(directorioHistoria + @"\Acto_",  (acto.id + 1)); //Crea cada directorio de cada acto.
                ControladorIO.escribirHTML(directorioActo, "acto", (acto.id + 1), html); //Llama al método para crear el archivo
                if (acto.opciones.Count != 0)
                {
                    foreach (Opcion opcion in acto.opciones) //Por cada opción dentro de el respectivo acto se hace lo mismo:
                    {
                        if (!opcion.tipo.Equals("acto"))
                        {
                            ControladorIO.escribirHTML(directorioActo, "opcion", (opcion.id + 1), html); //Método para crear el archivo.
                        }
                    }
                }
            }

            ControladorIO.escribirJSON(directorioHistoria, listaActos); //Crea el Json de las instrucciones.
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
    }
}
