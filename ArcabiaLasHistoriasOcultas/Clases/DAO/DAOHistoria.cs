using ArcabiaLasHistoriasOcultas.Clases.DTO;
using Cassandra;
using System;

namespace ArcabiaLasHistoriasOcultas.Clases.DAO
{
    public  class DAOHistoria
    {
        Session session = null;
        public DAOHistoria()
        {
            conexion();
        }
        public void conexion()
        {
            Cluster cluster = Cluster.Builder().AddContactPoint("192.168.1.131").Build();
            session = (Session)cluster.Connect("arcabia_keyspace");
        }
        public void insert(DTOHistoria dtohistoria)
        {
            try
            {
                /*string insert = "INSERT INTO Historia(id, nombre, rutaImagen, contenidoJSON) VALUES (" + dtohistoria.id + ",'"
                    + dtohistoria.nombre + "', " + dtohistoria.rutaImagen + ", '" + dtohistoria.contenidoJSON + "');";
                session.Execute(insert); */
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la inserción de datos" + e.Message);
            }
        }

    }
}
