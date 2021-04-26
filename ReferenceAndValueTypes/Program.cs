using System;

namespace ReferenceAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            // number1 ??  - 30
            Console.WriteLine(number1);
            // int decimal float double long bool enum struct value types -- stack

            // array, class, interface, string abstract reference types -- heap adres tutar pointer

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };

            numbers1[0] = numbers2[1];
            foreach (var num in numbers1)
            {
                Console.WriteLine(num); // 200 20 30
            }
            numbers1 = numbers2;
            Console.WriteLine(numbers1[0]);
            Console.WriteLine(numbers2[0]);
            numbers2[0] = 999;
            // numbers[0] ??? 999
            Console.WriteLine(numbers1[0]);
        }
    }
}
