using System;

namespace Clase10_07_2024
{
    internal class Program
    {
        //Read.Line devuelve un string, hay que convertir a int con int.Parse().
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese una signo: ");
            char signo = (char)Console.Read();
            Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su estatura en cm: ");
            long estatura = long.Parse(Console.ReadLine());

            Console.WriteLine($"Eligió el número: {numero}");
            Console.WriteLine($"Un placer conocerte {nombre}");
            Console.WriteLine($"Parece que elegiste este: {signo}");
            Console.WriteLine($"Tienes {edad} años, ¡wow!");
            Console.WriteLine($"Mides {estatura} centimetros.");

            Console.ReadKey();
        }
    }
}
