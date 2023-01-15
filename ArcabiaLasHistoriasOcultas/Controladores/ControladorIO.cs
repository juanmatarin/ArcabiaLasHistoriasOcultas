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
    public class ControladorIO
    {
        public static string crearDirectorio(string ruta, int numero)
        {
            DirectoryInfo di = Directory.CreateDirectory(ruta + numero);
            return di.FullName;
        }
        public static void crearYEscribirJSON(string ruta, List<Acto> listaActos)
        {
            string rutaCompleta = ruta + @"\instrucciones.json", json;
            json = JsonSerializer.Serialize(listaActos);
            File.WriteAllBytes(rutaCompleta, Encoding.ASCII.GetBytes(json));
        }

        public static void escribirHTML(string ruta, string tipo, int numero, string contenido)
        {
            ruta += @"\" + tipo + numero + ".html";
            File.WriteAllBytes(ruta, Encoding.ASCII.GetBytes(contenido));
        }
    }
}
