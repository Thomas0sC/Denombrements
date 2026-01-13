using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// fonction permettant la multiplication d'une suite d'entiers d'une valeur à une autre
        /// </summary>
        /// <param name="compteurBoucle"></param>
        /// <param name="total"></param>
        /// <returns>Le résultat</returns>
        static long multiplication(int compteurBoucle, int total)
        {
            long resultat = 1;
            for (int k = compteurBoucle; k <= total; k++)
                resultat *= k;
            return resultat;
        }
        /// <summary>
        /// Module principal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int choix = 1;
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                if (choix == 0) { Environment.Exit(0); }

                if (choix == 1)
                {
                    // Saisie du nombre correspondant au nombre d'éléments à gerer
                    Console.Write("nombre total d'éléments à gérer = ");
                    int nombre = int.Parse(Console.ReadLine());
                    // Calcul du résultat
                    Console.WriteLine(nombre + "! = " + multiplication(1, nombre));
                }
                else
                {
                    if (choix == 2)
                    {
                        // Saisie du nombre correspondant au nombre d'éléments à gerer
                        Console.Write("nombre total d'éléments à gérer = ");
                        int total = int.Parse(Console.ReadLine());
                        // Saisie du nombre correspondant au sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int nombre = int.Parse(Console.ReadLine());
                        // Calcul du résultat
                        Console.WriteLine("A(" + total + "/" + nombre + ") = " + multiplication((total - nombre + 1), total));
                    }
                    else
                    {
                        // Saisie du nombre correspondant au nombre d'éléments à gerer
                        Console.Write("nombre total d'éléments à gérer = ");
                        int total = int.Parse(Console.ReadLine());
                        // Saisie du nombre correspondant au sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int nombre = int.Parse(Console.ReadLine());
                        // Calcul du résultat
                        Console.WriteLine("C(" + total + "/" + nombre + ") = " + (multiplication((total - nombre + 1), total) / multiplication(1, nombre)));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
