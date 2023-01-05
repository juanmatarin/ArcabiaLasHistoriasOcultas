using ArcabiaLasHistoriasOcultas.Clases;
using ArcabiaLasHistoriasOcultas.Clases.DAO;
using ArcabiaLasHistoriasOcultas.Clases.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public class ControladorPartidas
    {
        static DAOPartida daoPartida= new DAOPartida();
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

        public static string crearDirectorio(int numeroPartida)
        {
            DirectoryInfo di = Directory.CreateDirectory(@"..\..\Archivos\Partidas\"+numeroPartida);
            return di.FullName;
        }
        public static void GuardarPartidaBD(DTOPartida dtopartida)
        {
            if (daoPartida.insert(dtopartida))
            {
                MessageBox.Show("Partida guardada en la base de datos");
                Console.WriteLine("Partida registrada");
            }
        }
    }

    
}
