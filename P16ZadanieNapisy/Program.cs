using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16ZadanieNapisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie");

            string zdanie = Console.ReadLine();

            string[] wyrazy = zdanie.Split(' ');

            List<string> wyrazy2 = zdanie.Split(' ').ToList();


            int indeksNajdluzszego = 0;

            //for (int i = 0; i < wyrazy.Length; i++)
            //    if (wyrazy[i].Length >wyrazy[indeksNajdluzszego].Length)
            //        indeksNajdluzszego = i;

            string aktualnieNajduzszy = null;
            foreach (var w in wyrazy)
                if (w.Length > wyrazy[indeksNajdluzszego].Length)
                    aktualnieNajduzszy = wyrazy[indeksNajdluzszego];
            

            string najdluzszyWyraz = wyrazy[indeksNajdluzszego];
            Console.WriteLine(najdluzszyWyraz);
            Console.ReadKey();

            // ciekawostka 

            string najdluzszyWyrazy2 = zdanie.Split(' ').OrderBy(x => x.Length).FirstOrDefault();

            // 


            
        }
    }
}
