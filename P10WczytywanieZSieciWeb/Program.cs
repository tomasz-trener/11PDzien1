using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P10WczytywanieZSieciWeb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            WebClient wc = new WebClient();

            int b = 5;


            string s = wc.DownloadString("http://www.tomaszles.pl");

            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
