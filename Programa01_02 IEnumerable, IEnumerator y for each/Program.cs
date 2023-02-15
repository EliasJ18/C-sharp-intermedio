using System;
using System.Security.Cryptography.X509Certificates;

namespace Programa01_02_IEnumerable__IEnumerator_y_for_each
{
    internal class Program
    {
        // public interface IEnumerable
        // {
        //     IEnumerator GetEnumerator();
        // }

        // public interface IEnumerator
        //{
        //    bool MoveNext();
        //    object Current { get; }
        //    void Reset;
        //}

        static void Main(string[] args)
        {
            // Creamos la tienda
            CTiendaAutos tienda = new CTiendaAutos();

            // Recorremos cada uno de los elementos de la estructura que expone.

            // foreach no es un ciclo, es un iterador

            foreach(CAuto miAuto in tienda)
            {
                miAuto.CalcularTenencia(0.05);
                miAuto.MuestraInformacion();
            }
        }
    }
}
