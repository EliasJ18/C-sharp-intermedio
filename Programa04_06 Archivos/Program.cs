using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Programa04_06_Archivos
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

                // Variables extra
                int numero = 5;
                bool acceso = false;
                byte conteo = 120;

                // Se crea el stream
                FileStream fs = new FileStream("MiArchivo.arc", FileMode.Create, FileAccess.Write, FileShare.None);

                // Creamos el escritor
                BinaryWriter writer = new BinaryWriter(fs);

                // Escribimos los atributos del objeto
                // OJO, no estamos serializando

                writer.Write(miAuto.Modelo);
                writer.Write(miAuto.Costo);

                // Escribimos las variables
                writer.Write(numero);
                writer.Write(acceso);
                writer.Write(conteo);

                // Cerramos el stream
                fs.Close();

            }

            if (opcion == 2)
            {
                // Deserializamos el objeto
                Console.WriteLine("--- Leemos archivo ---");

                // Creamos stream
                Stream fs = new FileStream("MiArchivo.arc", FileMode.Open, FileAccess.Read, FileShare.None);

                // Creamos el lector
                BinaryReader lector = new BinaryReader(fs);

                // Leemos en el mismo orden que se escribió
                // tomando en cuenta el tipo

                string modelo = "";
                double costo = 0;
                int numero = 0;
                bool acceso = true;
                byte conteo = 0;

                modelo = lector.ReadString();
                costo = lector.ReadDouble();
                CAuto miAuto = new CAuto(modelo, costo);

                numero = lector.ReadInt32();
                acceso = lector.ReadBoolean();
                conteo = lector.ReadByte();

            }
        }
    }
}
