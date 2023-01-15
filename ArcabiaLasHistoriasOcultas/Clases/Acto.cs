using System.Collections.Generic;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Acto
    {
        public int id { get; set; }
        public int idHistoria { get; set; }
        public string ruta { get; set; }
        public List<Opcion> opciones { get; set; }
        public string contenidoHTML { get; set; }

        public Acto()
        {
        }

        public Acto(int id, string ruta, List<Opcion> opciones)
        {
            this.id = id;
            this.ruta = ruta;
            this.opciones = opciones;
        }
        public Acto(int id, int idHistoria, List<Opcion> opciones, string contenidoHTML)
        {
            this.id = id;
            this.id = idHistoria;
            this.opciones = opciones;
            this.contenidoHTML= contenidoHTML;
        }
    }
}
