using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string mois;
            Console.WriteLine("Entrer un mois");
            mois = Console.ReadLine();
            if (mois == "decembre" ^ mois == "janvier" ^ mois == "fevrier")
                Console.WriteLine("La saison du mois saisi est l'HIVER.");
            else if (mois == "mars" ^ mois == "avril" ^ mois == "mai")
                Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
            else if (mois == "juin" ^ mois == "juillet" ^ mois == "aout")
                Console.WriteLine("La saison du mois saisi est l'ÉTÉ.");
            else if (mois == "septembre" ^ mois == "octobre" ^ mois == "novembre")
                Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
            else
                Console.WriteLine("Mauvaise saisie");

        }
    }
}
