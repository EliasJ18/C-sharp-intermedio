using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_04_Serializacion_con_composicion
{
    // Serializaremos mas de 1 objeto
    // Serializacion con objetos en composicion
    [Serializable]
    internal class CAuto
    {
        private double costo;
        private string modelo;
        private CMotor motor;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public CMotor Motor
        {
            get { return motor; }
            set { motor = value; }
        }

        // Constructor
        public CAuto()
        {
            // Inicializamos los datos
            modelo = "Vocho";
            costo = 100000;
            motor = new CMotor();
        }

        public void MuestraInformacion()
        {
            // Mostramos la informacion necesaria
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0} ", costo);
            motor.MuestraMotor();
            Console.WriteLine("-----------------");
        }
    }
}
