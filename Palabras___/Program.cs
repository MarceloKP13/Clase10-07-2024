using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palabras___
{
    internal class Program
    {
        //Son palabras propias del lenguaje que no se pueden utilizar para declarar variables
        //por ejemplo; if, else, while, for ,int, etc.
        static void Main(string[] args)
        {
            int num1 = 85;
            int num2 = 45;
            int numAux = 0;

            numAux = num1;
            num1 = num2;
            num2 = numAux;

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            Console.ReadKey();

        }
    }
}
