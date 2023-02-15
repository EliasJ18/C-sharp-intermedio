using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_02_IEnumerable__IEnumerator_y_for_each
{
    internal interface IAutomovil
    {
        // Calcular el impuesto
        void CalcularTenencia(double imp);
        // Mostrar informacion
        void MuestraInformacion();
    }
}
