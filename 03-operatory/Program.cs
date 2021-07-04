using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_operatory
{
    class Program
    {
        static void Main(string[] args)
        {
            //OperatoryArytmetyczne();

            //OperatoryRelacyjne();
            //OperatoryPrzypisania();
            //OpertotyLogiczne();
            PrzypadekDzielenia();
            Console.ReadKey();
        }

        private static void PrzypadekDzielenia()
        {
            Console.WriteLine("10.0/3.0: " + 10.0 / 3.0);
            Console.WriteLine("10/ (double)3: " + 10/ (double)3);
        }

        private static void OpertotyLogiczne()
        {
            bool a = false, b = true, c;
            c = a && b; //Iloczyn logiczny, koniunkcja
            c = a || b; //Alternatywa, suma logiczna
            c = !a;     //Negacja
            c = !(!a);  //Podwójna negacja

            


            }

        private static void OperatoryPrzypisania()
        {
            Int64 a = 8923784783, b = 89237498237, c;
            c = a;
            c += a; // c = c + a;
            c -= a; // c = c - a;
            c *= a; // c = c * a;
            c /= a; // c = c / a;
            c %= a; // c = c % a;
        }

        private static void OperatoryRelacyjne()
        {
            double x = -8765, y = 1234567.89;
            Console.WriteLine("x=" + x+", y=" + y);
            Console.WriteLine("x == y: " + (x == y)); //równe
            Console.WriteLine("x != y: " + (x != y)); //różne
            Console.WriteLine("x > y: " + (x > y)); 
            Console.WriteLine("x >= y: " + (x >= y)); 
            Console.WriteLine("x < y: " + (x < y)); 
            Console.WriteLine("x <= y: " + (x <= y)); 


        }

        private static void OperatoryArytmetyczne()
        {
            double x = -10.345, y = 543.21;
            double z;

            z = x + y;
            z = x - y;
            z = z * y;
            z = x / y;
            z = x % y; //10% 1 = 1
            //throw new NotImplementedException();

            int a = 10;
            a++; // a = a + 1;
            a--; // a = a - 1;

            a++;//przyrostkowy
            ++a; //przedrostkopwy

            a = 10;
            Console.WriteLine("a = 10;: " + a); 
            Console.WriteLine("a++ :" + a++);
            Console.WriteLine("++a :" + ++a);



            Console.ReadKey();
        }
    }
}
