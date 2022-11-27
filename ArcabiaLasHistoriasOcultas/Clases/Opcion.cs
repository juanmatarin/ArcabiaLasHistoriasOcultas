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

        public Opcion()
        {
        }

        public Opcion(int id, string descripcion, string ruta, string tipo, string descripcionOpcion, int siguienteActo)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.ruta = ruta;
            this.tipo = tipo;
            this.descripcionOpcion = descripcionOpcion;
            this.siguienteActo = siguienteActo;
        }
    }
}
