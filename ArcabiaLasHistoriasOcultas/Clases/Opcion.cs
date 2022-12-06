using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Opcion
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string ruta { get; set; }
        public string tipo { get; set; }
        public string descripcionOpcion { get; set; }
        public int siguienteActo { get; set; }
        public bool decisionCondicionante { get; set; }
        public bool decisionElegida { get; set; }
        public int decisionAConsiderarActo { get; set; }
        public int decisionAConsiderarOpcion { get; set; }
        public int opcionAMostrar { get; set; }

        public Opcion()
        {
        }

        public Opcion(int id, string descripcion, string ruta, string tipo, string descripcionOpcion, 
            int siguienteActo, bool decisionElegida, int decisionAConsiderarActo, int decisionAConsiderarOpcion, int opcionAMostrar)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.ruta = ruta;
            this.tipo = tipo;
            this.descripcionOpcion = descripcionOpcion;
            this.siguienteActo = siguienteActo;
            this.decisionElegida = decisionElegida;
            this.decisionAConsiderarActo = decisionAConsiderarActo;
            this.decisionAConsiderarOpcion = decisionAConsiderarOpcion;
            this.opcionAMostrar = opcionAMostrar;
        }
    }
}
