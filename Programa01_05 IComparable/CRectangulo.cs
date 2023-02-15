using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_05_IComparable
{
    internal class CRectangulo : IComparable
    {
        private double ancho;
        public double alto;
        public double area;

        public CRectangulo(double pAncho, double pAlto)
        {
            ancho = pAncho;
            alto = pAlto;
            CalculaArea();
        }

        private void CalculaArea()
        {
            area = ancho * alto;
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}] = {2}", ancho, alto, area);
        }

        // Implementamos IComparable

        int IComparable.CompareTo(object obj)
        {
            // Hacemos Type Cast con el objeto con el cual nos vamos a comparar
            CRectangulo temp = (CRectangulo)obj;

            // Si somos mas grandes que el objeto regresamos 1
            if (area > temp.area)
                return 1;

            //Si somos mas pequeños que el objeto regresamos -1
            if (area < temp.area)
                return -1;

            // Si somos iguales al objeto regresamos 0
            return 0;

        }
    }
}
