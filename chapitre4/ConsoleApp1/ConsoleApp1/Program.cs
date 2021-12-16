using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Création d'un tableau Le nombre d'éléments du tableau est fixe (ici 7 élément ayant pour index 0 à 6.  
            string[] week = new string[7];
            week[0] = "Lundi";
            week[1] = "Mardi";
            week[2] = "Mercredi";
            week[3] = "Jedi";
            week[4] = "Vendredi";
            week[5] = "Samedi";
            week[6] = "Dimanche";

            //Affichage de valeurs
            Console.WriteLine(week[1]+ "\n"+week[4]);
            Console.WriteLine(week[0] + "\n" + week[3]);
            //Modification de "Jedi" par "Jeudi"
            week[3] = "Jeudi";
            Console.WriteLine("\n");
            Console.WriteLine(week[3]);
            Console.WriteLine("\n");
            //Affichage du tableau corrigé
            for (int i = 0; i < 7; i++)
                Console.WriteLine(week[i]);

        }
    }
}
