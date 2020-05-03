using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionB_Qn5
    {
        // Exercise 1 - Section B - Qn 5
        // Write a program that would take as input the value of x 
        // and calculate & output the value of y 
        // using the formula: y = 5X^2 - 4X + 3

        // My Attempt:
        static void Main(String[] args)
        {
            Console.Write("Please enter the value for X to find the value for Y: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Value of Y = {(number * number * 5 - 4 * number + 3):0.00}");
        }
    }
}
