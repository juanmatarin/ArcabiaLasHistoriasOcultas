using Cassandra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Clases.DAO
{
    public class DAOBaseDeDatos
    {
        public DAOBaseDeDatos()
        {
            
        }
        public bool comprobarConexion()
        {
            bool exito = false;
           
            try
            {
                Cluster cluster = Cluster.Builder().AddContactPoint("192.168.1.131").Build();
                Session session = (Session)cluster.Connect("arcabia_keyspace");
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
