using System;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string username { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public string nombre_completo { get => nombre + " " + apellidos; }
        public Usuario()
        {

        }
        
        public Usuario(int ID, string nombre, string apellidos, string username, DateTime fechaNacimiento, string correo, string contrasena)
        {
            this.id = ID;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.username = username;
            this.fecha_nacimiento = fechaNacimiento;
            this.correo = correo;
            this.contrasena = contrasena;
        }
        //Constructor para registrarse, ya que el id se genera sólo
        public Usuario(string nombre, string apellidos, string username, DateTime fechaNacimiento, string correo, string contrasena)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.username = username;
            this.fecha_nacimiento = fechaNacimiento;
            this.correo = correo;
            this.contrasena = contrasena;
        }
        public Usuario(string username, string contrasena)
        {
            this.username = username;
            this.contrasena = contrasena;

        }

        public override string ToString()
        {
            return nombre_completo;
        }
    }
}
    