using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string course1 = "JAVA";
            string course2 = "C#";
            string course3 = "Python";

            // Array- Dizi

            string[] courses = new string[]
            {
                "JAVA",
                "C#",
                "Python",
                "C++"
            };


            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }


            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }



            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
            }















            //int control = 0;
            //Console.Write("Sayı Girin :");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i < number; i++)
            //{
            //    if (number % i == 0)
            //        control++;
            //    if (control == 1)
            //    {
            //        i = number;
            //    }
            //}

            //if (control != 0)
            //    Console.WriteLine("Girdiğiniz sayı asal değildir.");
            //else
            //    Console.WriteLine("Girdiğiniz sayı asaldır.");

            //Console.ReadKey();


        }
    }
}
