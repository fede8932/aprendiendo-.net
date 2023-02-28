using System;

namespace POO_EJ7
{
    class EstudianteProfesorTest
    {
        static void Main(string[] args)
        {
            Persona Juan = new Persona();
            Juan.saludar();
            Estudiante Sofia = new Estudiante();
            Sofia.setEdad(29);
            Sofia.saludar();
            Sofia.getEdad();
            Sofia.estudiar();
            Profesor Graciela = new Profesor();
            Graciela.setEdad(65);
            Graciela.saludar();
            Graciela.getEdad();
            Graciela.explicar();
        }
    }
}