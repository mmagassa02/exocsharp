using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Quel age avez vous?\n");
            age = int.Parse(Console.ReadLine());
            if (age >= 18)
                Console.Write("Vous avez " + age + ", vous êtres donc majeur.e\n");
            else
                Console.Write("Vous avez " + age + ", vous êtres donc mineur.e\n");
        }
    }
}
