using System;

namespace MathsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            FourOperations fourOperations = new FourOperations();
            fourOperations.Sum(5, 10);
            fourOperations.Sub(10, 23);
            fourOperations.Divide(5.4, 12);
            fourOperations.Multiply(12, 3.4);




        }
    }
}
