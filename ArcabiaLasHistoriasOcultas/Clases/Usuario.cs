using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Username { get; set; }
        public DateTime Fecha_Nacimiento { get; set; } 
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string NombreCompleto { get => Nombre + " " + Apellidos; }
        public Usuario()
        {

        }
        //Constructor para registrarse
        public Usuario(int ID, string nombre, string apellidos, string username, DateTime fechaNacimiento, string correo, string contrasena)
        {
            this.ID = ID;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Username = username;
            this.Fecha_Nacimiento = fechaNacimiento;
            this.Correo = correo;
            this.Contrasena = contrasena;
        }
        public Usuario(string nombre, string apellidos, string username, DateTime fechaNacimiento, string correo, string contrasena)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Username = username;
            this.Fecha_Nacimiento = fechaNacimiento;
            this.Correo = correo;
            this.Contrasena = contrasena;
        }
        public Usuario(string username, string contrasena)
        {
            this.Username = username;
            this.Contrasena = contrasena;

        }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
    