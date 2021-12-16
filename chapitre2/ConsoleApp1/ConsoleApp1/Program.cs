using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rainy = true;
            if (!rainy)
                Console.Write("Bonjour, il ne pleut pas aujourd’hui, bonne journée.\n");
            else
                Console.Write("Bonjour, il pleut aujourd’hui, vous devriez prendre votre parapluie.\n");
        }
    }
}
