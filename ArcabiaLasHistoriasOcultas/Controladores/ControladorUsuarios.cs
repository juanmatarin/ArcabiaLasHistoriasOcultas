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

        public static bool validarLogin(string nombreUsuario, string claveRecibida)
        {
            bool login = false;
            var consulta = daoUsuario.login(nombreUsuario);//Consulta va a tener el valor de la contraseña de ese usuario
            
            foreach (var contraseñaConsulta in consulta)
            {
                string contraseña = contraseñaConsulta.GetValue<string>("contrasenia");
                if (contraseña == claveRecibida) //Si la contraseña recibida en la consulta es igual a la clave recibida, salimos y devolvemos true
                {
                    login = true;
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

        public static bool comprobarSiUsuarioExiste(string nombreUsuarioRecibido)
        {
            string nombreUsuario = daoUsuario.getNombreUsuario(nombreUsuarioRecibido);//La variable consulta va a tener el valor del username de ese usuario
            bool existe = false;
            if (nombreUsuario.Equals(nombreUsuarioRecibido))
            {
                existe = true;
            }

            return existe;
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

        public static void actualizarContraseña(string nombreUsuario, string contraseña)
        {
            if (daoUsuario.updateContraseña(nombreUsuario, contraseña))
            {
                MessageBox.Show("La contraseña ha sido actualizada");
            }
        }

    }
}

