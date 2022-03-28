using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12ZadanieInstrukcjeWarunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj równanie");
            string rownanie = Console.ReadLine();

            int pozPlus= rownanie.IndexOf('+');
            int pozMinus = rownanie.IndexOf('-');
            int pozMnozenie = rownanie.IndexOf('*');
            int pozDzielnie = rownanie.IndexOf('/');

            double wynik;

            if(pozPlus > -1)
                wynik = Convert.ToDouble(rownanie.Substring(0,pozPlus)) + 
                    Convert.ToDouble(rownanie.Substring(pozPlus+1));
            else if (pozMinus > -1)
                wynik = Convert.ToDouble(rownanie.Substring(0, pozMinus)) -
                    Convert.ToDouble(rownanie.Substring(pozMinus + 1));
            else if (pozMnozenie > -1)
                wynik = Convert.ToDouble(rownanie.Substring(0, pozMnozenie)) *
                    Convert.ToDouble(rownanie.Substring(pozMinus + 1));
            else if (pozDzielnie > -1)
                wynik = Convert.ToDouble(rownanie.Substring(0, pozDzielnie)) /
                    Convert.ToDouble(rownanie.Substring(pozMinus + 1));
            else
            {
                Console.WriteLine("Podałeś zły wynik");
                Console.ReadKey();
                return;
            }

        
            Console.WriteLine($"Wynik równania {rownanie} to {wynik}");
            Console.ReadKey();
        }
    }
}
