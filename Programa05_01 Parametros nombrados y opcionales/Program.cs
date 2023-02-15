
using System;

namespace Programa05_01_Parametros_nombrados_y_opcionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Invocamos la funcion de forma normal
            // tres posicionales
            mostrarDatos(3, 5, 7);

            // Invocamos la funcion con primero en normal, los demas en otro orden
            // un posicional, dos nombrados
            mostrarDatos(3, pC: 11, pB: 15);

            // Invocamos la funcion con los datos en otro orden
            // tres nombrados
            mostrarDatos(pB: 10, pC: 15, pA: 4);

            // Un posicional no puede venir despues de un nombrado
            // Esto da error
            // mostrarDatos(pB: 5, 7, 8);

            Console.WriteLine("Ahora con parametros opcionales");

            // Invocamos normal
            mostrarOpcionales(11, 12, 13);

            // Usamos dos parametros, c usa el opcional
            mostrarOpcionales(20, 21);

            // Usamos un parametro, b y c usan el opcional
            mostrarOpcionales(31);

            // Usamos todos los parametros opcionales
            mostrarOpcionales();

            Console.WriteLine("Ahora con parametros nombrados y opcionales");

            // Un opcional, dos nombrados
            mostrarOpcionales(pC: 67, pB: 45);

            // Dos opcionales con un nombrado
            mostrarOpcionales(pB: 56);
        }

        public static void mostrarDatos(int pA, int pB, int pC)
        {
            Console.WriteLine("El valor de A es {0}", pA);
            Console.WriteLine("El valor de B es {0}", pB);
            Console.WriteLine("El valor de C es {0}", pC);
            Console.WriteLine("------------------------");
        }

        public static void mostrarOpcionales(int pA = 1, int pB = 2, int pC = 3)
        {
            Console.WriteLine("El valor de A es {0}", pA);
            Console.WriteLine("El valor de B es {0}", pB);
            Console.WriteLine("El valor de C es {0}", pC);
            Console.WriteLine("------------------------");
        }
    }
}
