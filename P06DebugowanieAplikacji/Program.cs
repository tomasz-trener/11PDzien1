using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06DebugowanieAplikacji
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // f10 nastepna instrukcja
            // f11 wejscie do środka np. metody

            string s = "ala ma kota";

            int a = 1;
            a++;

            a*=2;
            a--;

            int b = a * 3;
            b--;

            Console.WriteLine(b);
        }
    }
}
