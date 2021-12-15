using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom, prenom;
            int annee;
            Console.WriteLine("Saisir votre nom");
            nom = Console.ReadLine();
            Console.WriteLine("Saisir votre prénom");
            prenom = Console.ReadLine();
            Console.WriteLine("Saisir votre année de naissance");
            annee = int.Parse(Console.ReadLine());
            Console.WriteLine("Fiche de renseignement\n\nNom: " + nom + "\n\nPrénom: " + prenom + "\n\nAge: " + (2021 - annee));
        }
    }
}
