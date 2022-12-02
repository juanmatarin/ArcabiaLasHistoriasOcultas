using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Clases
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Username { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string NombreCompleto { get => Nombre + " " + Apellidos; }
        public Usuario()
        {

        }
        //Constructor para registrarse
        public Usuario(string nombre, string apellidos, string username, DateTime fechaNacimiento, string correo, string contraseña)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Username = username;
            this.Fecha_Nacimiento = fechaNacimiento;
            this.Correo = correo;
            this.Contraseña = contraseña;
        }

        public Usuario(string username, string contraseña)
        {
            this.Username = username;
            this.Contraseña = contraseña;

        }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
    