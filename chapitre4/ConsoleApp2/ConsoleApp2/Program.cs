using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> languages = new List<string> {"HTML", "CSS", "Javacrit", "jQuery", "PHP", "Bootstrap", "Java" };
            for (int i = 0; i < languages.Count; i++) 
            {
                Console.WriteLine(languages[i]);
             }
            Console.WriteLine();
            Console.WriteLine(languages[3]);
            Console.WriteLine(languages[4]);
            languages.Remove("Bootstrap");
            languages[2] = "Javascript";
            languages.Add("C");
            Console.WriteLine();
            for (int i = 0; i < languages.Count; i++)
            {
                Console.WriteLine(languages[i]);
            }
        }
    }
}
