using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = "Monsieur", prenom = "Vincent";
            int nb = 1;
            // Affichage avec des "+" pour la concaténation.
            Console.WriteLine("Bonjour " + gender + " " + prenom + ", vous êtes venu nous rendre visite " + nb + " fois");
        }
    }
}
