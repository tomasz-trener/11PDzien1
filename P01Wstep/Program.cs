using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Wstep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hej");

            string a = "ala ma kota";

            Console.WriteLine(a);

            int b = 5;

            double c = 5.4;

            b = +1;
            b++;
            b += 2;// zwiększ o 2 

            /* komentarz 
              wielo linowy
             */

            b--;


            int d = 1;
            Console.WriteLine(d); // 2
            Console.WriteLine(d); //2

            // + , - , * , / 

            double d2 = 10 / 3.0; // 3  

            double d3 = Convert.ToDouble(10) / 3; // 3.3333


            int e = 1;
            e =e +1;
            e++;
            e += 2;
            e -= 3; // zmniejsz o 3 
            e *= 4; // przemnoz przez 4
            e /= 2; // przedziel przez 2 

            string s2 = "ala" + " ma" + " kota"; // konkatenacja stringu 

            string s3 = "ala" + e;
            



            Console.ReadKey();

        }
    }
}
