using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PetlaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for ( i = 1; i <= 10; i++)
            {
                if (i == 5)
                    continue;

                Console.WriteLine("Licznik petli: " + i);
                if (i==8)
                   break;//Prezrwij pętlę
            }

            for ( i = 50; i >= -10; i-=2)
            {
                Console.WriteLine("Licznik petli: " + i);
            }

            string s = "Ala ma kota";

            for (int k = 0; k < s.Length; k++)
            {
                
                //Console.Write(s[k] + ",");
                Console.Write(s.Substring(k, 1) + ",");
            }
            
            Console.WriteLine();

            foreach (var item in s)
            {
                Console.Write(item + ",");
            }

            Console.ReadKey();
        }
    }
}
