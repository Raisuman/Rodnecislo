using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace rodnécislo.Funkce
{
    internal class kontrola
    {
        public static void kontrolaRcislo(string[] x)
        {
            int sum = 0;
            int sum1 = 0;
            int[] y = new int[x[0].Length + x[1].Length];
            for (int i = 0; i < x[0].Length; i++)
            {
                y[i] = int.Parse(x[0].Substring(i, 1));
            }
            int index = 6;
            for (int z = 0; z < x[1].Length; z++)
            {
                y[index] = int.Parse(x[1].Substring(z, 1));
                index++;
            }

            for (int j = 0 ; j < 10; j++)
            {
                if ((j % 2) == 0)
                {
                    sum = y[j] + sum; 
                }
                else if ((j % 2) == 1)
                {
                    sum1 = y[j] + sum1;
                }
            }

            int vysledek = sum - sum1;
            if(vysledek > 0)
            {
               vysledek = vysledek * -1;
            }
            if ((vysledek == 0) || (vysledek == 11) || (vysledek == 22))
            {
                Console.WriteLine("Rodné číslo je platné");
            }
            else
            {
                Console.WriteLine("Rodné číslo je neplatné");
            }

        }
    }
}
