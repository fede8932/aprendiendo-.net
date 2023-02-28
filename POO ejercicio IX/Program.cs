namespace POO_EJ9
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(0);
            coche1.Conducir();
            coche1.Repostar(25);
            coche1.Conducir();
        }
    }
    interface IVehiculo
    {
        void Conducir();
        bool Repostar(int cantidadGasolina);
    }
    public class Coche : IVehiculo
    {
        private int cantidadGasolina;
        public Coche(int cantGasolinaInicial)
        {
            this.cantidadGasolina = cantGasolinaInicial;
        }
        public void Conducir()
        {
            if (this.cantidadGasolina > 0)
            {
                Console.WriteLine("Conduciendo");
            }
            else
            {
                Console.WriteLine("Sin gasolina");
            }
        }
        public bool Repostar(int cantidadGasolina)
        {
            this.cantidadGasolina = +cantidadGasolina;
            return true;
        }
    }
}


/*Crea un programa en C# que implemente una interfaz IVehiculo con dos métodos, uno para Conducir de tipo void y otro para Repostar de tipo bool que tenga un parámetro de tipo entero con la cantidad de gasolina a repostar. Después cree una clase Coche con un constructor que reciba un parámetro con la cantidad de gasolina inicial del coche y implemente los métodos de Conducir y Repostar el coche.

El método Conducir imprimirá en pantalla que el coche está Conduciendo, si la gasolina es mayor a 0. El método Repostar aumentará la gasolina del coche y retornará´verdadero.

Para realizar las pruebas cree un objeto de tipo Coche con 0 de gasolina en el Main del programa y solicite al usuario una cantidad de gasolina para repostar, por último ejecute el método Conducir del coche.*/