using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmienna1 = -10;
            int a = 10, b = 20, c = 30;
            byte wiekUzytkownika = 29; //Komentarz :)
            /*
            camelCase
            */
            float cena = 123.45f;
            double zarobki = 123456.83;
            decimal dlugPubliczny = 8932475987329508732.748m;

            bool flaga = true;
            flaga = false;

            long x = 1234;
            Int64 x1 = 309;

            char znak = 'A';  znak = '\t';

            String imieNazwisko = "Jan Kowalski";
            imieNazwisko = null;
            imieNazwisko = "";

            const double pi = 3.14159;


            //pi = -3.14;
            StringExamples();
            Console.ReadKey();
           
        }

        static void StringExamples()
        {
            string lokalizacja1 = "c:\\windows\\system32\\plik.dll";
            string lokalizacja2 = @"c:\windows\system32\plik.dll";
            string slowo1 = "  Ala ma", slowo2 = "kota  ";
            string zdanie = slowo1 +" "+ slowo2;
            float ilosc = 120.78f;           
            Console.WriteLine(zdanie);
            Console.WriteLine("Długość zdania: " + zdanie.Length + " znaków");
            Console.WriteLine("Duże litery: " + zdanie.ToUpper());
            Console.WriteLine("Małe litery: " + zdanie.ToLower());
            Console.WriteLine("Trymowanie: |" + zdanie.Trim() + "|");
            Console.WriteLine("Replace: a -> *: " + zdanie.Replace("a","*").Replace("A","*"));
            int x = 1, y = 2; bool wynik;
            wynik = (x == y);
            wynik = slowo1 == slowo2; //Porównuje wskażniki (adresy) do zmiennych
            wynik = zdanie.Trim().Equals("ALA MA KOTa", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Czy ten sam tekst?: " + wynik);
            Console.WriteLine("Wystąpienia frazy \"ma\": " + zdanie.IndexOf("ma"));
            Console.WriteLine("Wytnij pierwsze pięć znaków: " + zdanie.Substring(1,5));

            zdanie = null;

            //if zdanie.
            //zdanie.Contains("ma");
            if (!string.IsNullOrEmpty(zdanie))
                zdanie.Contains("ma");
            Console.WriteLine("Zawrtosc zmiennej: " + zdanie);
            Console.WriteLine("Sprawdź czy string jest null pusty: " + string.IsNullOrEmpty(zdanie));
           
        }
    }
}
