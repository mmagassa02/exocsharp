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
            int nbfacteurs = 0;
            string reponse = "ok";
            int result = 1; 
            string saisie;  // Variable servant à la conversion
            while(reponse == "ok")
            {
                Console.WriteLine("Veuillez saisir un nombre que vous voulez multiplier (taper stop pour arreter");
                saisie = Console.ReadLine();
                if (saisie == "stop")
                {
                    reponse = saisie;
                    break;
                }
                else
                {
                    facteurs.Add(int.Parse(saisie));
                    nbfacteurs++;
                }

            }
            //Affichage du résultat
            if(nbfacteurs == 0)
                Console.WriteLine("Vous n'avez rien entré...");
            else
            {
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
