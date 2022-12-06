using ArcabiaLasHistoriasOcultas.Clases;
using Gremlin.Net.Structure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public class ControladorPartidas
    {
        public static List<Partida> getPartidas()
        {
            List<Partida> listaPartidas = new List<Partida>();
            string ruta = @"..\..\Archivos\Partidas\partidas.json";
            try
            {
                if (File.Exists(ruta))
                {
                    string JsonString = File.ReadAllText(ruta);
                    listaPartidas = JsonSerializer.Deserialize<List<Partida>>(JsonString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo json " + e.Message);
            }
            return listaPartidas;
        }

        public static bool guardarPartidas(List<Partida> listaPartidas)
        {
            bool guardar = false;
            string ruta = @"..\..\Archivos\Partidas\partidas.json";
            try
            {
                if (File.Exists(ruta))
                {
                    string JsonString = JsonSerializer.Serialize(listaPartidas);
                    File.WriteAllText(ruta, JsonString);
                    guardar = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo json " + e.Message);
            }
            return guardar;
        }

        public static string crearDirectorio(int numeroPartida)
        {
            DirectoryInfo di = Directory.CreateDirectory(@"..\..\Archivos\Partidas\"+numeroPartida);
            return di.FullName;
        }
    }

    
}
