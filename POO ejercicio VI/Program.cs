﻿namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Persona[] personas = new Persona[total];
            for (int i = 0; i < total; i++)
            {
                string nombre = ConfirmarNombre.validateName();
                personas[i] = new Persona(nombre);
            }
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(personas[i].ToString());
            }
        }

    }
    class Persona
    {
        private string nombre;
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return $"Hola! Mi nombre es {this.nombre}";
        }
        ~Persona()
        {
            this.nombre = string.Empty;
        }

    }
    class ConfirmarNombre
    {
        static public string validateName()
        {
            string? name = null;
            while (name == null)
            {
                Console.WriteLine("Ingresa tu nombre");
                name = Console.ReadLine();
            }
            return name;
        }
    }
}