using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionB_Qn1

    {
        // Exercise 1 - Section B -  Qn 1 
        // Write a program that takes a double precision
        // number as input and prints the square root of the number.

        // My Attempt:
        static void Main (String[] args)
        {
            Console.Write("Please Enter a double precision number to calculate its square root: ");
            double number = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{Math.Sqrt(number)}= {Math.Sqrt(number)}");
            Console.WriteLine($"Square Root of Number: {Math.Sqrt(number):#.###}");

        }

    }
}
