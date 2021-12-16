using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int level; // Pour récupérer le niveau de la tornade
            bool verif;
            // Tableau à 2 dimension: on associe le niveau de la tornade à ses caractéristiques.
            string[,] fujita = new string[6, 2]
            {
                {"F0", "Dégâts légers : certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres." },
                {"F1", "Dégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés."},
                {"F2", "Dégâts importants : les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées." },
                {"F3", "Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts| importants, les forêts et les récoltes sont abattues." },
                {"F4", "Dégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent ; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances." },
                {"F5", "Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits (parfois surnommé « le doigt de Dieu »."},
            };

            question:
            Console.WriteLine("Veuillez saisir le type de tornade (Entre 0 et 5)");
            verif = int.TryParse(Console.ReadLine(), out level);
            if(verif == true)
            {
                //Affichage des détails de la tornade selon son niveau
                if(level >= 0 && level <= 5 )
                    Console.WriteLine("Niveau de la tornade: " + fujita[level, 0] +"\n"+ fujita[level, 1]);
                else
                {
                    Console.WriteLine("Vous devez saisir un nombre compris entre 0 et 5");
                    goto question;
                }
            }
            else
            {
                Console.WriteLine("Mauvaise saisie");
                goto question;
            }


            



        }
    }
}
