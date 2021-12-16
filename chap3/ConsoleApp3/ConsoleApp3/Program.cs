using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            string saisie = "oui";
            //Tant que l'utilisateur souhaite ajouter des nombres a additionner
            while (saisie == "oui")
            {
                Console.WriteLine("Entrer un nombre a additionner");
                result = result + int.Parse(Console.ReadLine());
                //Pour revenir à ce point si l'utilisateur ne saisit pas oui ou non à la question suivante.
                question:
                Console.WriteLine("Voulez vous ajouter un nombre? (Taper oui ou non)");
                saisie = Console.ReadLine();
                //L'utilisateur tape non pour ne pas ajouter de nombres à l'addition.
                if (saisie == "non")
                    break;
                else if (saisie != "oui")
                    goto question;  //On retourne à la ligne 17 plus haut pour reposer la question.

            }
            Console.WriteLine(result);
        }
    }
}
