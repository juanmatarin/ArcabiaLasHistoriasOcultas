using System.Collections.Generic;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Acto
    {
        public int id { get; set; } //Id de Acto
        public string ruta { get; set; } //ruta usada para crear la ruta en el JSON
        public List<Opcion> opciones { get; set; } //Lista de opciones que se guardarán en el acto

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
