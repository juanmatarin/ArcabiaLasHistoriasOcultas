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
        public static List<Historia> getPartidas()
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
    }
}
