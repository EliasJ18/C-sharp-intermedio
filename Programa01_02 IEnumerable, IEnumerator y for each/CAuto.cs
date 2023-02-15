using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_02_IEnumerable__IEnumerator_y_for_each
{
    internal class CAuto : IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;

        // Constructor
        public CAuto(string pModelo, double pCosto)
        {
            // Inicializamos los datos
            costo = pCosto;
            modelo = pModelo;
        }

        // Metodos de la interfaz

        public void CalcularTenencia(double pImpuesto)
        {
            tenencia = 5000.0 + costo * pImpuesto;
        }

        public void MuestraInformacion()
        {
            // Mostramos la informacion necesaria
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0}, con una tenencia de {1}", costo, tenencia);
            Console.WriteLine("Total ${0}", costo + tenencia);
        }
    }
}
