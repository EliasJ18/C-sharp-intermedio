using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_06_Delegados_III_con_Multiples_handlers
{
    internal class CTienda
    {
        public static void MandaViveres(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-->Vamos a mandar sus viveres, estoy en la tienda");
            Console.WriteLine("-->Seran {0} kilos", pKilos);
        }
    }
}
