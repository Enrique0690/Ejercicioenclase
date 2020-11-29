using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicioenclase.Clases
{
    class Factorial
    {
        public static string Factoriales(int calcular)
        {
            int i;
            double result = 1;
            string aux;
            for (i = 1; i <= calcular; i++)
            {
                result = result * i;
            }
            aux = result + Environment.NewLine;
            return aux;
        }
    }
}
