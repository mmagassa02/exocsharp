using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liste avec des nombres prédéfinis
            List<int> numbers = new List<int> { 12, 24, 36, 48, 60, 72, 84};
            int result = 0;
            //Somme des éléments de la liste
            for (int i = 0; i< numbers.Count; i++)
            {
                Console.WriteLine(result+ " + " +numbers[i]+ " = " +(result + numbers[i]));
                result = result + numbers[i];
            }
            // Affichage du résultat final
            Console.WriteLine("Le résultat final :" +result);
        }
    }
}
