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
            foreach (int number in numbers)
            {
              //  Console.Write($"{number} ");
                result += number;
            }
            // Affichage du résultat final
            Console.WriteLine("\nLe résultat final de l'opération " +String.Join(" + ", numbers)+ " = "+result);
        }
    }
}
