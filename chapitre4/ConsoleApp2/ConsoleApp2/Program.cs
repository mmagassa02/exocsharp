using System;
using System.Collections.Generic; // A mettre pour pouvoir utiliser les listes.

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration d'une liste
            List <string> languages = new List<string> {"HTML", "CSS", "Javacrit", "jQuery", "PHP", "Bootstrap", "Java" };

            //On affiche la totalité de la liste grâce à une boucle
            for (int name = 0; name < languages.Count; name++) 
            {
                Console.WriteLine(languages[name]);
             }

            Console.WriteLine();

            Console.WriteLine(languages[3]);
            Console.WriteLine(languages[4]);
            
            //Suppression d'une valeur dans la liste (.Remove())
            languages.Remove("Bootstrap");
            //Modification d'une valeur dans la liste
            languages[2] = "Javascript";
            //Ajout d'une valeur supplémentaire dans la liste (.Add() ).
            languages.Add("C");
            // On réaffiche la liste modifiée
            Console.WriteLine();
            foreach (string name in languages)
            {
                Console.WriteLine(name);
            }
        }
    }
}
