using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BMI = waga / wzrost^2 (w cm)
            //18.5 niedowaga
            //<25 -ok
            //30 nadwaga
            //>= 30 Otyłość
            
            Console.Write("Podaj wagę w kg: ");
            int waga = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj wzrost w cm: ");
            int wzrost = Convert.ToInt32(Console.ReadLine());

            double bmi = waga / Math.Pow(wzrost / 100.0, 2);
            Console.WriteLine("BMI = " + bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine("niedowaga");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("ok");
            }
            else if (bmi < 30)
                Console.WriteLine("Nadwaga");
            else
                Console.WriteLine("Otyłość");

            Console.ReadKey();
        }
    }
}
