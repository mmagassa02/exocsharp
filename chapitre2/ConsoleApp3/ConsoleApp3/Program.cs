using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string sexe;
            Console.WriteLine("Quel age avez vous?\n");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Quel est votre sexe? (Saisir F ou M)\n");
            sexe = Console.ReadLine();
            if (age >= 18)
            {
                if (sexe == "M")
                    Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
                else if (sexe == "F")
                    Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
            }
            else
            {
                if (sexe == "M")
                    Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
                else if (sexe == "F")
                    Console.WriteLine("Vous êtes une femme et vous êtes mineure.");
            }
        }
    }
}
