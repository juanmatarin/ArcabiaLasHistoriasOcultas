using Cassandra;
using System;
using System.Configuration;

namespace ArcabiaLasHistoriasOcultas.Clases.DAO
{
    public class DAOBaseDeDatos
    {

        public bool comprobarConexion()
        {
            bool exito;
           
            try
            {
                Cluster cluster = Cluster.Builder().AddContactPoint(ConfigurationManager.ConnectionStrings["IpEquipo"].ConnectionString).Build();
                Session session = (Session)cluster.Connect("arcabialho_keyspace");
                exito = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al conectarse a la base de datos " + e.Message);
                exito = false;
            }
            return exito;

        }
    }
}
