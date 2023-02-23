using System;

namespace POO_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(1, "VolksWagen", "Suran", 8080, 28000000);
            Console.WriteLine(coche1);
            coche1.setMarca("Fiat");
            Console.WriteLine(coche1.getMarca());
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
        // Otra sintaxis....
        public string modelo { get => Modelo; set => Modelo = value; }
        public int km { get => KM; set => KM = value; }
        public double precio { get => Precio; set => Precio = value; }
    }
}
