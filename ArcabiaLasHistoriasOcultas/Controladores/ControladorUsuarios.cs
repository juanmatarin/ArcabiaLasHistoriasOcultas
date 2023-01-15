using ArcabiaLasHistoriasOcultas.Clases;
using ArcabiaLasHistoriasOcultas.Clases.DAO;
using ArcabiaLasHistoriasOcultas.Clases.DTO;
using System;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public class ControladorUsuarios
    {
        static DAOUsuario daoUsuario = new DAOUsuario();
        public static void AñadirUsuarioBD(DTOUsuario dtousuario)
        {
            if (daoUsuario.insert(dtousuario))
            {
                MessageBox.Show("Usuario registrado");
                Console.WriteLine("Usuario guardado en la base de datos");
            }
        }

        public static bool ValidarLogin(string nombreUsuario, string claveRecibida)
        {
            bool login = false;
            var consulta = daoUsuario.login(nombreUsuario);//Consulta va a tener el valor de la contraseña de ese usuario
            
            foreach (var contraseñaConsulta in consulta)
            {
                string contraseña = contraseñaConsulta.GetValue<string>("contrasenia");
                if (contraseña == claveRecibida) //Si la contraseña recibida en la consulta es igual a la clave recibida, salimos y devolvemos true
                {
                    login = true;
                    break;
                }
            }
            return login;
        }


        public static void ActualizarUsuario(string nombre, string apellidos, string nombreUsuario, string correo, string nombreUsuario_Recibido)
        {
            if (daoUsuario.update(nombre, apellidos, nombreUsuario, correo, nombreUsuario_Recibido))
            {
                Console.WriteLine("El usuario ha sido actualizado");
            }
        }

        public static bool comprobarUsuarioUnico(string nombreUsuarioRecibido)
        {
            var consulta = daoUsuario.getNombreUsuario(nombreUsuarioRecibido);//La variable consulta va a tener el valor del username de ese usuario
            bool noUnico = false;
            foreach ( var nombreUsuarioConsulta in consulta)
            {
                string username = nombreUsuarioConsulta.GetValue<string>("nombre_usuario");//Esta variable string va a tener el valor de la columna username que hemos recibido en la consulta
                if(username == null)//Si no, no existe existe ningún usuario con ese username
                {
                    noUnico = false;
                    break;
                }
                else if(username == nombreUsuarioRecibido) //Si username es igual al username que hemos recibido por parámetro, significa que ya existe un usuario con ese username
                                                      
                {
                    noUnico = true;
                    break;
                }
            }
            return noUnico;
        }

        public static Usuario CargarUsuario(string nombreUsuario)
        {
            DTOUsuario dtoUsuario = daoUsuario.getUsuario(nombreUsuario);
            Usuario usuario = new Usuario(dtoUsuario.id, dtoUsuario.nombre,dtoUsuario.apellidos, dtoUsuario.nombreUsuario, dtoUsuario.correo);
            return usuario;
        }
        public static int getId(string nombreUsuario)
        {
            return daoUsuario.getId(nombreUsuario);
        }
        
            
    }
}

