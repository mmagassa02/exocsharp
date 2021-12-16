using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string gender;
            Console.WriteLine("Quel âge avez-vous?\n");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Quel est votre sexe? (F ou M)\n");
            gender = Console.ReadLine();
            //Personne majeure
            if (age >= 18)
            {
                if (gender == "M")
                    Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
                else if (gender == "F")
                    Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
            }
            else
            {// Personne mineure
                if (gender == "M")
                    Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
                else if (gender == "F")
                    Console.WriteLine("Vous êtes une femme et vous êtes mineure.");
            }
        }
    }
}
