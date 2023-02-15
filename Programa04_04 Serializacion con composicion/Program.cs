using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Programa04_04_Serializacion_con_composicion
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
                int cilindros = 0;
                int hp = 0;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                costo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Dame los cilindros");
                cilindros = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dame el hp");
                hp = Convert.ToInt32(Console.ReadLine());

                CAuto miAuto = new CAuto();
                CMotor miMotor = new CMotor();

                miMotor.Cilindros = cilindros;
                miMotor.HP = hp;

                miAuto.Modelo = modelo;
                miAuto.Costo = costo;
                miAuto.Motor = miMotor;

                // Empezamos la serializacion
                Console.WriteLine("--- Serializamos ---");

                // Seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                // Se crea el stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                // Serializamos
                // Aqui la serializacion se realiza en CAuto y CMotor, ya que CMotor está dentro 
                // de CAuto. De esta forma se serializan ambos objetos.
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
