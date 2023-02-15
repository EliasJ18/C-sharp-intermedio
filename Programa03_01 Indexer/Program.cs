using System;

namespace Programa03_01_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 0;

            //Creamos la tienda
            CTiendaAutos miTienda = new CTiendaAutos();

            // Obtenemos un auto
            // El elemento guardado en la posicion 1 del array de
            // CTiendaAutos instanciado a través de miTienda, se pasa
            // por parametro al constructor de CAuto, instanciado a través
            // de miAuto.
            CAuto miAuto = miTienda[1];
            miAuto.MuestraInformacion();

            // Colocamos un auto
            // Ahora al revés, el constructor de CAuto recibe los datos
            // necesarios por la instanciacion otroAuto, y CTiendaAutos lo 
            // guarda en su array en la posicion 1 por la instanciacion miTienda.
            CAuto otroAuto = new CAuto("Vocho", 85000);
            miTienda[1] = otroAuto;

            // Imprimimos toda la tienda
            for (n = 0; n < 4; n++)
            {
                miTienda[n].MuestraInformacion();
            }
        }
    }
}
