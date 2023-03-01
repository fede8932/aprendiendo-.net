namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresá el dividendo");
            int numeroUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresá el divisor");
            int numeroDos = Convert.ToInt32(Console.ReadLine());
            int division,
                resto;
            if (numeroUno != 0 && numeroDos != 0)
            {
                division = numeroUno / numeroDos;
                resto = numeroUno % numeroDos;
                Console.WriteLine($"El resultado de la div es {division} y el resto es {resto}");
            }
            else if (numeroUno == 0)
            {
                System.Console.WriteLine("Programa finalizado");
            }
            else
            {
                System.Console.WriteLine("No se puede dividir por 0");
            }
        }
    }
}

/*Escriba un programa en C# que solicite al usuario dos números y muestre la división y el resto de la división. Avisará si se ingresa 0 como segundo número y finalizará si se ingresa 0 como primer número.*/
