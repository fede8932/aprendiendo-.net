using System;

namespace POO_EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ordenador pcUno = new Ordenador(0);
            Ordenador pcDos = new Ordenador(400);
            Console.WriteLine($"capacidad disponible pcUno: {pcUno.getEspacioDisponible()}GB");
            Console.WriteLine($"capacidad disponible pcDos: {pcDos.getEspacioDisponible()}GB");
            pcUno.addData(25);
            pcDos.deleteData(25);
            pcUno.apagar();
            pcUno.encender();
            pcUno.encender();
            pcUno.addData(25);
            Console.WriteLine($"capacidad disponible pcUno: {pcUno.getEspacioDisponible()}GB");
            pcUno.deleteData(2);
            Console.WriteLine($"capacidad disponible pcUno: {pcUno.getEspacioDisponible()}GB");
            pcUno.deleteData(25);
            Console.WriteLine($"capacidad disponible pcUno: {pcUno.getEspacioDisponible()}GB");
        }
    }
    public class Ordenador
    {
        private int capacidad;
        private int capacidadMaxima;
        private bool encendido;
        private const int TAMAÑO_DEFECTO = 100;

        public Ordenador(int capacidadMaxima)
        {
            this.encendido = false;
            this.capacidad = 0;

            if (capacidadMaxima <= 0)
            {
                this.capacidadMaxima = TAMAÑO_DEFECTO;
            }
            else
            {
                this.capacidadMaxima = capacidadMaxima;
            }
        }
        public void encender()
        {
            if (this.encendido)
            {
                Console.WriteLine("El ordenador ya esta funcionando, no hace falta encenderlo");
            }
            else
            {
                this.encendido = true;
                Console.WriteLine("Encendiste el ordenador");
            }
        }
        public void apagar()
        {
            if (!this.encendido)
            {
                Console.WriteLine("El ordenador no esta funcionando, no hace falta apagarlo");
            }
            else
            {
                this.encendido = false;
                Console.WriteLine("Apagaste el ordenador");
            }
        }
        public void addData(int tamañoNuevoFichero)
        {
            if (this.encendido)
            {
                int ocupado = this.capacidad + tamañoNuevoFichero;
                if (ocupado <= capacidadMaxima)
                {
                    this.capacidad = ocupado;
                    Console.WriteLine($"espacio ocupado: {this.capacidad}");
                }
                else
                {
                    Console.WriteLine("El tamaño del fichero es demasiado grande para guardarlo, libere espació en el ordenador");
                }
            }
            else { Console.WriteLine("El ordenador está apagado"); }
        }
        public void deleteData(int tamañoFichero)
        {
            if (this.encendido)
            {
                int ocupado = this.capacidad - tamañoFichero;
                if (ocupado <= 0)
                {
                    this.capacidad = 0;
                }
                else
                {
                    this.capacidad = ocupado;
                }

                Console.WriteLine($"espacio ocupado: {this.capacidad}");
            }
            else { Console.WriteLine("El ordenador está apagado"); }
        }
        public int getEspacioDisponible()
        {
            return this.capacidadMaxima - this.capacidad;
        }
    }
}