using System;

namespace MisMates
{
    // Esta sera la libreria que añadamos a la lista de referencias para
    // que podamos usarla desde otros proyectos/soluciones
    public class CMates
    {
        public static double Suma(double pA, double pB)
        {
            return pA + pB;
        }

        public static double Resta(double pA, double pB)
        {
            return pA - pB;
        }

        public static double Multi(double pA, double pB)
        {
            return pA * pB;
        }

        public static double Div(double pA, double pB)
        {
            return pA / pB;
        }
    }
}
