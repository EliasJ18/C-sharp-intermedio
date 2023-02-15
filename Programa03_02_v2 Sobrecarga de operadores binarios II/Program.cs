using System;

namespace Programa03_02_v2_Sobrecarga_de_operadores_binarios_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);
            CImaginario imr;

            // Hacemos la suma
            imr = im1 + im2;

            Console.WriteLine("{0} + {1} = {2}", im1, im2, imr);

            // Hacemos la resta
            imr = im1 - im2;

            Console.WriteLine("{0} - {1} = {2}", im1, im2, imr);

            // Hacemos la multiplicacion
            imr = im1 * im2;

            Console.WriteLine("{0} * {1} = {2}", im1, im2, imr);

            // Hacemos la division
            imr = im1 / im2;

            Console.WriteLine("{0} / {1} = {2}", im1, im2, imr);
        }
    }
}
