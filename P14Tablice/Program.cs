using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = new string[4];

            int[] liczby = new int[4]; 

            bool[] logiczne = new bool[4];

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }


            // każdy typ ma swoją wartość domyslną 

            // string = null
            // int 0
            // bool = false

            // ?  tworzy typ nullable 

          //  int b = null; // to jest not null 
            int? a = null;


            int?[] tablica2 = new int?[3];

            if (tablica2[1] != null)
            {
               
            }

            for (int i = 0; i < liczby.Length; i++)
            {
                Console.WriteLine(liczby[i]);
            }



            foreach (int item in liczby)
            {
                Console.WriteLine(item);
            }

            foreach (var item in tablica)
            {

            }

            var a1 = 5; // a1 jest typu int bo automatycznie rozpoznano , że 5 to int 
            var a2 = "ala ma kota"; //a2 jest typu string 
            //a2 = 4; //  to już jest bład bo a2 jest stringim 

            var a3 = false;

            int a4;

            var a5 = a3;

            LinkedList<List<string>> jakisObiekt = new LinkedList<List<string>>();

            var jakisObiekt2 = new LinkedList<List<string>>();


            if (a3 is int)
            {

            }

            string nazwaTypu = a3.GetType().Name;



            //sposoby tworzenia tablic 

            string[] tab1 = new string[3];
            tab1[0] = "jan";
            tab1[1] = "ala";
            tab1[2] = "ola";

            string[] tab2 = new string[3] { "jan", "ala", "ola" };

            string[] tab3 = { "jan", "ala", "ola" };

            int dlugosc = tab3.Length;

            string[] tab4= tab1.Concat(tab2).ToArray();

            string[] tab5 = tab1.Concat(new string[]{"raz","dwa" }).ToArray();


            Console.WriteLine("podaj ile danych chcesz przechowywac");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] imiona = new string[n];


            Console.ReadKey();

        }
    }
}
