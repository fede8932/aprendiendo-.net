namespace POO_EJ7
{
    class Estudiante : Persona
    {
        public string estudiar()
        {
            System.Console.WriteLine("Estoy estudiando");
            return "Estoy estudiando!!";
        }
        public string verEdad(){
            System.Console.WriteLine($"Mi edad es {this.getEdad()} años");
            return $"Mi edad es {this.getEdad()} años";
        }
    }
}