using System.Collections.Generic;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Acto
    {
        public int id { get; set; }
        public string ruta { get; set; }
        public List<Opcion> opciones { get; set; }
        public string contenidoHTMLActo { get; set; }

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
