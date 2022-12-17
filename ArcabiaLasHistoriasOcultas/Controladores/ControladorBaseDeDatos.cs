using ArcabiaLasHistoriasOcultas.Clases;
using Cassandra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public  class ControladorBaseDeDatos
    {
        public static bool comprobarConexión()
        {
            bool exito = false;
            try
            {
                var cluster = Cluster.Builder().AddContactPoint("192.168.1.128").Build();
                var session = cluster.Connect("arcabialho_keyspace");
                exito = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la base de datos: " + e.Message);
            }
            return exito;
        }
    }
}
