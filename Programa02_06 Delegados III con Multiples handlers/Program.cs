using System;

namespace Programa02_06_Delegados_III_con_Multiples_handlers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos el refri
            CRefri miRefri = new CRefri(70, -20);
            Random rnd = new Random();

            // Variables multicasting, necesitamos la instancia para poder
            // adicionar o eliminar
            DReservasBajas kilos1 = new DReservasBajas(InformeKilos);
            DReservasBajas kilos2 = new DReservasBajas(CTienda.MandaViveres);

            DDescongelado desc1 = new DDescongelado(InformeKilos);

            // Adicionamos los handlers
            miRefri.AdicionaMetodoReservas(kilos1);
            miRefri.AdicionaMetodoReservas(kilos2);
            miRefri.AdicionaMetodoDescongelado(desc1);

            // El refri hace su trabajo
            while (miRefri.Kilos > 0)
            {
                // El refri trabaja y le sacamos kilos al azar
                miRefri.Trabajar(rnd.Next(1, 5));
            }

            // Eliminamos un handler
            miRefri.EliminaMetodoReservas(kilos2);

            ///////////////////////////////////////

            // Rellenamos el refri
            miRefri.Kilos = 50;
            miRefri.Grados = -15;

            while (miRefri.Kilos > 0)
            {
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
