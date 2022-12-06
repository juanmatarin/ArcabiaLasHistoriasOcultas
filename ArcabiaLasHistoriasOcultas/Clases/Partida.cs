using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Partida
    {
        public int id { get; set; }
        public string historia { get; set; }
        public int numeroActo { get; set; }
        public string rutaInstrucciones { get; set; }
        public DateTime fechaGuardado { get; set; }
        public string nombreCompleto { get; set; }

        public Partida()
        {
        }

        public Partida(int id, string historia, int numeroActo, string rutaInstrucciones)
        {
            this.id = id;
            this.historia = historia;
            this.numeroActo = numeroActo;
            this.rutaInstrucciones = rutaInstrucciones;
            fechaGuardado = DateTime.Now;
            nombreCompleto = "Historia " + historia[historia.Length - 1] + ", Acto " + (numeroActo + 1) + ", " + fechaGuardado.ToString();
        }
    }
}
