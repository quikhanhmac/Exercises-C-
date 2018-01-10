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
            Console.WriteLine("Avant trier");
            int[] tabEntiers = new int[] { 45, 32, 15, -1, -8 };
            TriTableau.AfficherTableau(tabEntiers);

            Console.WriteLine("Apres trier");

            TriTableau.TrierTableau(tabEntiers);
            for (int i =0;i<tabEntiers.Length;i++)
                Console.WriteLine(tabEntiers[i]);
            Console.ReadKey();

            string[] tabChaine = new string[] {"jaun","vert","rouge","blanc","bleu" };
            TriTableau.TrierChaine(tabChaine);
            for (int i = 0; i < tabChaine.Length; i++)
                Console.WriteLine(tabChaine);
            Console.ReadKey();

        }
    }
}
