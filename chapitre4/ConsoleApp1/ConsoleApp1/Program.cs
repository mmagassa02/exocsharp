using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[7];
            week[0] = "Lundi";
            week[1] = "Mardi";
            week[2] = "Mercredi";
            week[3] = "Jedi";
            week[4] = "Vendredi";
            week[5] = "Samedi";
            week[6] = "Dimanche";
            Console.WriteLine(week[1]+ "\n"+week[4]);
            Console.WriteLine(week[0] + "\n" + week[3]);
            //Tableau corrigé
            week[3] = "Jeudi";
            Console.WriteLine("\n");
            Console.WriteLine(week[3]);
            Console.WriteLine("\n");
            for (int i = 0; i < 7; i++)
                Console.WriteLine(week[i]);

        }
    }
}
