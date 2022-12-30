using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Historia
    {
        public int id { get; set; } //Identificador de historia
        public string nombre { get; set; } //Nombre de la propia historia que se muestra en la selección.
        public string rutaImagen { get; set; } //Ruta de la imagen que se muestra en la selección
    }
}
