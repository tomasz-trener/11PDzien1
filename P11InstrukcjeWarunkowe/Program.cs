using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11InstrukcjeWarunkowe
{
    internal class Program
    {
        string zmienna;
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wiek");
            int wiek = Convert.ToInt32(Console.ReadLine());
           
            if (wiek < 50)
                Console.WriteLine("młody");
            else
                Console.WriteLine("stary");
            

            // pozniej 30 bardzo mdoy, 30 - 50 mlodt - 50-70 sredni powzyj 70 stary 


            if(wiek < 30)
                Console.WriteLine("bardzo mlody");
            else if(wiek <50)
                Console.WriteLine("młody");
            else if (wiek < 70)
                Console.WriteLine("sredni");
            else
                Console.WriteLine("stary");


            int wzrost = 175;
            string plec;

            if (wzrost > 180)
                plec = "mężczyzna";
            else
                plec = "kobieta";

            string plec2 = wzrost > 180 ? "mężczyzna" : "kobieta";

            string x=null;

            if (wiek < 30)
            {
                x = "ala ma kota";
                Console.WriteLine(x);
            }

            Console.WriteLine(x);

        }
    }
}
