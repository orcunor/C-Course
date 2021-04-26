using System;

namespace firstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // Do not repeat yourself 
            // değer tutucu, alias

            string category = "Kategori";
            Console.WriteLine(category);

            int number = 32000;

            double interestRate = 1.45;

            bool isSuccess = false;

            double dollarYesterday = 8.01;
            double dollarToday = 8.12;

            if (dollarYesterday > dollarToday)
            {
                Console.WriteLine("dollar depreciated compared to yesterday.");
            }
            else if (dollarYesterday < dollarToday)
            {
                Console.WriteLine("dollar appreciated compared to yesterday");
            }
            else
            {
                Console.WriteLine("Does not change.");
            }



            if (isSuccess)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("username or password incorrect");
            }

        }
    }
}
