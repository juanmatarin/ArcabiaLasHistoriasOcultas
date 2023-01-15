using ArcabiaLasHistoriasOcultas.Clases;
using ArcabiaLasHistoriasOcultas.Clases.DAO;
using ArcabiaLasHistoriasOcultas.Clases.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public class ControladorOpciones
    {
        static DAOOpcion daoOpcion = new DAOOpcion();

        public string getContenidoHtmlBD(int id)
        {
            var consulta = daoOpcion.getContenidoHTML(id);
            string html = consulta.ToString();
            foreach (var info in consulta)
            {
                html = info.getValue<string>("contenidohtml");
                break;
            }
            return html;
        }
        public static List<Opcion> getOpcionesBD(int idActo)
        {
            
            List<DTOOpcion> listaOpcionesBD = daoOpcion.select(idActo);
            listaOpcionesBD.Sort((x, y) => x.id.CompareTo(y.id));
            List<Opcion> listaOpciones = new List<Opcion>();
            foreach (DTOOpcion dtoOpcion in listaOpcionesBD)
            {
                int id = dtoOpcion.id;
                int idActoConsulta = dtoOpcion.idActo;
                string ruta = dtoOpcion.ruta;
                string descripcion = dtoOpcion.descripcion;
                string tipo = dtoOpcion.tipo;
                string descripcionOpcion = dtoOpcion.descripcionOpcion;
                int siguienteActo =dtoOpcion.siguienteActo;
                bool decisionCondicionante = dtoOpcion.decisionCondicionante;
                bool decisionElegida = dtoOpcion.decisionElegida;
                int decisionAConsiderarActo = dtoOpcion.decisionAConsiderarActo;
                int decisionAConsiderarOpcion = dtoOpcion.decisionAConsiderarOpcion;
                int opcionAMostrar = dtoOpcion.opcionAMostrar;
                string contenidoHtml = dtoOpcion.contenidoHTML;


                //Creamos un objeto de opcion con estas variables cada vez que pasamos por el bucle, y lo metemos en la lista de opciones
                Opcion opcionAGuardar = new Opcion(id, idActoConsulta, ruta, descripcion, tipo, descripcionOpcion, siguienteActo, decisionCondicionante,
                    decisionElegida, decisionAConsiderarActo, decisionAConsiderarOpcion,opcionAMostrar, contenidoHtml);
                listaOpciones.Add(opcionAGuardar);

            }
            return listaOpciones;
        }
    }
}
