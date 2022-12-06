
using ArcabiaLasHistoriasOcultas.Clases;
using Markdig;
using Markdig.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public class ControladorActos
    {
        public static List<Acto> getListaActos(string ruta)
        {
            List<Acto> listaActos = new List<Acto>();
            ruta += @"\instrucciones.json"; //Siempre se añade el nombre del archivo a la ruta recibida,
                                            //puesto que puede ser una ruta creada dinámicamente por el programa donde se albergan los cambios
            try
            {
                if (File.Exists(ruta)) //Si el archivo existe
                {
                    var contenido = File.ReadAllBytes(ruta);
                    listaActos = JsonSerializer.Deserialize<List<Acto>>(contenido);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo json " + e.Message);
            }
            return listaActos;
        }

        public static bool guardarListaActos(List<Acto> listaActos, string ruta)
        {
            bool guardar = false;
            

            try
            {
                if (!File.Exists(ruta))
                {
                    ruta += @"\instrucciones.json";
                }
                var contenido = JsonSerializer.SerializeToUtf8Bytes(listaActos);
                File.WriteAllBytes(ruta, contenido);
                guardar = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo json " + e.Message);
            }
            return guardar;
        }
        public static string getTexto(string ruta)
        {
            string texto = ""; 
            if (!ruta.Equals("[FIN]"))
            {
                texto = File.ReadAllText(ruta);
            }
            return texto;
        }
    }
}
