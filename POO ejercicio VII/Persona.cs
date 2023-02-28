namespace POO_EJ7
{
    class Persona
    {
        private int edad;
        public int getEdad()
        {
            System.Console.WriteLine(this.edad);
            return this.edad;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public string saludar(){
            System.Console.WriteLine("Hola !!");
            return "Hola!!";
        }
    }
}