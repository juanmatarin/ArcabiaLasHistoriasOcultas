﻿using ArcabiaLasHistoriasOcultas.Clases.DTO;
using Cassandra;
using System;
using System.Linq;

namespace ArcabiaLasHistoriasOcultas.Clases.DAO
{
    public class DAOUsuario
    {
        Session session = null;
        public DAOUsuario()
        {
            conexion();
        }
        public void conexion()
        {
            Cluster cluster = Cluster.Builder().AddContactPoint("192.168.1.131").Build(); //En el contactPoint debes escribir la ip de tu equipo
            session = (Session)cluster.Connect("arcabia_keyspace");
        }

        public dynamic getUsername(string username)
        {
            var consulta = session.Execute("SELECT nombre_usuario FROM Usuario WHERE nombre_usuario = '" + username + "' ALLOW FILTERING;"); 
            return consulta; //ALLOW FILTERING tenemos que usarlo al filtrar por un valor o columna que no sea la clave primaria
        }
        public dynamic getId(string nombreUsuario)
        {
            var consulta = session.Execute("SELECT id FROM Usuario WHERE nombre_usuario = '" + nombreUsuario + "' ALLOW FILTERING;");
            return consulta;

        }

        public bool insert(DTOUsuario dtousuario)
        {
            bool insertado;
            try
            {
                //Vamos a obtener un id único
                Random r = new Random();
                int idADevolver = r.Next(1, 1000);
                var consulta = session.Execute("SELECT id FROM Usuario;");

                foreach (var id in consulta)
                {
                    int idRecibido = id.GetValue<int>("id");
                    if (idRecibido == idADevolver) //Comprobamos el id generado con todos los id usuario, para que sea un id único
                    {
                        idADevolver++; //Si lo es, entra en el if y le suma uno, para comprobar si este existe o no, así hasta que encuentre uno no usado
                    }
                }

                //CQL acepta el formato year-month-day para Date
                //Recogemos el día, mes y año, para convertirlo en un formato que acepte cassandra
                int dia = dtousuario.fechaNacimiento.Day;
                int mes = dtousuario.fechaNacimiento.Month;
                int año = dtousuario.fechaNacimiento.Year;

                string insert = "";
                if(dia < 10 && mes < 10)//Cuando el dia y el mes son menores de 10 hacemos lo siguiente
                {
                    string diaValido = "0" + dia;// Esto se hace porque tanto para los dias como para los meses del 1 al 9, debe tener un 0 antes,                                                 
                    string mesValido = "0" + mes;// si no cassandra, mas en concreto cql, no nos deja hacer el insert, ya que el formato no es válido
                    insert = "INSERT INTO Usuario(id,nombre,apellidos,nombre_usuario,fecha_nacimiento,correo,contrasenia) VALUES (" + idADevolver + ",'" + dtousuario.nombre + "', '" + dtousuario.apellidos + "', '" + dtousuario.nombreUsuario + "', '" +
                    año + "-" + mesValido + "-" + diaValido + "', '" + dtousuario.correo + "', '" + dtousuario.contraseña + "')";

                    session.Execute(insert);//Ejecutamos el insert
                    
                }else if(dia < 10)
                {
                    string diaValido = "0" + dia;
                    insert = "INSERT INTO Usuario(id,nombre,apellidos,nombre_usuario,fecha_nacimiento,correo,contrasenia) VALUES (" + idADevolver + ",'" + dtousuario.nombre + "', '" + dtousuario.apellidos + "', '" + dtousuario.nombreUsuario + "', '" +
                    año + "-" + mes + "-" + diaValido + "', '" + dtousuario.correo + "', '" + dtousuario.contraseña + "')";

                    session.Execute(insert);//Ejecutamos el insert

                }else if(mes < 10)
                {
                    string mesValido = "0" + mes;
                    insert = "INSERT INTO Usuario(id,nombre,apellidos,nombre_usuario,fecha_nacimiento,correo,contrasenia) VALUES (" + idADevolver + ",'" + dtousuario.nombre + "', '" + dtousuario.apellidos + "', '" + dtousuario.nombreUsuario + "', '" +
                    año + "-" + mesValido + "-" + dia + "', '" + dtousuario.correo + "', '" + dtousuario.contraseña + "')";

                    session.Execute(insert);//Ejecutamos el insert

                }else if(dia > 10 && mes > 10)
                {
                    insert = "INSERT INTO Usuario(id,nombre,apellidos,nombre_usuario,fecha_nacimiento,correo,contrasenia) VALUES (" + idADevolver + ",'" + dtousuario.nombre + "', '" + dtousuario.apellidos + "', '" + dtousuario.nombreUsuario + "', '" +
                    año + "-" + mes + "-" + dia + "', '" + dtousuario.correo + "', '" + dtousuario.contraseña + "')";

                    session.Execute(insert);//Ejecutamos el insert
                    
                }
                insertado = true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la inserción de datos" + e.Message);
                insertado = false;
            }
            return insertado;

        }

        public dynamic login(string nombreUsuario)//Accede a la base de datos
        {
            //Hacemos un select para recoger la contraseña que tenga ese usuario
            var consulta = session.Execute("SELECT contrasenia FROM Usuario WHERE nombre_usuario = '" + nombreUsuario + "' ALLOW FILTERING");
            return consulta;

        }
        public dynamic getUsuario(string username)
        {
            var consulta = session.Execute("SELECT id,nombre,apellidos,nombre_usuario,correo FROM Usuario WHERE nombre_usuario = '" + username + "' ALLOW FILTERING");
            return consulta;
        }
        public bool update(string nombre, string apellidos, string nombre_usuario, string correo, string nombreUsuario_Recibido)//Método update, para actualizar datos de la tabla Usuario
        {
            bool actualizado;

            //Lo primero, vamos a obtener el id del usuario que vamos a actualizar, ya que necesitamos es la clave primaria de la tabla
            int id = getId(nombreUsuario_Recibido);
            try
            {
                
                session.Execute("update Usuario set nombre = '" + nombre + "', apellidos = '" + apellidos + "', nombre_usuario = '" + nombre_usuario 
                    + "',correo = '" + correo + "' WHERE id = " + id + ";");
                actualizado = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al actualizar " + e.Message);
                actualizado = false;
            }
            return actualizado;
        }
    }
}
