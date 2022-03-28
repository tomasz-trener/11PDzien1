using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P18ZadaniePogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const char znak = '°';
            const char znakKoncowy = '>';

            while (true)
            {
                Console.WriteLine("Podaj miasto");
                string miasto = Console.ReadLine();

                if (miasto == "0")
                    return; // lub breake 

                string dane =
                    new WebClient().DownloadString($"https://www.google.com/search?q=pogoda+{miasto}");

                //File.WriteAllText(@"c:\dane\pogoda.html", dane);

                int indx = dane.IndexOf(znak);
                int aktualnaPoz = indx;

                //while (dane.Substring(aktualnaPoz,1)!= znakKoncowy)
                //    aktualnaPoz--;

                while (dane[aktualnaPoz] != znakKoncowy)
                    aktualnaPoz--;

                string wynik = dane.Substring(aktualnaPoz + 1, indx - aktualnaPoz + 1);
                Console.WriteLine($"temperatura w mieście {miasto} wynosi {wynik}");
            }

            



        }
    }
}
