using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_03_Sobrecarga_de_operadores_unuarios
{
    internal class CImaginario : IComparable
    {
        // Creamos los atributos de la clase
        private double entero;
        private double imaginario;

        // Creamos el constructor
        public CImaginario(double pEntero, double pImaginario)
        {
            entero = pEntero;
            imaginario = pImaginario;
        }

        // Creamos las propiedades
        public double Entero
        {
            get { return entero; }
            set { entero = value; }
        }

        public double Imaginario
        {
            get { return imaginario; }
            set { imaginario = value; }
        }

        // Para mostrar el numero imaginario
        public override string ToString()
        {
            if (imaginario < 0)
                return string.Format("({0} {1}i)", entero, imaginario);
            else
                return string.Format("({0} + {1}i)", entero, imaginario);
        }

        // Sobrecarga de los operadores binarios
        // a = i1 + i2
        public static CImaginario operator +(CImaginario i1, CImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = i1.Entero + i2.Entero;
            ri = i1.Imaginario + i2.Imaginario;

            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        public static CImaginario operator -(CImaginario i1, CImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = i1.Entero - i2.Entero;
            ri = i1.Imaginario - i2.Imaginario;

            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        public static CImaginario operator *(CImaginario i1, CImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = (i1.Entero * i2.Entero) - (i1.Imaginario * i2.Imaginario);
            ri = (i1.Entero * i2.Imaginario) + (i1.Imaginario + i2.Entero);

            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        public static CImaginario operator /(CImaginario i1, CImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = ((i1.Entero * i2.Entero) + (i1.Imaginario * i2.Imaginario))
                / ((i2.Entero * i2.Entero) + (i2.Imaginario * i2.Imaginario));


            ri = ((i1.Imaginario * i2.Entero) - (i1.Entero * i2.Imaginario))
                / ((i2.Entero * i2.Entero) + (i2.Imaginario * i2.Imaginario));

            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        // Sobrecarga de operadores unuarios

        public static CImaginario operator ++(CImaginario i1)
        {
            CImaginario temp = new CImaginario(i1.Entero + 1, i1.Imaginario + 1);

            return temp;
        }

        public static CImaginario operator --(CImaginario i1)
        {
            CImaginario temp = new CImaginario(i1.Entero - 1, i1.Imaginario - 1);

            return temp;
        }

        // Sobrecarga de operadores de igualdad y desigualdad 

        public override bool Equals(object obj)
        {
            // Verificamos que sea del tipo correcto

            if (obj is CImaginario)
            {
                CImaginario temp = (CImaginario) obj;

                // Comparamos por igualdad
                if (imaginario == temp.Imaginario && entero == temp.Entero)
                    return true;
            }

            return false;
        }

        // Al sobrecargar el operador de igualdad, obligadamente debo implementar 
        // el operador de desigualdad o dará error.
        public static bool operator ==(CImaginario i1, CImaginario i2)
        {
            return i1.Equals(i2);
        }

        public static bool operator !=(CImaginario i1, CImaginario i2)
        {
            return !(i1.Equals(i2));
        }

        // Sobrecarga de < y > necesitamos IComparable
        public double magnitud()
        {
            double m = 0;
            m = Math.Sqrt((entero * entero) + (imaginario * imaginario));

            return m;
        }

        public int CompareTo(object obj)
        {
            if (obj is CImaginario)
            {
                CImaginario temp = (CImaginario) obj;

                if (magnitud() > temp.magnitud())
                    return 1;
                if (magnitud() < temp.magnitud())
                    return -1;
            }

            return 0;
        }

        // Al igual que con la sobrecarga del operador de igualdad, al sobrecargar un 
        // operador de comparación, obligadamente debemmos implementar su opuesto también. 
        public static bool operator <(CImaginario i1, CImaginario i2)
        {
            if (i1.CompareTo(i2) < 0) 
                return true;
            else 
                return false;
        }

        public static bool operator >(CImaginario i1, CImaginario i2)
        {
            if (i1.CompareTo(i2) > 0)
                return true;
            else
                return false;
        }

        // Con esto solo corregimos el warning de la clase, no es necesario.
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
