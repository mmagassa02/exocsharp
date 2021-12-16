using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Quel âge avez-vous?\n");
            age = int.Parse(Console.ReadLine());
            if (age >= 18)
                Console.Write("Vous avez " + age + ", vous êtes donc majeur.e\n");
            else
                Console.Write("Vous avez " + age + ", vous êtes donc mineur.e\n");
        }
    }
}
