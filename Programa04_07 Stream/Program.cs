using System;
using System.IO;

namespace Programa04_07_Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long cantidad = 0;
            long n = 0;
            int valor = 0;

            FileStream fs = new FileStream("datos.txt", FileMode.Open, FileAccess.Read, FileShare.None);

            // Obtenemos la cantidad
            cantidad = fs.Length;
            Console.WriteLine("El archivo mide {0}", cantidad);

            // Leemos byte por byte

            for (n = 0; n < cantidad; n++)
            {
                // Ponemos la posicion
                fs.Seek(n, SeekOrigin.Begin);

                valor = fs.ReadByte();

                Console.WriteLine(" {0} ", (char)valor);

            }

            Console.WriteLine("\n-----------------------\n");

            // Leemos ahora en el otro sentido
            for (n = 1; n <= cantidad; n++)
            {
                // Ponemos la posicion
                fs.Seek(-n, SeekOrigin.End);

                valor = fs.ReadByte();

                Console.WriteLine(" {0} ", (char)valor);
            }

            Console.WriteLine("\n-----------------------\n");

            fs.Seek(0, SeekOrigin.Begin);

            // Leer sin conocer la longitud
            while ((valor = fs.ReadByte()) > 0)
            {
                Console.WriteLine(" {0} ", (char)valor);
            }

            Console.WriteLine("\n-----------------------\n");

            fs.Close();
        }
    }
}
