using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_04_Delegados_I_simple
{
    internal class CPastel
    {
        // Este metodo actuará como delegado
        public static void MostrarPastel(string pAnuncio)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El pastel llevara el mensaje de: {0}", pAnuncio);
        }
    }
}
