using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Maths Operations Results -----");

            double result1 = MathOperations.Add(13, 7);
            double result2 = MathOperations.Subtract(8, 4);
            double result3 = MathOperations.Multiply(5, 9);
            double result4 = MathOperations.Divide(14, 2);


            Console.WriteLine($" Addition : {result1}");
            Console.WriteLine($" Subtraction: {result2}");
            Console.WriteLine($" Multiplication: {result3}");
            Console.WriteLine($" Division:  {result4}");

            Console.ReadLine();

        }
    }
}
