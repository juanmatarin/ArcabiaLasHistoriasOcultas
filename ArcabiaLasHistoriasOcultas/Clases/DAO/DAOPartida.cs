using ArcabiaLasHistoriasOcultas.Clases.DTO;
using Cassandra;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace ArcabiaLasHistoriasOcultas.Clases.DAO
{
    public class DAOPartida
    {
        Session session = null;
        public DAOPartida() 
        {
            conexion();
        }
        public void conexion()
        {
            Cluster cluster = Cluster.Builder().AddContactPoint(ConfigurationManager.ConnectionStrings["IpEquipo"].ConnectionString).Build();
            session = (Session)cluster.Connect("arcabia_keyspace");
        }
        public bool insert(DTOPartida dtopartida)
        {
            bool insertada;
            try
            {
                
                string fechaParseada = dtopartida.fechaGuardado.ToString();

                string insert = "INSERT INTO Partida(id, idUsuario, historia, numeroActo, rutaInstrucciones,fechaGuardado) VALUES (" + dtopartida.id + ", " + dtopartida.idUsuario +  ",'"
                    + dtopartida.historia + "', " + dtopartida.numeroActo + ", '" + dtopartida.rutaInstrucciones + "', '" + fechaParseada + "');";
                session.Execute(insert);
                insertada = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la inserción de datos" + e.Message);
                insertada = false;
            }
            return insertada;
        }
        public List<DTOPartida> select()
        {
            var consulta = session.Execute("SELECT * FROM Partida;");
            List<DTOPartida> listaPartidasBD = new List<DTOPartida>();
            foreach (var partida in consulta)
            {
                int id = partida.GetValue<int>("id");
                string historia = partida.GetValue<string>("historia");
                int numeroActo = partida.GetValue<int>("numeroacto");
                string rutaIntrucciones = partida.GetValue<string>("rutainstrucciones");
                int idUsuario = partida.GetValue<int>("idusuario");

                DTOPartida partidaAGuardar = new DTOPartida(id, historia, numeroActo, rutaIntrucciones, idUsuario);
                listaPartidasBD.Add(partidaAGuardar);
            }
            return listaPartidasBD;
        }
        public dynamic getIds()
        {
            var consulta = session.Execute("SELECT id FROM Partida;");
            return consulta;
        }
        
        public void update()
        {
            try
            {
               /* session.Execute("update Partida  from Usuario set historia = '" + historia + "',set apellidos = '" +
                numeroActo + "', set nombre_usuario = '" + nombre_usuario + "', set correo = ';");*/
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al actualizar " + e.Message);
            }
        }
        public bool delete(int id)//Método para eliminar una partida cuyo id recibe por parámetro
        {
            bool delete;
            try
            {
                session.Execute("DELETE FROM Partida WHERE id = " + id);
                delete = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al eliminar la partida" + e.Message);
                delete = false;
            }
            return delete;
        }

    }
}
