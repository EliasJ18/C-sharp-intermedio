using System;

namespace Practicas_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CAuto msj = new CAuto();
            CAuto motor = new CAuto();

            motor.Motor = "200 caballos";

            Console.WriteLine(msj.Motor);   
        }
    }
}
