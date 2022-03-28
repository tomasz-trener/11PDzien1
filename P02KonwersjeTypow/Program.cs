using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02KonwersjeTypow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string a = "1";

            a = a + a; // 11

            int b = Convert.ToInt32(a);

            short c = 5;
            long d = 10 + c ;

            int wiek = 50;


            int a1 = 5;
            double a2 = 5.5;

            int a3 = a1 + Convert.ToInt32(Math.Round(a2));



        }
    }
}
