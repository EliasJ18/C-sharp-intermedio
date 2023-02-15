using System;
using System.Security.Cryptography.X509Certificates;

namespace Programa02_05_Delegados_II_con_Handlers_y_eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos el refri
            CRefri miRefri = new CRefri(70, -20);

            Random rnd = new Random();

            // Adicionamos los handlers
            miRefri.AdicionaMetodoReservas(new CRefri.DReservasBajas(InformeKilos));
            miRefri.AdicionaMetodoDescongelado(new CRefri.DDescongelado(InformeGrados));

            // El refri hace su trabajo
            while (miRefri.Kilos > 0)
            {
                // El refri trabaja y le sacamos kilos al azar
                miRefri.Trabajar(rnd.Next(1, 5));
            }
        }

        public static void InformeKilos(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservas bajas de alimentos, estoy a nivel de main");
            Console.WriteLine("-->Quedan {0} kilos", pKilos);
        }

        public static void InformeGrados(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-->Se descongela el refri!, estoy a nivel de main");
            Console.WriteLine("-->Quedan {0} grados", pGrados);
        }
    }
}
