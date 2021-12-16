using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            const string login = "mmagassa";
            const string password = "123456";
            Console.WriteLine("Veuillez saisir votre identifiant");
            string loginuser = Console.ReadLine();
            Console.WriteLine("Veuilez saisir votre mot de passe");
            string passworduser = Console.ReadLine();
            // On teste 2 variables avec un switch (les saisies de l'utilisateur).
            switch (loginuser, passworduser)
            {
                case (login, password):
                        Console.WriteLine("Bienvenue à la manu");
                    break;
                default:
                    Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
                    break;
            }
        }
    }
}
