using System;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Usuario
    {
        public int id { get; set; }  //Identificador de Usuario
        public string nombre { get; set; } //Nombre de Usuario
        public string apellidos { get; set; } //Apellidos de Usuario
        public string nombreUsuario { get; set; } //Nombre de usuario de Usuario
        public DateTime fechaNacimiento { get; set; } //Fecha de nacimiento de Usuario
        public string correo { get; set; } //Correo de Usuario
        public string contraseña { get; set; } //Contraseña de Usuario
        public string nombreCompleto { get => nombre + " " + apellidos; } //Nombre completo: incluye el nombre y el apellido/s

        public Usuario()
        {
        }

        public Usuario(int ID, string nombre, string apellidos, string nombreUsuario, string correo)
        {
            this.id = ID;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nombreUsuario = nombreUsuario;
            this.correo = correo;
        }

        public override string ToString()
        {
            return nombreCompleto;
        }
    }

}
