using System;

namespace Programa03_03_Sobrecarga_de_operadores_unuarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CImaginario im1 = new CImaginario(1, 2);
            //CImaginario im2 = new CImaginario(3, 4);
            //CImaginario imr;

            //// Hacemos la suma
            //imr = im1 + im2;

            //Console.WriteLine("{0} + {1} = {2}", im1, im2, imr);

            //// Hacemos la resta
            //imr = im1 - im2;

            //Console.WriteLine("{0} - {1} = {2}", im1, im2, imr);

            //// Hacemos la multiplicacion
            //imr = im1 * im2;

            //Console.WriteLine("{0} * {1} = {2}", im1, im2, imr);

            //// Hacemos la division
            //imr = im1 / im2;

            //Console.WriteLine("{0} / {1} = {2}", im1, im2, imr);

            // ------------------------------------

            // Pruebas de sobrecarga de igualdad, desigualdad y comparacion

            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);
            CImaginario im3 = new CImaginario(5, 7);

            if (im1 == im3)
            {
                Console.WriteLine("Son iguales");
            }

            if (im2 != im1)
            {
                Console.WriteLine("Son diferentes");
            }

            if (im1 < im3)
            {
                Console.WriteLine("im1 es menor");
            }

            if (im2 > im1)
            {
                Console.WriteLine("im2 es mayor");
            }
        }
    }
}
