using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P17ZadanieZawodnicy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj kraj");
            string kraj = Console.ReadLine().ToLower();

            const string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            WebClient wc = new WebClient();

            string dane = wc.DownloadString(sciezka);

           

            string[] wiersze = dane.Split(new string[] { "\r\n" },StringSplitOptions.RemoveEmptyEntries);

            List<string> imionaINazwiska = new List<string>()
             { "Imie;Nazwisko" };

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                if (komorki[4].ToLower() == kraj)
                    imionaINazwiska.Add($"{komorki[2]};{komorki[3]}");
            }

            File.WriteAllLines($@"c:\dane\{kraj}.txt", imionaINazwiska);


            byte[] plik = wc.DownloadData(sciezka);
            File.WriteAllBytes(@"c:\dane\zawodnicy.txt", plik);


        }
    }
}
