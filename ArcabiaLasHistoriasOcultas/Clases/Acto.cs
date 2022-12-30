using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Acto
    {
        public int id { get; set; } //Id del acto
        public string ruta { get; set; } //Ruta del html que corresponde a dicho acto
        public List<Opcion> opciones { get; set; } //Lista de opciones de cada acto

        public Acto()
        {
        }

        public Acto(int id, string ruta, List<Opcion> opciones)
        {
            this.id = id;
            this.ruta = ruta;
            this.opciones = opciones;
        }
    }
}
