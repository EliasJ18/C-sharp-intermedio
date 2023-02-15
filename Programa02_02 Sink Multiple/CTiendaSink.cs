using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_02_Sink_Multiple
{
    internal class CTiendaSink : IEventosRefri
    {
        public void EReservasBajas(int pKilos)
        {
            // Aqui se coloca todo el codigo necesario para ejecutar cuando
            // suceda el evento.

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-->Le enviaremos sus viveres");
            Console.WriteLine("-->Seran {0} kilos", pKilos);
        }

        public void EDescongelado(int pGrados)
        {
            // Handler vacío. A la clase tiendasink no le interesa
            // conocer los grados del refri
            // La funcion se coloca para implementar el metodo de la interfaz
        }
    }
}
