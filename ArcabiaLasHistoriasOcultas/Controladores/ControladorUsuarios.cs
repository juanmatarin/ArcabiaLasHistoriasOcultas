using ArcabiaLasHistoriasOcultas.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public class ControladorUsuarios
    {
        public static MySqlConnection conexion;
        public static MySqlDataAdapter dataAdapterUsuarios;

        public static bool AñadirUsuario(Usuario usuario)
        {
            bool respuesta = true;
            int contador = 0;
            //conexion = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionPostgreSQL"].ConnectionString);
            conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConexionMySql"].ConnectionString);
            //NpgsqlTransaction transaction = null;
            using (conexion)
            {
                try
                {
                    conexion.Open();
                    MySqlCommand comando = conexion.CreateCommand();
                    comando.CommandText = "INSERT INTO `Usuario`(`Nombre`, `Apellidos`, `Username`, `Fecha_Nacimiento`, `Correo`, `Contraseña`) VALUES  " +
                        "(@nombre, @apellidos, @username, @fecha_nacimiento, @correo, @contraseña)";
                    /* comando.CommandText = "INSERT INTO \"Usuario\"'(\"Nombre\", \"Apellidos\", \"Username\", \"Fecha_Nacimiento\", \"Correo\", \"Contraseña\")" +
                        " VALUES ('" + usuario.Nombre + "','" + usuario.Apellidos + "', '" + usuario.Username + "', " + usuario.FechaNacimiento+
                        ", '"+ usuario.Correo + "', '" + usuario.Contraseña + "')";
                    */
                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                    comando.Parameters.AddWithValue("@username", usuario.Username);
                    comando.Parameters.AddWithValue("@fecha_nacimiento", usuario.Fecha_Nacimiento);
                    comando.Parameters.AddWithValue("@correo", usuario.Correo);
                    comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);

                    comando.Prepare();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter();
                    //NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter();
                    adaptador.InsertCommand = comando;

                    // transaction = conexion.BeginTransaction();
                    contador = adaptador.InsertCommand.ExecuteNonQuery();//Ejecuta una consulta y devuelve el número de columnas afectadas

                    if (contador == 0)
                    {
                        respuesta = false;
                    }
                    comando.Dispose();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error en la inserción de datos" + e.Message);
                    respuesta = false;
                }
            }
            return respuesta;

        }
        public static bool ValidarLogin(string usuario, string clave)
        {

            bool respuesta = true;

            try
            {
                conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConexionMySql"].ConnectionString);
                conexion.Open();

                MySqlCommand comando = conexion.CreateCommand();
                comando.CommandText = "SELECT `Username`,`Contraseña` FROM `Usuario` WHERE `Username` = @username";
                comando.Parameters.AddWithValue("@username", usuario);
                comando.Prepare();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    string contraseña = reader.GetString("Contraseña");
                    string nombre_completo = "";
                    if (contraseña == clave)
                    {
                        //nombre_completo = reader.GetString("NombreCompleto");
                        respuesta = true;
                        //MessageBox.Show("Bienvenido " + nombre_completo);
                    }
                    else
                    {
                        respuesta = false;
                    }
                    reader.Close();
                    comando.Dispose();
                    conexion.Close();
                }
                else
                {
                    respuesta = false;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la conexión " + e.Message);
                respuesta = false;
            }

            return respuesta;


        }

        public static void CargarUsuario(DataSet dataset, string usuario)
        {
            try
            {
                conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConexionMySql"].ConnectionString);
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Usuarios WHERE `Username` = @usuario", conexion);
                comando.Parameters.AddWithValue("@username", usuario);
                dataAdapterUsuarios = new MySqlDataAdapter();
                dataAdapterUsuarios.SelectCommand = comando;
                dataAdapterUsuarios.Fill(dataset);
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al leer el usuario " + e.Message);
            }
        }
    }
}

