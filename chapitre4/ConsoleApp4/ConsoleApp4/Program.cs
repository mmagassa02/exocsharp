using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liste qui contiendra les différents facteurs à multiplier
            List<int> facteurs = new List<int>();
            string reponse = "ok";
            int resultat = 1; 
            string saisie;  // Variable servant a la conversion
            while(reponse == "ok")
            {
                Console.WriteLine("Saisir un nombre que vous voulez multiplier ou taper stop");
                saisie = Console.ReadLine();
                if (saisie == "stop")
                {
                    reponse = saisie;
                    break;
                }
                else
                {
                    facteurs.Add(int.Parse(saisie));
                }

            }

            // Multiplication
            Console.WriteLine("Liste des nombres a multiplier : ");
            for (int i = 0; i < facteurs.Count; i++)
            {
                Console.Write(facteurs[i] + " ");
                resultat = resultat * facteurs[i];
            }

            //Affichage du résultat
            Console.WriteLine("\nLe résultat de la multiplication est: " + resultat);

        }
    }
}
