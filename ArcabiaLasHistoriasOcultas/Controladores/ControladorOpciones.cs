using ArcabiaLasHistoriasOcultas.Clases;
using ArcabiaLasHistoriasOcultas.Clases.DAO;
using ArcabiaLasHistoriasOcultas.Clases.DTO;
using System.Collections.Generic;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public class ControladorOpciones
    {
        static DAOOpcion daoOpcion;

        
        public static List<Opcion> getOpcionesBD(int idActo)
        {
            daoOpcion = new DAOOpcion();
            List<DTOOpcion> listaOpcionesBD = daoOpcion.select(idActo);
            listaOpcionesBD.Sort((x, y) => x.id.CompareTo(y.id));
            List<Opcion> listaOpciones = new List<Opcion>();
            foreach (DTOOpcion dtoOpcion in listaOpcionesBD)
            {
                int id = dtoOpcion.id;
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


                //Creamos un objeto de opcion con estas variables cada vez que pasamos por el bucle, y lo metemos en la lista de opciones
                Opcion opcionAGuardar = new Opcion(id, descripcion, ruta, tipo, descripcionOpcion, siguienteActo, decisionCondicionante,
                    decisionElegida, decisionAConsiderarActo, decisionAConsiderarOpcion,opcionAMostrar);
                listaOpciones.Add(opcionAGuardar);

            }
            return listaOpciones;
        }

        public static string cargarHtml(int id)
        {
            return daoOpcion.getContenidoHTML(id);

        }
    }
}
