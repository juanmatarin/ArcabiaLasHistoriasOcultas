using ArcabiaLasHistoriasOcultas.Clases;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public class ControladorIO
    {
        public static string crearDirectorio(string ruta, int numero)
        {
            DirectoryInfo di = Directory.CreateDirectory(ruta + numero);
            return di.FullName;
        }
        public static void escribirJSON(string ruta, List<Acto> listaActos)
        {
            string rutaCompleta = ruta + @"\instrucciones.json", json;
            json = JsonSerializer.Serialize(listaActos);
            File.WriteAllBytes(rutaCompleta, Encoding.UTF8.GetBytes(json));
        }

        public static void escribirHTML(string ruta, string tipo, int numero, string contenido)
        {
            ruta += @"\" + tipo + numero + ".html";
            File.WriteAllBytes(ruta, Encoding.UTF8.GetBytes(contenido));
        }

        public static bool borrarPartidaLocal(int id)
        {
            bool exito = false;
            string ruta;

            ruta = @"..\..\Archivos\Partidas\";

            if (File.Exists(ruta + "Partida_" + id + @"\instrucciones.json"))
            {
                File.Delete(ruta + "Partida_" + id + @"\instrucciones.json");
                Directory.Delete(ruta + "Partida_" + id);
            }
            return exito;
        }
    }
}
