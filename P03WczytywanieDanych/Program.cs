using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03WczytywanieDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile masz lat");
            int wiek = Convert.ToInt32(Console.ReadLine());

            wiek++;

            string wynik = "Twoj wiek to " + wiek + " lat";

            string wynik2 = $"Toj wiek to {wiek} lat";

            string wynik3 = string.Format("Twoj wiek to {0} lat i wzrost to {1} cm", wiek, 180);

            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
