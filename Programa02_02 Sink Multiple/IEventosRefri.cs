using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_02_Sink_Multiple
{
    internal interface IEventosRefri
    {
        // Aquí definimos los eventos que tendrá el refri
        void EReservasBajas(int pKilos);

        // Adicionamos otro evento para cuando el refri se descongela
        void EDescongelado(int pGrados);
    }
}
