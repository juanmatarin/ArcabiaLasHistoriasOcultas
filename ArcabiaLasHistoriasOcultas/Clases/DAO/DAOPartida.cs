using ArcabiaLasHistoriasOcultas.Clases.DTO;
using Cassandra;
using System;

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
            Cluster cluster = Cluster.Builder().AddContactPoint("192.168.1.131").Build();
            session = (Session)cluster.Connect("arcabia_keyspace");
        }
        public bool insert(DTOPartida dtopartida)
        {
            bool insertada;
            try
            {
                
                string fechaParseada = dtopartida.fechaGuardado.ToString();

                string insert = "INSERT INTO Partida(id, historia, numeroActo, rutaInstrucciones,fechaGuardado) VALUES (" + dtopartida.id + ",'"
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

        public void update()
        {
            try
            {
                /*session.Execute("update Partida  from Usuario set historia = '" + historia + "',set apellidos = '" +
                numeroActo + "', set nombre_usuario = '" + nombre_usuario + "', set correo = ';");*/
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al actualizar " + e.Message);
            }
        }
    }
}
