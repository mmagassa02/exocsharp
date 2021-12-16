using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastname, firstname;
            int year;
            Console.WriteLine("Veuillez saisir votre nom");
            lastname = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre prénom");
            firstname = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre année de naissance");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Fiche de renseignement\n\nNom : " + lastname + "\n\nPrénom : " + firstname + "\n\nAge : " + (DateTime.Now.Year - year));
        }
    }
}
