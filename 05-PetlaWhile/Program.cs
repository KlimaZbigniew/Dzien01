using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PetlaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int licznik = -10;

            while (licznik >0)
            {
                Console.WriteLine("Licznik: " + licznik);
                licznik--;
            }

            licznik = -10;
            do
            {
                Console.WriteLine("Licznik2: " + licznik);
                licznik--;

            } while (licznik > 0);


            while (true)
            {
                Console.Write("Podaj większa od 100 i podzielna przez 2: ");
                int liczba = Convert.ToInt32(Console.ReadLine());

                if (liczba > 100 && liczba % 2 == 0)
                    break;
            }

            Console.ReadKey();
        }
    }
}
