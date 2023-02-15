using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_06_Archivos
{
    internal class CAuto
    {
        private double costo;
        private string modelo;

        public double Costo { get { return costo; } set { costo = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }

        // Constructor
        public CAuto(string pModelo, double pCosto)
        {
            // Inicializamos los datos
            modelo = pModelo;
            costo = pCosto;
        }

        public void MuestraInformacion()
        {
            // Mostramos la informacion necesaria
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0} ", costo);
            Console.WriteLine("-----------------");
        }
    }
}
