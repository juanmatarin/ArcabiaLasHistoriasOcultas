
using ArcabiaLasHistoriasOcultas.Clases;
using ArcabiaLasHistoriasOcultas.Clases.DAO;
using ArcabiaLasHistoriasOcultas.Clases.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public class ControladorActos
    {
        static DAOActo daoActo = new DAOActo();
        public static List<Acto> getListaActos(string ruta)
        {
            List<Acto> listaActos = new List<Acto>();
            ruta += @"\instrucciones.json"; //Siempre se añade el nombre del archivo a la ruta recibida,
                                            //puesto que puede ser una ruta creada dinámicamente por el programa donde se albergan los cambios
            try
            {
                if (File.Exists(ruta)) //Si el archivo existe
                {
                    var contenido = File.ReadAllBytes(ruta);
                    listaActos = JsonSerializer.Deserialize<List<Acto>>(contenido);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo json " + e.Message);
            }
            return listaActos;
        }

        public static bool guardarActos(List<Acto> listaActos, string ruta)
        {
            bool guardar = false;
            

            try
            {
                if (!File.Exists(ruta))
                {
                    ruta += @"\instrucciones.json";
                }
                var contenido = JsonSerializer.SerializeToUtf8Bytes(listaActos);
                File.WriteAllBytes(ruta, contenido);
                guardar = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo json " + e.Message);
            }
            return guardar;
        }
        public static string getTexto(string ruta)
        {
            string texto = ""; 
            if (!ruta.Equals("[FIN]"))
            {
                texto = File.ReadAllText(ruta);
            }
            return texto;
        }
        public static List<Acto> getActosBD(int idHistoriaRecibido)
        {
            List<DTOActo> listaActosBD = daoActo.select(idHistoriaRecibido);//Recibimos la lista de actos de la base de datos
            listaActosBD.Sort((x,y) => x.id.CompareTo(y.id));
            List<Acto> listaActos = new List<Acto>();//Vamos a guardar los valores de estos actos en objetos de la clase Acto, que es la que se va a usar en local
            foreach (DTOActo dtoActo in listaActosBD)
            {
                
                int idActo = dtoActo.id;
                int idHistoria = dtoActo.idHistoria;
                List<Opcion> listaOpcionesActo = ControladorOpciones.getOpcionesBD(dtoActo.id);
                string contenidohtml = dtoActo.contenidoHTML;
                listaActos.Add(new Acto(idActo, idHistoria, listaOpcionesActo, contenidohtml));

            }
            return listaActos;
        }
    }
}
