using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresRelacionales
{
    internal class Program
        //Devuelve como resultado un dato de tipo bool
    {
        static void Main(string[] args)
        {
            bool c1 = 20 > 90; 
            bool c2 = 0.85 < 1.25; 
            bool c3 = 88 != 77; 
            bool c4 = 25.3 != 25.3; 
            bool c5 = 85 >= 85.001; 
            bool c6 = 47.96 <= 36.96;

            Console.WriteLine("Los resultado son: ");
            Console.WriteLine($"20 > 90 es: ------->|{c1}");
            Console.WriteLine($"0.85 < 1.25 es ---->|{c2}");
            Console.WriteLine($"88 != 77 es ------->|{c3}");
            Console.WriteLine($"25.3 != 25.3 es --->|{c4}");
            Console.WriteLine($"85 >= 88.001 es --->|{c5}");
            Console.WriteLine($"47.96 <= 36.96 ---->|{c6}");

            Console.ReadKey();
        }
    }
}