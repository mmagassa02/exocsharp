using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom, prenom;
            Console.WriteLine("Saisir votre nom");
            nom = Console.ReadLine();
            Console.WriteLine("Saisir votre prénom");
            prenom = Console.ReadLine();
            Console.WriteLine("Bonjour " + nom + " " + prenom + ", nous sommes le mardi 14 décembre, comment allez-vous?");
        }
    }
}
