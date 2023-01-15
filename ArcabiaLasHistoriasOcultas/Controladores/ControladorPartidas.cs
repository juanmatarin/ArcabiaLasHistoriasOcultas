using ArcabiaLasHistoriasOcultas.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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
                    var contenido = File.ReadAllBytes(ruta);
                    listaPartidas = JsonSerializer.Deserialize<List<Partida>>(contenido);
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
                    var contenido = JsonSerializer.SerializeToUtf8Bytes(listaPartidas);
                    File.WriteAllBytes(ruta, contenido);
                    guardar = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo json " + e.Message);
            }
            return guardar;
        }
        public static bool borrarPartida(Partida partida)
        {
            bool exito = false;
            string ruta;

            ruta = @"..\..\Archivos\Partidas\";

            if (File.Exists(ruta + partida.id + @"\instrucciones.json"))
            {
                File.Delete(ruta + partida.id + @"\instrucciones.json");
                Directory.Delete(ruta + partida.id);
            }
            return exito;
        }
    }

    
}
