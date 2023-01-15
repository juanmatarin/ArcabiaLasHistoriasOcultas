using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcabiaLasHistoriasOcultas.Controladores
{
    public class ControladorDirectorios
    {
        public static string crearDirectorio(string ruta, int numero)
        {
            DirectoryInfo di = Directory.CreateDirectory(ruta + numero);
            return di.FullName;
        }
    }
}
