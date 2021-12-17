using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            string saisie = "ok";
            //Tant que l'utilisateur souhaite ajouter des nombres a additionner
            while (saisie == "ok")
            {
                Console.WriteLine("Entrer un nombre à additionner");
                result = result + int.Parse(Console.ReadLine());
                //Pour revenir à ce point si l'utilisateur ne saisit pas ok ou non à la question suivante.
                question:
                Console.WriteLine("Voulez vous ajouter un nombre? (Taper ok ou non)");
                saisie = Console.ReadLine();
                //L'utilisateur tape non pour ne pas ajouter de nombres à l'addition.
                if (saisie == "non")
                    break;
                else if (saisie != "ok")
                    goto question;  //On retourne à la ligne 17 plus haut pour reposer la question.

            }
            Console.WriteLine(result);
        }
    }
}
