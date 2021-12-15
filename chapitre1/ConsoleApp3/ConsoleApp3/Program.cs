using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a += 33;
            b++;
            Console.WriteLine(a + " divisé par " + b + " = " + a / b);
        }
    }
}
