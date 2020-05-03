using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionA_Qn4
    {
        // Exercise 1 - Section A - Qn 4
        // Write a program that takes a double precision number
        // as input and prints the square of that number

        // My Attempt:
        static void Main(String[] args)
        {
            Console.Write("Please enter a number:");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{number}^2 = {number * number}");
        }
    }
}
        