using System;

namespace Programa02_04_Delegados_I_simple
{
    // Los delegados deben llevar el mismo modificador y los mismos parametros
    // que los metodos a los que se hará referencia a través de él.

    // Definimos el delegado con las caracteristicas que nos interesa
    // Al definir el delegado aquí, hacemos que sea conocido por todo el
    // namespace, si lo definimos dentro de la clase, solo será conocido
    // por esa clase.
    // Delegate indica que se creará una instancia de un delegado
    public delegate void MiDelegado(string m);

    internal class Program
    {
        // El delegado podria ser definido aqui pero solo seria conocido
        // por esta clase.

        static void Main(string[] args)
        {
            // Creamos un objeto del delegado y lo referenciamos a un metodo
            MiDelegado delegado = new MiDelegado(CRadio.MetodoRadio);

            // Ahora por medio del delegado hacemos uso del metodo
            delegado("Hola a todos");

            // Hacemos que apunte a otro metodo
            delegado = new MiDelegado(CPastel.MostrarPastel);

            // Ahora invocamos el otro metodo
            delegado("Feliz cumpleaños");
        }
    }
}
