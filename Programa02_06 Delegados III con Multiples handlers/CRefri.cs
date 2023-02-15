using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_06_Delegados_III_con_Multiples_handlers
{
    // Aqui van los delegados
    // Esta vez por fuera de la clase para desacernos de public
    delegate void DReservasBajas(int pKilos);
    delegate void DDescongelado(int pGrados);

    internal class CRefri
    {

        private int kilosAlimentos = 0;
        private int grados = 0;

        // Aqui estan las variables que usaremos para invocar
        private DReservasBajas delReservas;
        private DDescongelado delDescongelado;

        public CRefri(int pKilos, int pGrados)
        {
            // Coloca los valores iniciales del refri

            kilosAlimentos = pKilos;
            grados = pGrados;
        }

        // Estos metodos permiten referenciar las variables
        // Hacemos multicasting
        public void AdicionaMetodoReservas(DReservasBajas pMetodo)
        {
            delReservas += pMetodo;
        }

        public void EliminaMetodoReservas(DReservasBajas pMetodo)
        {
            delReservas -= pMetodo;
        }

        public void AdicionaMetodoDescongelado(DDescongelado pMetodo)
        {
            delDescongelado += pMetodo;
        }

        // Propiedades necesarias
        public int Kilos
        {
            get { return kilosAlimentos; }
            set { kilosAlimentos = value; }
        }

        public int Grados
        {
            get { return grados; }
            set { grados = value; }
        }

        public void Trabajar(int pConsumo)
        {
            // Actualizamos los kilos del refri
            kilosAlimentos -= pConsumo;

            // Subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilosAlimentos, grados);

            // Hay que verificar si se cumple la condicion para
            // invocar los handlers del evento

            // Esta es la condicion del evento para los kilos
            if (kilosAlimentos < 10)
            {
                // Invocamos el metodo
                delReservas(kilosAlimentos);
            }

            // Esta es la condicion par el evento de descongelado
            if (grados >= 0)
            {
                // Invocamos el metodo
                delDescongelado(grados);
            }
        }
    }
}
