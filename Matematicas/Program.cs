using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematicas
{
    internal class Program
    {
        //Devuelve como resultado un dato de tipo; bute, int, shoit y long.
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            float numero2 = float.Parse(Console.ReadLine());

            float suma = numero1 + numero2;
            float resta = numero1 - numero2;
            float multi = numero1 * numero2;
            float divi = numero1 / numero2;
            float modulo = numero1 % numero2;

            Console.WriteLine("Resultados...\n");
            Console.WriteLine($"La suma total es: {suma}\n");
            Console.WriteLine($"La diferencia es: {resta}\n");
            Console.WriteLine($"El producto es: {multi}\n");
            Console.WriteLine($"El cociente es: {divi}\n");
            Console.WriteLine($"El residuo es: {modulo}");

            Console.ReadKey();
        }
    }
}
