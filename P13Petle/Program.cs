using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // petla while 
            int a = 0;
            while (a>10)
            {
                Console.WriteLine(a);
                a++;
            }


            a = 0;
            while (true)
            {
                if (a == 5)
                    continue;

                if (a>10)
                    break;

                a++;
            }

            for (int i = 0; i < 10; i++)
            {

            }

            for (int i = 20; i > 0; i-=2)
            {

            }

            // petla dowhile

            do
            {

            } while (true);


            

            //12:45  

        }
    }
}
