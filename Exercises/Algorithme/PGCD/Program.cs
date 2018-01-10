using Algorithmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            //PGCD.calculPGCD();

            int[] tabEntiers = new int[] {45,32,15,-1,-8 };
            TriTableau.TrierTableau(tabEntiers);
            for (int i =0;i<tabEntiers.Length;i++)
                Console.WriteLine(tabEntiers[i]);
        }
    }
}
