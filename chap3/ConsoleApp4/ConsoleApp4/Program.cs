using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable de type Random pour génerer un chiffre aléatoire.
            Random rnd = new Random();
            int nbTentatives = 0;
            //Premier argument (1) pour commencer a 1 et 51 pour aller jusqu'a 51-1
            int reponse = rnd.Next(1, 51);
            int saisie = 0;
            while (saisie != reponse)
            {
                Console.WriteLine("Saisir un nombre entre 1 et 50");
                saisie = int.Parse(Console.ReadLine());
                if (saisie == reponse) // Si l'utilisateur a saisi la bonne réponse
                {
                    nbTentatives++;
                    Console.WriteLine("Bravo vous avez trouvé !\nNombre de tentatives: " + nbTentatives);
                    break;
                }
                else if (saisie < reponse) // Chiffre trop petit
                {
                    nbTentatives++;
                    Console.WriteLine("c'est plus grand\nNombre de tentatives: " + nbTentatives);
                }
                else if (saisie > reponse) // Trop grand
                {
                    nbTentatives++;
                    Console.WriteLine("C'est plus petit\nNombre de tentatives:" + nbTentatives);
                }
            }
        }
    }
}
