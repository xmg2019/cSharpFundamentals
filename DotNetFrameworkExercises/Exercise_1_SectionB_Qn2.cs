using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionB_Qn2
    {
        // Exercise 1 - Section B - Qn2
        // Write a program that takes a double precision number 
        // as input and prints the square root of the number. 
        // The square root should be rounded to 3 decimal places.

        // My Attempt:
        static void Main(String[] args)
        {
            Console.Write("Please enter a double precision number to calculate its square root : ");
            double number = Convert.ToDouble(Console.ReadLine());
            number = Math.Sqrt(number);
            number = Math.Round(number,3);
            Console.WriteLine($"Square root of number = {number:0.000}");
            //Console.WriteLine($"Square Root of {number} = {Math.Sqrt(number):0.000}");
        }

    }
}
