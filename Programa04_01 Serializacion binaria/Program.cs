using System;
// usings adicionales y necesarios para llevar a cabo la serializacion
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Programa04_01_Serializacion_binaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;


            Console.WriteLine("1) Crear y serializar auto, 2) Leer auto");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1 )
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

                // Seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

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
                BinaryFormatter formateador = new BinaryFormatter();

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
