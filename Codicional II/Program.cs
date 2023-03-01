using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Login log = new Login();
            log.logearse();
        }
    }

    public class Login
    {
        private int user,
            pass;
        private int intentos = 0;

        public void logearse()
        {
            do
            {
                Console.WriteLine("Ingrese su usuario");
                string? usuario = Console.ReadLine();
                Console.WriteLine("Ingrese su password");
                string? contraseña = Console.ReadLine();
                if (usuario != null && contraseña != null)
                {
                    this.user = Convert.ToInt32(usuario);
                    this.pass = Convert.ToInt32(contraseña);
                }
                if (this.user != 12 || this.pass != 1234)
                {
                    Console.WriteLine("Error de inicio de sesiÃ³n");
                    intentos++;
                }
            } while (this.user != 12 || this.pass != 1234 && this.intentos >= 3);
            {
                if ((this.user == 12) || (this.pass == 1234))
                    Console.WriteLine("Inicio de sesiÃ³n correcto");
            }
        }
    }
}


/*Escriba un control de acceso en C# que solicite al usuario el nombre de usuario y la contraseña. Ambos deben ser números enteros y repetirlo hasta que el usuario sea 12 y la contraseña sea 1234 o hasta un máximo de 3 intentos.

Si el usuario y la contraseña son correctos muestra Inicio de sesión correcto, sino Error de inicio de sesión.*/
