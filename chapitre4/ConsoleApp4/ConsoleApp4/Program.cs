using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> facteurs = new List<int>(); // Liste qui contiendra les différents facteurs à multiplier
            string answer;
            int nbfacteurs = 0, result = 1, saisie;
            bool success = true; // Tant que success vaut true l'utilisateur n'a pas saisie stop


            while (success)
            {
                Console.WriteLine("Veuillez saisir un nombre que vous voulez multiplier ou stop pour arreter).");
                answer = Console.ReadLine();
                try
                {
                    //Ajout des saisies dans la liste et incrémentation du nombre de facteurs
                    saisie = int.Parse(answer);
                    facteurs.Add(saisie);
                    nbfacteurs++;
                }
                catch (Exception)
                {
                    if (answer == "stop")
                    {
                        success = false;
                    }
                    else
                    {
                        Console.WriteLine("Mauvaise saisie");
                    }

                }
            }
            //Si l'utilisateur n'a rien saisi
            if (nbfacteurs == 0)
                Console.WriteLine("Vous n'avez rien entré...");
            else
            {

                // foreach pour calculer le produit
                foreach (int number in facteurs)
                {
                    result *= number;
                }

                //Affichage du résultat
                Console.WriteLine("\nLe résultat de la multiplication  " + String.Join(" x ", facteurs) + " = " + result);
            }
        }
    }
}
