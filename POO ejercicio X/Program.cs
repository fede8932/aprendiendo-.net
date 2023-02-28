using System;
public class ClaseAbstracta
{
    public static void Main(string[] args)
    {
        Perro perro = new Perro();
        perro.SetNombre(Console.ReadLine());
        Console.WriteLine(perro.GetNombre());
        perro.Comer();
    }
 
    public class Perro : Animal
    {
        public override void Comer()
        {
            Console.WriteLine("Comiendo");
        }
    }
 
    public abstract class Animal
    {
        private string? Nombre;
 
        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }
 
        public string? GetNombre()
        {
            return Nombre;
        }
 
        public abstract void Comer();
    }
}