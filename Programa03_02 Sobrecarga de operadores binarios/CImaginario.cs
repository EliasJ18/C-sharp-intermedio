﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Programa03_02_Sobrecarga_de_operadores_binarios
{
    internal class CImaginario
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

            CImaginario temp = new CImaginario(ri, re);
            return temp;
        }

    }
}
