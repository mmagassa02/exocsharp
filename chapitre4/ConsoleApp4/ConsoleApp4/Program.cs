using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> facteurs = new List<int>();// Liste qui contiendra les différents facteurs à multiplier
            string reponse = "ok", answer;
            int nbfacteurs = 0, result = 1, saisie;
            bool success;

            while (reponse == "ok")
            {
                question:
                Console.WriteLine("Veuillez saisir un nombre que vous voulez multiplier ou stop pour arreter).");
                answer = Console.ReadLine();
                // On vérifie dans un premier temps que l'utilisateur a saisi un entier
                success = int.TryParse(answer, out saisie); 
                if(success == true)
                {
                    facteurs.Add(saisie);
                    nbfacteurs++;
                }
                else if (answer == "stop") //Si l'utilisateur n'a pas saisi d'entier, on verifie s'il a saisi "stop"
                {
                    reponse = answer;
                    break;
                }else
                {
                    Console.WriteLine("Vous n'avez pas saisi de nombre...");
                    goto question;
                }
            }
            //Affichage du résultat
            if (nbfacteurs == 0)
                Console.WriteLine("Vous n'avez rien entré...");
            else
            {
                //L'utilisateur a saisi au minimum une valeur à multiplier.
                Console.Write("\nListe des nombres à multiplier : ");
                for (int i = 0; i < facteurs.Count; i++)
                {
                    Console.Write(facteurs[i] + " ");
                    result = result * facteurs[i];
                }
                Console.WriteLine("\nLe résultat de la multiplication est: " + result);
            }
        }
    }
}
