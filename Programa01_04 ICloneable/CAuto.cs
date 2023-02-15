using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_04_ICloneable
{
    internal class CAuto : IAutomovil, ICloneable
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

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public double Tenencia
        {
            get { return tenencia; }
            set { tenencia = value; }
        }

        // Metodos de la interfaz

        public void CalcularTenencia(double pImpuesto)
        {
            tenencia = 5000.0 + costo * pImpuesto;
        }

        public void MuestraInfo()
        {
            // Mostramos la informacion necesaria
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0}, con una tenencia de {1}", costo, tenencia);
            Console.WriteLine("Total ${0}", costo + tenencia);
        }

        // Metodo para implementar a ICloneable
        public object Clone()
        {
            CAuto temp = new CAuto(modelo, costo);
            temp.Tenencia = tenencia;
            return temp;
        }
    }
}
