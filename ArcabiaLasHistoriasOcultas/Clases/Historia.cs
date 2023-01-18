namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Historia
    {
        public int id { get; set; } //Identificador de Historia
        public string nombre { get; set; } //Nombre de Historia. ej: Historia_1
        public string rutaImagen { get; set; } //Ruta de la imagen que vamos a usar para el icono de la historia

        public Historia(int id, string nombre, string rutaImagen)
        {
            this.id = id;
            this.nombre = nombre;
            this.rutaImagen = rutaImagen;
        }
    }


}
