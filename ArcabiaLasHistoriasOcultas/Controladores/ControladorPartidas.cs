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
        static DAOPartida daoPartida;
        public static List<Partida> getPartidas(bool haIniciadoSesion)
        {
            List<Partida> listaPartidas = new List<Partida>();
            string ruta = @"..\..\Archivos\Partidas\partidas.json";
            try
            {
                if (File.Exists(ruta))
                {
                    if (haIniciadoSesion)
                    {
                        foreach (Partida p in getPartidasBD())
                        {
                            listaPartidas.Add(p);
                        }
                    }
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
        public static void GuardarPartidaBD(DTOPartida dtopartida)
        {
            if (daoPartida.insert(dtopartida))
            {
                MessageBox.Show("Partida guardada en local y en la base de datos");
                Console.WriteLine("Partida registrada");
            }
        }
        
        public static List<Partida> getPartidasBD()
        {
            List<DTOPartida> listaPartidasBD = daoPartida.select();
            List<Partida> listaPartidas = new List<Partida>();
            
            foreach (DTOPartida dtoPartida in listaPartidasBD)
            {
                int id = dtoPartida.id;
                string historia = dtoPartida.historia;
                int numeroActo = dtoPartida.numeroActo;
                string rutaIntrucciones = dtoPartida.rutaInstrucciones;


                Partida partidaAGuardar = new Partida(id, historia, numeroActo, rutaIntrucciones);
                listaPartidas.Add(partidaAGuardar);
            }
            return listaPartidas;
        }
        public static void borrarPartidaBD(int id)
        {
            if (daoPartida.delete(id))
            {
                Console.WriteLine("Partida eliminada de la base de datos");
            }
        }
        public static bool comprobarIdPartida(int idRecibido)
        {
            var consulta = daoPartida.getIds();
            bool idExiste = false;
            foreach (var ids in consulta)
            {
                int id = ids.GetValue<int>("id");
                if(id == idRecibido)//Si el id recibido por parametro es igual al id que nos llega de la base de datos,
                                    //significa que existe una partida con ese id en la base de datos
                {
                    idExiste = true;
                    break;
                }
            }
            return idExiste;
        }
        public static bool comprobarIdUsuario(int idRecibido)
        {
            var consulta = daoPartida.getIds();
            bool idExiste = false;
            foreach (var ids in consulta)
            {
                int id = ids.GetValue<int>("id");
                if (id == idRecibido)//Si el id recibido por parametro es igual al id que nos llega de la base de datos,
                                     //significa que existe una partida con ese id en la base de datos
                {
                    idExiste = true;
                    break;
                }
            }
            return idExiste;
        }
    }

    
}
