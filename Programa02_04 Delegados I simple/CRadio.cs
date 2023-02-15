using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_04_Delegados_I_simple
{
    internal class CRadio
    {
        // Este metodo actuará como delegado
        // El modificador static va a ser necesario para poder utilizar
        // el delegado, ya que con esto garantizamos que podemos
        // invocar este metodo aún si no exista una instancia
        // de la clase radio.
        public static void MetodoRadio(string pMsj)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase radio");
            Console.WriteLine("Este es tu mensaje: {0}", pMsj);
        }
    }
}
