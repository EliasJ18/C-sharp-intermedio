using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_01_Indexer
{
    internal class CAuto
    {
        double costo;
        string modelo;

        // Constructor
        public CAuto(string pModelo, double pCosto)
        {
            // Inicializamos los datos
            costo = pCosto;
            modelo = pModelo;
        }

        public void MuestraInformacion()
        {
            // Mostramos la informacion necesaria
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0} ", costo);
            Console.WriteLine("-----------");
        }
    }
}
