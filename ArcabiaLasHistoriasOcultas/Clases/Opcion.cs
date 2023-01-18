namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Opcion
    {
        public int id { get; set; } //Identificador de la opción
        public string descripcion { get; set; } //Texto que se muestra en el propio botón para clarificar que acción se va a realizar.
        public string ruta { get; set; } //Igual que el campo del mismo nombre de Acto, indica dónde se encuentra el contenido del HTML.
        public string tipo { get; set; } //Indica el tipo de la opción a mostrar; si es de tipo Acto simplemente pasaría al acto siguiente, si por el contrario es de tipo Opción indica que va a haber más de una, pudiendo dar lugar a diversas ramificaciones.
        public string descripcionOpcion { get; set; } //Si es de tipo opción, este texto es el que se muestra en el botón del resultado de la misma clarificando cual va a ser la siguiente acción.
        public int siguienteActo { get; set; } //Indica el siguiente acto que se debe de cargar en el programa. Si este campo es igual a 0, significa que la historia ha finalizado.
        public bool decisionCondicionante { get; set; } //Indica si esta opción va a condicionar a una opción que se pueda elegir durante el transcurso de la historia. Es un booleano.
        public bool decisionElegida { get; set; } //Indica si el jugador, en tiempo de juego ha elegido esta opción o no. Este es uno de los campos que se van modificando y escribiendo en el JSON que se guarda en Partidas.
        public int decisionAConsiderarActo { get; set; } //En el caso de que esta opción no vaya a condicionar otra opción, esto indica si es distinto de 0 que acto debe de mirar el programa para saber por qué opción está condicionada
        public int decisionAConsiderarOpcion { get; set; } //Indica la opción dentro del acto considerado que va a condicionar al resultado de la opción actual; en el caso de que Decisión Elegida esté a true o false, el resultado de la opción actual cambia.
        public int opcionAMostrar { get; set; } //Indica en el caso de que la opción considerada haya sido elegida anteriormente, que opción dentro del mismo acto debe de mostrar a continuación.

        public Opcion()
        {
        }

        public Opcion(int id, string descripcion, string ruta, string tipo, string descripcionOpcion,
            int siguienteActo, bool decisionCondicionante, bool decisionElegida, int decisionAConsiderarActo, int decisionAConsiderarOpcion, int opcionAMostrar)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.ruta = ruta;
            this.tipo = tipo;
            this.descripcionOpcion = descripcionOpcion;
            this.siguienteActo = siguienteActo;
            this.decisionCondicionante = decisionCondicionante;
            this.decisionElegida = decisionElegida;
            this.decisionAConsiderarActo = decisionAConsiderarActo;
            this.decisionAConsiderarOpcion = decisionAConsiderarOpcion;
            this.opcionAMostrar = opcionAMostrar;
        }
    }

}
