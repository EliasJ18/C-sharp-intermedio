using System;

namespace Programa01_03_IEnumerable__IEnumerator_y_foreach_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CContenedora datos = new CContenedora();

            foreach (int valor in datos)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
