using System;

namespace ArcabiaLasHistoriasOcultas.Clases.DTO
{
    public class DTOPartida
    {
        public int id { get; set; }
        public string historia { get; set; }
        public int numeroActo { get; set; }
        public string rutaInstrucciones { get; set; }
        public DateTime fechaGuardado { get; set; }
        public int idUsuario { get; set; }
        public string nombreCompleto { get; set; }

        public DTOPartida(int id, string historia, int numeroActo, string rutaInstrucciones, int idUsuario)
        {
            this.id = id;
            this.historia = historia;
            this.numeroActo = numeroActo;
            this.rutaInstrucciones = rutaInstrucciones;
            fechaGuardado = DateTime.Now;
            this.idUsuario = idUsuario;
            nombreCompleto = "Historia " + historia[historia.Length - 1] + ", Acto " + (numeroActo + 1) + ", " + fechaGuardado.ToString();
        }

    }
}
