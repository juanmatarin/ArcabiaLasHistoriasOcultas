using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Opcion
    {
        public int id { get; set; } //Identificador de la opción
        public string descripcion { get; set; } //Descripcion de la propia opción
        public string ruta { get; set; } //Ruta del HTML correspondiente
        public string tipo { get; set; } //Indica si el paso siguiente es un acto o una opción
        public string descripcionOpcion { get; set; } //Descripción de la opción resultante
        public int siguienteActo { get; set; } //Indica el siguiente acto al que debe de continuar
        public bool decisionCondicionante { get; set; } //Indica si es una decisión que va a condicionar a otra en un futuro
        public bool decisionElegida { get; set; } //Indica si se ha elegido esta opción a la hora de jugar
        public int decisionAConsiderarActo { get; set; } //Indica en que acto se debe de recordar si se ha marcado o no esta opción.
        public int decisionAConsiderarOpcion { get; set; } //Indica la opción dentro de la lista de opciones del acto que es condicionada por esta opción
        public int opcionAMostrar { get; set; } //Indica que HTML debe de mostrar si esta opción es condicionada por una condición anterior.

        public Opcion()
        {
        }

        public Opcion(int id, string descripcion, string ruta, string tipo, string descripcionOpcion, 
            int siguienteActo, bool decisionElegida, int decisionAConsiderarActo, int decisionAConsiderarOpcion, int opcionAMostrar)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.ruta = ruta;
            this.tipo = tipo;
            this.descripcionOpcion = descripcionOpcion;
            this.siguienteActo = siguienteActo;
            this.decisionElegida = decisionElegida;
            this.decisionAConsiderarActo = decisionAConsiderarActo;
            this.decisionAConsiderarOpcion = decisionAConsiderarOpcion;
            this.opcionAMostrar = opcionAMostrar;
        }
    }
}
