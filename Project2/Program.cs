using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("1. Constructor Tests:");

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine($"Duration(1, 10, 15): {D1}");

            Duration D2 = new Duration(3600);
            Console.WriteLine($"Duration(3600): {D2}");

            Duration D3 = new Duration(7800);
            Console.WriteLine($"Duration(7800): {D3}");

            Duration D4 = new Duration(666);
            Console.WriteLine($"Duration(666): {D4}");

            
            Console.WriteLine("2. Overloading Tests:");

            D3 = D1 + D2;
            Console.WriteLine($"D1 + D2: {D3}");

            D3 = D1 + 7800;
            Console.WriteLine($"D1 + 7800: {D3}");

            D3 = 666 + D3;
            Console.WriteLine($"666 + D3: {D3}");

            Console.WriteLine($"Before ++D1: {D1}");
            D3 = ++D1;
            Console.WriteLine($"After ++D1: {D1}");
            Console.WriteLine($"D3 = ++D1: {D3}");

            Console.WriteLine($"\nBefore --D2: {D2}");
            D3 = --D2;
            Console.WriteLine($"After --D2: {D2}");
            Console.WriteLine($"D3 = --D2: {D3}");

            Console.WriteLine($"\nBefore D1 - D2: D1={D1}, D2={D2}");
            D1 = D1 - D2;
            Console.WriteLine($"After D1 - D2: {D1}");

            Console.WriteLine("3. Comparison Tests:");
            Console.WriteLine($"D1 > D2: {D1 > D2}");
            Console.WriteLine($"D1 <= D2: {D1 <= D2}");

            Console.WriteLine("4. True Operator Test:");
            if (D1)
            {
                Console.WriteLine("D1 is true (has positive duration)");
            }

            Console.WriteLine("5. DateTime Conversion:");
            DateTime dateTimeObj = (DateTime)D1;
            Console.WriteLine($"DateTime conversion: {dateTimeObj}");

            Console.WriteLine("6. Equality Test:");
            Duration testDuration = new Duration(1, 10, 15);
            Console.WriteLine($"D1.Equals(testDuration): {D1.Equals(testDuration)}");

            Console.ReadLine();
        }
    }
    }
