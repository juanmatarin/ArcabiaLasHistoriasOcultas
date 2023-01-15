using ArcabiaLasHistoriasOcultas.Clases.DTO;
using Cassandra;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq.Expressions;

namespace ArcabiaLasHistoriasOcultas.Clases.DAO
{
    public  class DAOHistoria
    {
        Session session = null;
        public DAOHistoria()
        {
            conexion();
        }
        public void conexion()
        {
            Cluster cluster = Cluster.Builder().AddContactPoint(ConfigurationManager.ConnectionStrings["IpEquipo"].ConnectionString).Build();
            session = (Session)cluster.Connect("arcabia_keyspace");
        }
        public void insert(DTOHistoria dtohistoria)
        {
            try
            {
                /*string insert = "INSERT INTO Historia(id, nombre, rutaImagen, contenidoJSON) VALUES (" + dtohistoria.id + ",'"
                    + dtohistoria.nombre + "', " + dtohistoria.rutaImagen + ", '" + dtohistoria.contenidoJSON + "');";
                session.Execute(insert);*/
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la inserción de datos" + e.Message);
            }
        }
        public List<DTOHistoria> select()
        {
            var consulta = session.Execute("select * from Historia;");
            List<DTOHistoria> listaHistoriasBD = new List<DTOHistoria>();
            foreach (var info in consulta)
            {
                int id = info.GetValue<int>("id");
                string nombre = info.GetValue<string>("nombre");
                string rutaImagen = info.GetValue<string>("rutaimagen");

                DTOHistoria historiaAGuardar = new DTOHistoria(id, nombre, rutaImagen);
                listaHistoriasBD.Add(historiaAGuardar);

            }
            return listaHistoriasBD;
        }
        public dynamic getHistorias()
        {
            var consulta = "";
            return consulta;
            
        }
        public dynamic getId()
        {
            var consulta = "SELECT id FROM Partida;";
            return consulta;
        }
        public void update()
        {

        }
    }
}
