using ArcabiaLasHistoriasOcultas.Clases.DAO;
using Cassandra;
using System;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public  class ControladorBaseDeDatos
    {
        static DAOBaseDeDatos daobd = new DAOBaseDeDatos();
        public static bool comprobarConexion()
        {
            bool conectado = daobd.comprobarConexion();
            if (conectado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
