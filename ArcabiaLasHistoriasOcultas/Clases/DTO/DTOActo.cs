using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Clases.DTO
{
    public class DTOActo
    {
        public int id { get; set; }
        public int idHistoria { get; set; }
        public string contenidoHTML { get; set; }

        public DTOActo(int id, int idHistoria, string contenidoHTML)
        {
            this.id = id;
            this.idHistoria = idHistoria;
            this.contenidoHTML = contenidoHTML;
        }
    }
}
