using System;

namespace POO_EJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche cocheUno = new Coche(1, "Fiat", "Cronos", 0, 2000, true);
            Moto motoUno = new Moto(2, "Honda", "Twister", 0, 800, true);
            Console.WriteLine(cocheUno.getPrecio());
            Console.WriteLine(motoUno.getPrecio());
        }
    }
    public class Vehiculo
    {
        private int ID;
        private string Marca;
        private string Modelo;
        private int KM;
        private double Precio;

        public Vehiculo(int ID, string Marca, string Modelo, int KM, double Precio)
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
    class Coche: Vehiculo{
        private bool airbag;
        public Coche(int ID, string Marca, string Modelo, int KM, double Precio, bool airbag) : base(ID, Marca, Modelo, KM, Precio){
            this.airbag = airbag;
            if(this.airbag){
                double nuevoPrecio = this.getPrecio() + 200;
                this.setPrecio(nuevoPrecio);
            }
        }
    }
        class Moto: Vehiculo{
        private bool sidecar;
        public Moto(int ID, string Marca, string Modelo, int KM, double Precio, bool sidecar) : base(ID, Marca, Modelo, KM, Precio){
            this.sidecar = sidecar;
            if(this.sidecar){
                double nuevoPrecio = this.getPrecio() + 50;
                this.setPrecio(nuevoPrecio);
            }
        }
    }
}