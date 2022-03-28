using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieLiczby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj równanie w jendej linii");
            string r = Console.ReadLine();

            int poz = r .IndexOf("+");

            string liczba1 = r.Substring(0, poz);
            string liczba2 = r.Substring (poz + 1);

            int sum  = Convert.ToInt32(liczba1) + Convert.ToInt32(liczba2);

            Console.WriteLine($"wynik to {sum}");
           
            Console.ReadKey();
        }
    }
}
