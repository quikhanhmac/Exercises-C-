using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGCD
{
    class PGCD
    {
         public static void calculPGCD()
            {
                Console.WriteLine("Entrer valeur pour p");
                string rep1 = Console.ReadLine();
                Console.WriteLine("Entrer valeur pour q");
                string rep2 = Console.ReadLine();
                int p = int.Parse(rep1);
                int q = int.Parse(rep2);
                while (p != q)
                {
                if (p > q)
                {
                    p = p - q;
                }
                else
                {
                    q = q - p;
                }
                }
                Console.WriteLine("le PGCD vaut {0}", p);
            }
    }
}
