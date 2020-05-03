using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionB_Qn10_Alternative
    {
        // Exercise 1 - Section B - Qn19
        // Consider the simple Geometric example of determining the area of a triangle, given the lengths of its three sides a, b and c.
        // Use the formula: AREA = SQUAREROOT[s(s - a)(s - b)(s - c)] where s = (a+b+c) / 2

        // Alternative approach:
        static void Main(String[] args)
        {
            Console.WriteLine("Pease enter the value of side A : ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of side B : ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of side C : ");
            double C = Convert.ToDouble(Console.ReadLine());
            double S = (A + B + C) / 2;
            if ((A + B) > C && (B + C) > A && (A + C) > B)
            {
                Console.WriteLine($"Area of triangle = {Math.Sqrt(S * (S - A) * (S - B) * (S - C))}");
            }
            else
            {
                Console.WriteLine("This is not a triangle");
            }




        }

    }
}
