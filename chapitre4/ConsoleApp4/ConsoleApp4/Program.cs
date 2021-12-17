using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> facteurs = new List<int>();// Liste qui contiendra les différents facteurs à multiplier
            string  answer;
            int nbfacteurs = 0, result = 1, saisie;
            bool success = true;


            while (success)
            {
                Console.WriteLine("Veuillez saisir un nombre que vous voulez multiplier ou stop pour arreter).");
                answer = Console.ReadLine();
                try
                {

                    // On vérifie dans un premier temps que l'utilisateur a saisi un entier
                    saisie = int.Parse(answer);
                        facteurs.Add(saisie);
                        nbfacteurs++;
                }catch(Exception)
                {
                    if(answer == "stop")
                    {
                        success = false;
                    }
                    else
                    {
                        Console.WriteLine("Mauvaise saisie");
                    }
                    
                }
            }
            //Affichage du résultat
            if (nbfacteurs == 0)
                Console.WriteLine("Vous n'avez rien entré...");
            else
            {
                //L'utilisateur a saisi au minimum une valeur à multiplier.


                foreach(int number in facteurs)
                {
                    result *= number;
                }

                Console.WriteLine("\nLe résultat de la multiplication  " +String.Join(" x ", facteurs)+ " = " +result);
            }
        }
    }
}
