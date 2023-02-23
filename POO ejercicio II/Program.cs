using System;
namespace Poo_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche cocheUno = new Coche(1, "Volkswagen", "Suran", 80000, 3900000);
            Coche cocheDos = new Coche(2, "Fiat", "Palio", 130000, 2500000);
            Coche cocheTres = new Coche(3, "Chevrolet", "Cobalt", 160000, 3100000);
            Concesionario autitosUsados = new Concesionario(5);
            autitosUsados.addCar(cocheUno);
            autitosUsados.addCar(cocheDos);
            autitosUsados.addCar(cocheTres);
            autitosUsados.mostrarCoches();
            autitosUsados.deleteCoche(2);
            autitosUsados.mostrarCoches();
            autitosUsados.vaciarCoches();
            autitosUsados.mostrarCoches();
        }
        public class Concesionario
        {
            private Coche[] coches;
            private int limite;
            private int cantidadCoches;

            public Concesionario(int limite)
            {
                this.coches = new Coche[limite];
                this.limite = limite;
                this.cantidadCoches = 0;
            }
            public void addCar(Coche coche)
            {
                int index = Array.IndexOf(this.coches, null);
                if (index != -1)
                {
                    this.coches[index] = coche;
                    this.cantidadCoches++;
                }
            }
            public Coche[] mostrarCoches()
            {
                foreach (Coche element in this.coches) Console.Write($"{element.getID()} {element.getMarca()} {element.getModelo()}");
                return this.coches;
            }
            public void vaciarCoches()
            {
                this.coches = new Coche[limite];
                this.cantidadCoches = 0;
                Console.WriteLine("Coches eliminados");
            }
            public void deleteCoche(int ID)
            {
                if (cantidadCoches != 0)
                {
                    for (int i = 0; i < this.cantidadCoches; i++)
                    {
                        if (this.coches[i].getID() == ID)
                        {
                            this.coches[i] = null;
                            this.cantidadCoches--;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No existe el coche en la lista");
                }
            }
        }
    }
    public class Coche
    {
        private int ID;
        private string Marca;
        private string Modelo;
        private int KM;
        private double Precio;

        public Coche(int ID, string Marca, string Modelo, int KM, double Precio)
        {
            this.ID = ID;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.KM = KM;
            this.Precio = Precio;
        }

        public int getID()
        {
            return this.ID;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        public string getMarca()
        {
            return this.Marca;
        }
        public void setMarca(string Marca)
        {
            this.Marca = Marca;
        }
        public string getModelo()
        {
            return this.Modelo;
        }
        public void setModelo(string Modelo)
        {
            this.Modelo = Modelo;
        }
        public int getKM()
        {
            return this.KM;
        }
        public void setKM(int KM)
        {
            this.KM = KM;
        }
        public double getPrecio()
        {
            return this.Precio;
        }
        public void setPrecio(double Precio)
        {
            this.Precio = Precio;
        }
    }
}