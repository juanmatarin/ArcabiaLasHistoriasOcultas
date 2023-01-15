using System;

namespace ArcabiaLasHistoriasOcultas.Clases.DTO
{
    public class DTOUsuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string nombreUsuario { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }
        public string nombreCompleto { get => nombre + " " + apellidos; }

        //Contructor para hacer el registro, el id se genera automáticamente
        public DTOUsuario(string nombre, string apellidos, string nombreUsuario, DateTime fechaNacimiento, string correo, string contraseña)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nombreUsuario = nombreUsuario;
            this.fechaNacimiento = fechaNacimiento;
            this.correo = correo;
            this.contraseña = contraseña;
        }

        public DTOUsuario(int id, string nombre, string apellidos, string nombreUsuario, string correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nombreUsuario = nombreUsuario;
            this.correo = correo;
        }
        public DTOUsuario() { }
    }
}
