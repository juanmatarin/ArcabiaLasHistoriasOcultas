using ArcabiaLasHistoriasOcultas.Clases.DTO;
using Cassandra;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Clases.DAO
{
    public class DAOOpcion
    {
        Session session = null;
        public DAOOpcion()
        {
            conexion();
        }
        public void conexion()
        {
            Cluster cluster = Cluster.Builder().AddContactPoint(ConfigurationManager.ConnectionStrings["IpEquipo"].ConnectionString).Build();
            session = (Session)cluster.Connect("arcabia_keyspace");
        }
        public dynamic getContenidoHTML(int idActo)
        {
            var consulta = session.Execute("SELECT contenidohtml FROM Opcion WHERE idActo = " + idActo + ";");
            return consulta;
        }
        public List<DTOOpcion> select(int idActo)
        {
            var consulta = session.Execute("SELECT * FROM Opcion where idActo = " + idActo + " ALLOW FILTERING;");
            List<DTOOpcion> listaOpcionesBD = new List<DTOOpcion>();

            foreach (var opcion in consulta)
            {

                int id = opcion.GetValue<int>("id");
                int idActoConsulta = opcion.GetValue<int>("idacto");
                string descripcion = opcion.GetValue<string>("descripcion");
                string ruta = opcion.GetValue<string>("ruta");
                string tipo = opcion.GetValue<string>("tipo");
                string descripcionOpcion = opcion.GetValue<string>("descripcionopcion");
                int siguienteActo = opcion.GetValue<int>("siguienteacto");
                bool decisionCondicionante = opcion.GetValue<bool>("decisioncondicionante");
                bool decisionElegida = opcion.GetValue<bool>("decisionelegida");
                int decisionAConsiderarActo = opcion.GetValue<int>("decisionaconsideraracto");
                int decisionAConsiderarOpcion = opcion.GetValue<int>("decisionaconsideraropcion");
                int opcionAMostrar = opcion.GetValue<int>("opcionamostrar");
                string contenidoHtml = opcion.GetValue<string>("contenidohtml");
                //Para decodificar el contenido html recibido de la base de datos
               // string contenidoHtmlDecodificado = System.Convert.FromBase64String(contenidoHtml).ToString();

                //Creamos un objeto de opcion con estas variables cada vez que pasamos por el bucle, y lo metemos en la lista de opciones
                DTOOpcion opcionAGuardar = new DTOOpcion(id, idActoConsulta, descripcion, ruta, tipo, descripcionOpcion, siguienteActo, decisionCondicionante,
                    decisionElegida, decisionAConsiderarActo, decisionAConsiderarOpcion, opcionAMostrar, contenidoHtml);
                listaOpcionesBD.Add(opcionAGuardar);

            }
            return listaOpcionesBD;
        }
    }
}
