using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_instrukcjaWarunkowa
{
    class Program
    {
        static void Main(string[] args)
        {
            ShitchCase();
            //Console.ReadKey();
            //return;

            Console.Write("Podaj wiek:");            
            int wiek = Convert.ToInt32(Console.ReadLine());
            Boolean czyObywatelPolski = true;
            Boolean czyKarany = false;
            /*
             * >= 35 to prezydent
             * >= 30 senator
             * >= 21 posel
             * >= 18 prawo glosu
             */
            if (wiek<=0)
            {
                Console.WriteLine("Podaj poprawny wiek!!!!!");
                Console.ReadKey();
                return;
            }

            if (czyObywatelPolski)
            {
                if (wiek >= 35 && !czyKarany)
                    Console.WriteLine("Możesz iść na prezydenta"); //Mozna głosować i iść do polityki 
                else if (wiek >= 30 && !czyKarany)
                    Console.WriteLine("Możesz iść na senatora");
                else if (wiek >= 21 && !czyKarany)
                    Console.WriteLine("Możesz iść na posłem");
                else if (wiek >= 18)
                    Console.WriteLine("Możesz głosować");
                else
                    Console.WriteLine("Nie możesz głosować");
            }
            else
                Console.WriteLine("Brak obywatelstwa");

            Console.ReadKey();
        }

        static void ShitchCase()
        {
            Console.Write("Podaj ocenę: ");
            int ocena = Convert.ToInt32(Console.ReadLine());

            switch (ocena)
            {
                case 1: 
                    Console.WriteLine( "niedostateczny!");
                    break;
                case 2:
                    Console.WriteLine("mierny!"); break;
                case 3:
                    Console.WriteLine("dostateczny."); break;
                default:
                    Console.WriteLine("Nie znam.");
                    break;
            }
        }

    }
}
