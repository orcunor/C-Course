using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[]
            //{
            //    "Orçun",
            //    "Deniz",
            //    "Ahmet"
            //};

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            List<string> names2 = new List<string> {"Orçun","Deniz","Ahmet" }; // Generic collection

            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);

            names2.Add("Ersen");

            Console.WriteLine(names2[3]);
        }
    }
}
