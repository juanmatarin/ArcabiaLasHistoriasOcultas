using System;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Partida
    {
        public int id { get; set; } //Identificador de Partida.
        public string historia { get; set; } //Indica a que historia pertenece.
        public int numeroActo { get; set; } //Indica el número de acto en el que se ha guardado.
        public string rutaInstrucciones { get; set; } //Indica la ruta de instrucciones que la partida guardada debe de usar.
        public DateTime fechaGuardado { get; set; } //Guarda la fecha en la que se guardó la partida.
        public string nombreCompleto { get; set; } //Junta los campos en un campo de texto para ser mostrados.

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
            nombreCompleto = "Partida " + id + ", Historia " + historia[historia.Length - 1] + ", Acto " + (numeroActo + 1) + ", " + fechaGuardado.ToString();
        }
    }
}
