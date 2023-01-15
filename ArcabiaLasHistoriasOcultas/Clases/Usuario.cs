using System;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string nombreUsuario { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }
        public string nombreCompleto { get => nombre + " " + apellidos; }

        public Usuario()
        {
        }

        public Usuario(int ID, string nombre, string apellidos, string nombreUsuario, DateTime fechaNacimiento, string correo, string contraseña)
        {
            this.id = ID;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nombreUsuario = nombreUsuario;
            this.fechaNacimiento = fechaNacimiento;
            this.correo = correo;
            this.contraseña = contraseña;
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
    