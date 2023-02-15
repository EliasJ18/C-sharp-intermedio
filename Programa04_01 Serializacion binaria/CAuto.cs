using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_01_Serializacion_binaria
{
    // Con esto indicamos que esta clase es serializable, es decir, podemos almacenar sus instancias
    // en disco duro o algun otro medio.
    [Serializable]
    internal class CAuto
    {
        private double costo;
        private string modelo;

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
