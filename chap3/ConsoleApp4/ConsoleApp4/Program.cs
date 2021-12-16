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
            //.Nextc(1, 51) pour créer aléatoirement un nombre entre 1 et 51
            int reponse = rnd.Next(1, 51);
            int saisie =0;
            bool success;
            while (saisie != reponse)
            {
                Console.WriteLine("Saisir un entierentre 1 et 50");
                success = int.TryParse(Console.ReadLine(), out saisie);
                if (success == true)
                {
                    nbTentatives++;
                    if (saisie == reponse) // Si l'utilisateur a saisi la bonne réponse
                    {
                        Console.WriteLine("Bravo vous avez trouvé !\nNombre de tentatives : " + nbTentatives);
                        break;
                    }
                    else if (saisie < reponse) // Chiffre trop petit
                    {
                        Console.WriteLine("c'est plus grand\nNombre de tentatives : " + nbTentatives);
                    }
                    else if (saisie > reponse) // Trop grand
                    {
                        Console.WriteLine("C'est plus petit\nNombre de tentatives :" + nbTentatives);
                    }
                }
            }



        }
    }
}
