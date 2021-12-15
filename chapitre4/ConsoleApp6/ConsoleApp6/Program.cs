using System;

namespace ConsoleApp6
{
    class Program
    {
        //Création de l'enum week
        enum week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche,
        }
        static void Main(string[] args)
        {
            // Affichage des éléments de week
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine(Enum.GetName(typeof(week), i));
            }

            // Affichage de la valeur 4 de l'enumeration week
            Console.WriteLine();
            Console.WriteLine(Enum.GetName(typeof(week), 4));
        }
    }
}
