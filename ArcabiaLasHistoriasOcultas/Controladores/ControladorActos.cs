using Amazon.Runtime.Documents;
using ArcabiaLasHistoriasOcultas.Clases;
using Markdig;
using Markdig.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public class ControladorActos
    {
        public static List<Acto> getListaActos(string historia)
        {
            List<Acto> listaActos = new List<Acto>();
            string ruta = @"..\..\Archivos\" + historia + @"\instrucciones.json";
            try
            {
                if (File.Exists(ruta))
                {
                    string JsonString = File.ReadAllText(ruta);
                    listaActos = JsonSerializer.Deserialize<List<Acto>>(JsonString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo json " + e.Message);
            }
            return listaActos;
        }

        public static string getTexto(string ruta)
        {
            string texto = File.ReadAllText(ruta);
            var documento = Markdown.Parse(texto);
            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            return Markdown.ToHtml(texto, pipeline);
        }
    }
}
