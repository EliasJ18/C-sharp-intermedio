using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Programa04_02_Serializacion_Soap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;


            Console.WriteLine("1) Crear y serializar auto, 2) Leer auto");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                // Creamos el objeto CAuto
                string modelo = "";
                double costo = 0;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                costo = Convert.ToDouble(Console.ReadLine());

                CAuto miAuto = new CAuto(modelo, costo);

                Console.WriteLine("Auto a serializar");
                miAuto.MuestraInformacion();

                // Empezamos la serializacion
                Console.WriteLine("--- Serializamos ---");

                // La serializacion Soap permite guardar objetos de mayor
                // tamaño en el disco u otro medio de almacenamiento

                // La serializacion Soap es util si vamos a intercambiar
                // informacion entre sistemas operativos que son diferentes

                // Soap es un protocolo que nos va a definir como podemos llevar a cabo intercambio de informacion
                // entre dos objetos utilizando XML. En este caso lo usaremos de la misma manera que la
                // serializacion binaria, para guardar el estado del objeto en el disco y luego
                // sacar ese estado y reconstruir al objeto.

                // Seleccionamos el formateador
                SoapFormatter formateador = new SoapFormatter();

                // Se crea el stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                // Serializamos
                formateador.Serialize(miStream, miAuto);

                // Cerramos el stream
                miStream.Close();
            }

            if (opcion == 2)
            {
                // Deserializamos el objeto
                Console.WriteLine("--- Deserializamos ---");

                // Seleccionamos el formateador
                SoapFormatter formateador = new SoapFormatter();

                // Creamos stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                // Deserializamos
                CAuto miAuto = (CAuto)formateador.Deserialize(miStream);

                // Cerramos el stream
                miStream.Close();

                // Usamos el objeto
                Console.WriteLine("EL auto deserializado es");
                miAuto.MuestraInformacion();
            }
        }
    }
}
