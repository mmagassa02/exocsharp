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
            int number = 0; //On initialise number à 0 pour entrer dans la boucle 
            bool verif;
            while (number != reponse)
            {
                question:
                Console.WriteLine("Veuillez saisir un entier entre 1 et 50");
                verif = int.TryParse(Console.ReadLine(), out number); // On vérifie que l'on entre bien un entier
                if (verif == true)
                {
                    if (number >= 0 && number <= 50)
                    {
                        nbTentatives++;
                        if (number == reponse) // Si l'utilisateur a saisi la bonne réponse
                        {
                            Console.WriteLine("Bravo vous avez trouvé !\nNombre de tentatives : " + nbTentatives);
                            break;
                        }
                        else if (number < reponse) // Chiffre trop petit
                        {
                            Console.WriteLine("c'est plus grand\nNombre de tentatives : " + nbTentatives);
                        }
                        else if (number > reponse) // Trop grand
                        {
                            Console.WriteLine("C'est plus petit\nNombre de tentatives :" + nbTentatives);
                        }
                    }
                    else
                        goto question;
                }
            }



        }
    }
}
