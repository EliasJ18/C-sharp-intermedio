using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_03_Serializacion_XML
{
    [Serializable]

    // La clase es publica

    // La clase en la que se llevara a cabo la serializacion XML no puede llevar parametros en
    // el constructor, es por eso los siguientes cambios en el mismo y la adicion de propiedades
    public class CAuto
    {
            private double costo;
            private string modelo;

        public double Costo
        {
            set { costo = value; }
            get { return costo; }
        }

        public string Modelo
        {
            set { modelo = value; }
            get { return modelo; }
        }

            // Constructor
            public CAuto()
            {
                // Inicializamos los datos
                modelo = "Vocho";
                costo = 100000;
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
