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
                    long resultat = 1;
                    for (int k = 1; k <= nombre; k++)
                        resultat *= k;
                    Console.WriteLine(nombre + "! = " + resultat);
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
                        long resultat = 1;
                        for (int k = (total - nombre + 1); k <= total; k++)
                            resultat *= k;
                        Console.WriteLine("A(" + total + "/" + nombre + ") = " + resultat);
                    }
                    else
                    {
                        // Saisie du nombre correspondant au nombre d'éléments à gerer
                        Console.Write("nombre total d'éléments à gérer = ");
                        int total = int.Parse(Console.ReadLine());
                        // Saisie du nombre correspondant au sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int nombre = int.Parse(Console.ReadLine());
                        // Calcul du résultat 1
                        long resultat1 = 1;
                        for (int k = (total - nombre + 1); k <= total; k++)
                            resultat1 *= k;
                        // Calcul du résultat 1
                        long resultat2 = 1;
                        for (int k = 1; k <= nombre; k++)
                            resultat2 *= k;
                        Console.WriteLine("C(" + total + "/" + nombre + ") = " + (resultat1 / resultat2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
