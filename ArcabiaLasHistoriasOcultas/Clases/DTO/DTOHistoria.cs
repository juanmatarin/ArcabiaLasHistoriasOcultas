using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Clases.DTO
{
    public class DTOHistoria
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string rutaImagen { get; set; }
        public string contenidoJSON { get; set; }
        public DTOHistoria() 
        {

        }

    }
}
