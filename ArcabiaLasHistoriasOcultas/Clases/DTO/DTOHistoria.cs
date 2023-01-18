namespace ArcabiaLasHistoriasOcultas.Clases.DTO
{
    public class DTOHistoria
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string rutaImagen { get; set; }

        public DTOHistoria(int id, string nombre, string rutaImagen)
        {
            this.id = id;
            this.nombre = nombre;
            this.rutaImagen = rutaImagen;
        }
    }
}
