namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Historia
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string rutaImagen { get; set; }

        public Historia(int id, string nombre, string rutaImagen)
        {
            this.id = id;
            this.nombre = nombre;
            this.rutaImagen = rutaImagen;
        }
    }


}
