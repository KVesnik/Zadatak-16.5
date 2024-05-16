using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {   bool djeljiv = false;

            while (!djeljiv)
            { Console.WriteLine("Upišite broj:");
            double broj = double.Parse(Console.ReadLine());

            Console.WriteLine("Upišite drugi broj:");
            double drug_broj = double.Parse(Console.ReadLine());

            if (broj % drug_broj == 0)
            {
                Console.WriteLine("Broj je djeljiv");
                    djeljiv =true;
            }
            else
            {
                Console.WriteLine("Broj nije djeljiv");
            }

            Console.ReadKey();}
            


        }
    }

}


