using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04OperacjeNaNapisach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ala ma kota";
            int dlugosc =  s.Length;
            string s2= s.Substring(4, 2);
            string s3= s.Substring(4); // do konca

            string s4= s.ToUpper();
            string s5= s.ToLower();

            string s6= s.Replace("ma", "bedzie miala");

            s.Replace("ma", "bedzie miala"); // ta instrukcja nicnie zrobi 

            bool czyZawiera= s.Contains("ma");

            string s7= s.Trim(); // usuwanie spacji z przeodu i z tylu 

            int s8 = s.IndexOf("ma"); // zwraca pozycje pierwszego znalezionego podciagu  ( u nas s8=4)

            string napis1 = "ala\nma\nkota";
            string napis2 = "ala" + Environment.NewLine + "ma" + Environment.NewLine + "kota";
            string napis3 = "ala\nma\\lkota";

            string s9 = s.Replace(" ", "").Replace("\n", "").Replace("\r", "");

            string napis4 = "ala\tma\tkota";


        }
    }
}
