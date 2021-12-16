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
                Console.WriteLine("Voulez vous ajouter un nombre? (Taper oui ou non)");
                saisie = Console.ReadLine();
                //L'utilisateur tape non pour ne pas ajouter de nombres à l'addition.
                if (saisie == "non")
                    break;

            }
            Console.WriteLine(result);
        }
    }
}
