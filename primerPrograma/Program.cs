using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero:");
            int primerNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro numero:");
            int segundoNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: "+ (primerNumero + segundoNumero));
        }
    }
}