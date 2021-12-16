using System;

namespace ConsoleApp6
{
    class Program
    {
        //Création de l'enum Week
        enum Week
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
            // Affichage des éléments de Week
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine(Enum.GetName(typeof(Week), i));
            }

            // Affichage de la valeur 4 de l'enumeration Week
            Console.WriteLine();
            Console.WriteLine(Enum.GetName(typeof(Week), 4));
        }
    }
}
