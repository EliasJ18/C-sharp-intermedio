using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_01_Indexer
{
    internal class CTiendaAutos
    {
        private CAuto[] disponibles;

        public CTiendaAutos()
        {
            disponibles = new CAuto[4];

            disponibles[0] = new CAuto("Soul", 220000.50);
            disponibles[1] = new CAuto("Fit", 175600.70);
            disponibles[2] = new CAuto("March", 168900.00);
            disponibles[3] = new CAuto("Spark", 160400.40);
        }

        // Aqui creamos el indexer
        // El indexer va a ser similar a la forma en que trabajan las propiedades
        // solo que la utilizaremos para arreglos o estructuras similares

        // El tipo que está guardando nuestro arreglo es CAuto,
        // este indexer nos va a servir para que podamos obtener CAutos o
        // colocar CAutos. Por eso es el tipo.

        // Colocamos this directamnte para que podamos utilizar la clase del
        // objeto que instanciemos de la clase CTiendaAutos y a través de este
        // objeto simplemente indicar el indice que nos interesa para poder
        // llevar a cabo la manipulacion.

        // Entre corchetes simplemente pasamos como parametro un dato de tipo
        // entero que actuará como el indice del arreglo. De esta manera, el
        // get y set harán su trabajo en la posicion del arreglo que se le
        // pasó por parametro.
        public CAuto this[int indice]
        {
            // Usamos un get para obtener el elemento de ese indice
            get { return disponibles[indice]; }
            
            // Usamos un set para colocar un elemento en ese indice
            set { disponibles[indice] = value; }
        }
    }
}
