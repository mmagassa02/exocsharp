using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int nbMessage = 0;nbMessage< 10; nbMessage++)
                Console.WriteLine($"Bonjour, je suis le message n°{nbMessage+1}");
        }
    }
}
