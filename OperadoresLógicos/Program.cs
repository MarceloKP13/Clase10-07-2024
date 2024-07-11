using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLógicos
{
    internal class Program
    {
        /*&& las 2 condiciones deben ser verdadero para que me de el resultado true,
         * || basta con que una condición sea verdader para que me de resultado true
         * ! invierte el resultado, si es true a false y viceversa.
         */
        static void Main(string[] args)
        {
            bool c1 = 8 < 16;
            bool c2 = 16 < 32;

            bool ol1 = 8 < 16 && 16 < 32;
            bool ol2 = 20 > 6 || 20 < 6;
            bool ol3 = !ol1;

            Console.WriteLine($"Los valores lógicos son: ");
            Console.WriteLine($"8 < 16 es                       |{c1}|\n" +
                                $"16 < 32 también es              |{c2}|\n" +
                                $"por el operador && el valor es: |{ol1}|");

            Console.ReadKey();
        }
    }
}
