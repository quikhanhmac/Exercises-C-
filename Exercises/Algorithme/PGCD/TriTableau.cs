using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmes
{
    class TriTableau
    {
        public static void TrierTableau(int[] tab)
        {
            bool permut;
            do
            {
                permut = false;
                for (int i = 0; i < tab.Length-1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        permut = true;
                        var temp = tab[i + 1];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                    }
                }
            }
            while (permut);
            
        }
    }
}
