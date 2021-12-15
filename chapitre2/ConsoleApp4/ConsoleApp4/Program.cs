using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, password;
            Console.WriteLine("Saisir identifiant");
            login = Console.ReadLine();
            Console.WriteLine("Saisir mot de passe");
            password = Console.ReadLine();
            switch (login)
            {
                case "mmagassa":
                    if (password == "123456")
                        Console.WriteLine("Bienvenue à la manu");
                    
                    else
                        Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
                    break;
                default:
                    Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
                    break;
            }
        }
    }
}
