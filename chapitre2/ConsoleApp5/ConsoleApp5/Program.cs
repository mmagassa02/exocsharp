using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string month;
            Console.WriteLine("Entrer un month");
            month = Console.ReadLine();
            if (month == "decembre" ^ month == "janvier" ^ month == "fevrier")
                Console.WriteLine("La saison du month saisi est l'HIVER.");
            else if (month == "mars" ^ month == "avril" ^ month == "mai")
                Console.WriteLine("La saison du month saisi est le PRINTEMPS.");
            else if (month == "juin" ^ month == "juillet" ^ month == "aout")
                Console.WriteLine("La saison du month saisi est l'ÉTÉ.");
            else if (month == "septembre" ^ month == "octobre" ^ month == "novembre")
                Console.WriteLine("La saison du month saisi est l'AUTOMNE.");
            else
                Console.WriteLine("Mauvaise saisie");

        }
    }
}
