using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_konwersjaTypow
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmienna1 = 10;
            byte zmienna2 = 5;

            zmienna1 = zmienna2;

            zmienna2 = (byte)zmienna1;
            Console.WriteLine("Zmienna 1: " + zmienna1 + ", Zmienna 2: " + zmienna2);            
            

            zmienna1 = 257;
            zmienna2 = (byte)zmienna1;

            Console.WriteLine("Zmienna 1: " + zmienna1 + ", Zmienna 2: " + zmienna2);

            double wartosc1 = -17871.82;
            Console.WriteLine("double wartosc1 = -17871.82;: " + wartosc1);

            int wartosc2 = (int)wartosc1;
            Console.WriteLine("Wartość 2: " + wartosc2);

            //Użycie metod klas convert

            wartosc2 = Convert.ToInt32("123");
            Console.WriteLine("Konwertowanie stringa 123 na wartość 2: " + wartosc2);

            wartosc1 = Convert.ToDouble("122,898");
            Console.WriteLine("wartosc1 = Convert.ToDouble(\"122,898\");: " + wartosc1);

            wartosc2 = 10;
            Console.WriteLine("Convert.ToBoolean(wartosc2) " + wartosc2 + " - po konwersji: "+  Convert.ToBoolean(wartosc2));

            wartosc2 = 0;
            Console.WriteLine("Convert.ToBoolean(wartosc2) " + wartosc2 + " - po konwersji: " + Convert.ToBoolean(wartosc2));

            wartosc2 = -10;
            Console.WriteLine("Convert.ToBoolean(wartosc2) " + wartosc2 + " - po konwersji: " + Convert.ToBoolean(wartosc2));

            wartosc2 = 1;
            Console.WriteLine("Convert.ToBoolean(wartosc2) " + wartosc2 + " - po konwersji: " + Convert.ToBoolean(wartosc2));

            Console.ReadKey();
        }
    }
}
