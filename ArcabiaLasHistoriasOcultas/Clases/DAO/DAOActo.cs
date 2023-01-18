using ArcabiaLasHistoriasOcultas.Clases.DTO;
using Cassandra;
using System.Collections.Generic;
using System.Configuration;

namespace ArcabiaLasHistoriasOcultas.Clases.DAO
{
    public class DAOActo
    {
        Session session = null;
        public DAOActo()
        {
            conexion();
        }
        public void conexion()
        {
            Cluster cluster = Cluster.Builder().AddContactPoint(ConfigurationManager.ConnectionStrings["IpEquipo"].ConnectionString).Build();
            session = (Session)cluster.Connect("arcabialho_keyspace");
        }
        public List<DTOActo> select(int idHistoriaRecibido)
        {
            var consulta = session.Execute("SELECT * FROM Acto where idHistoria = " + idHistoriaRecibido + " ALLOW FILTERING;");
            List<DTOActo> listaActosBD = new List<DTOActo>();
            foreach (var acto in consulta)
            {
                int id = acto.GetValue<int>("id");
                int idHistoria = acto.GetValue<int>("idhistoria");
                string contenidoHtml = acto.GetValue<string>("contenidohtml");
                

                //Con las variables anteriores creamos un objeto Acto por cada vez que recorramos el bucle
                DTOActo actoAGuardar = new DTOActo(id, idHistoria, contenidoHtml);
                listaActosBD.Add(actoAGuardar);

            }
            return listaActosBD;
        }
    }
}
