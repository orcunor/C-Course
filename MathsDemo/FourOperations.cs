using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsDemo
{
    class FourOperations
    {

        public int Sum(int number1, int number2)
        {
            return number1 + number2;
            Console.WriteLine("Added");
        }

        public int Sub(int number1, int number2)
        {
            return number1 - number2;
            Console.WriteLine("Substraction");
        }

        public double Divide(double number1, double number2)
        {
            return number1 / number2;
            Console.WriteLine("Divide.");
        }
        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
            Console.WriteLine("Multiply.");
        }

    }
}
