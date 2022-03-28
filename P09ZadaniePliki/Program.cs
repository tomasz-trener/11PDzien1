using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadaniePliki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwe pliku");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Podaj dwa wyrazy");

            string dane = Console.ReadLine();

            string[] tab = dane.Split(' ');
            string napis1 = tab[0];
            string napis2 = tab[1];

            string zawartoscPliku = File.ReadAllText(nazwa);
            // zameniamy 
            zawartoscPliku = zawartoscPliku.Replace(napis1, napis2);

            File.WriteAllText(nazwa, zawartoscPliku);


        }
    }
}
