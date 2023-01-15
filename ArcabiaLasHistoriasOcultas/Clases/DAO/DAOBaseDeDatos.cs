using Cassandra;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
