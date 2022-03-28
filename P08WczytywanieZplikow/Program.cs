using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P08WczytywanieZplikow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // string dane0 = File.ReadAllText("c:\nane\tlik.txt");
            // string dane = File.ReadAllText("c:\\dane\\plik.txt");
            string dane = File.ReadAllText(@"c:\dane\plik.txt");
            string[] tab = dane.Split('^');

            File.WriteAllText(@"c:\dane\wynik.txt", "ala ma kota\nhej");

            File.AppendAllText(@"c:\dane\wynik.txt", "jeszcze coś");

            string s = @"\nala\tkota"; //      \nala\tkota


        }
    }
}
