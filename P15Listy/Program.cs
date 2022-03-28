using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista1 = new List<string>();
            // to jest lista, która ma 0 elementów 

            // ale to nie jest pusta lista 

            List<string> lista2 = null;

            new List<string>();


            lista2= new List<string>();

            lista1.Add("jan");
            lista2.Add("jan");

            lista2.Insert(0, "ola"); // lista2 = "ola", "jan"
            
            lista2.Remove("jan");
            lista2.RemoveAt(1);
            //lista2.RemoveAll()

            int dlugosc=  lista2.Count();

            string[] tablica = new string[3];
            int dlugoscTab=  tablica.Length;

            string s = lista1[0];

            foreach (var item in lista1)
            {
                Console.WriteLine(item);
            }


            // konwersje z lista na tablice 

            string[] tab4 = { "ala", "jan", "ola" };
            List<string> lista4 = tab4.ToList();

            string[] tab5 = lista4.ToArray();

            // konwersje kolekcji na napisy 


            // string napis = "ala jan ola";
            string napis1 = string.Join(" ", tab4);
            string napis2 = string.Join(" ", lista4);

            // w drugią stronę 

            List<string> lista5 = napis1.Split(' ').ToList();

            string napis3 = "ala!*ma!*kota^^i^^ma^^kota";
            List<string> lista6=
                napis3
                .Split(new string[] { "!*", "^^" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();



        }
    }
}
