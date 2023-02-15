using System;

namespace Programa01_04_ICloneable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CAuto Auto1 = new CAuto("March", 170000);

            // Aqui pensamos que hacemos clonado
            // Pero solo es otra variable referenciada a la misma instancia
            CAuto Auto2 = Auto1;

            Auto1.CalcularTenencia(0.10);
            Auto2.CalcularTenencia(0.10);

            // Imprimimos
            Auto1.MuestraInfo();
            Auto2.MuestraInfo();

            Console.WriteLine("---------------------");

            // Hacemos un cambio, si fuera un clon solo uno cambia
            // No es un clon, por lo tanto cambian los dos
            Auto1.Costo = 60000;

            // Imprimimos
            Auto1.MuestraInfo();
            Auto2.MuestraInfo();

            Console.WriteLine("=====================");

            // Ahora si hacemos un clon
            CAuto Auto3 = (CAuto)Auto1.Clone();

            Auto1.MuestraInfo();
            Auto3.MuestraInfo();
            Console.WriteLine("---------------------");

            // Modificamos uno, el otro no debe alterarse
            Auto1.Costo = 250000;

            // Imprimimos para verificar
            Auto1.MuestraInfo();
            Auto3.MuestraInfo();
            Console.WriteLine("---------------------------");
        }
    }
}
