using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_04_Serializacion_con_composicion
{
    [Serializable]
    internal class CMotor
    {
        private int cilindros;
        private int hp;

        public int Cilindros { get { return cilindros; } set { cilindros = value; } }
        public int HP { get { return hp; } set { hp = value; } }

        public CMotor()
        {
            cilindros = 4;
            hp = 200;
        }

        public void MuestraMotor()
        {
            Console.WriteLine("=== Cilindros: {0}, HP: {1}", cilindros, hp);
        }
    }
}
