using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionB_Qn10
    {
        // Exercise 1 - Section B - Qn19
        // Consider the simple Geometric example of determining the area of a triangle, given the lengths of its three sides a, b and c.
        // Use the formula: AREA = SQUAREROOT[s(s - a)(s - b)(s - c)] where s = (a+b+c) / 2

        // My Attempt:
        static void Main(String[] args)
        {
            Console.Write("Please enter value of side a : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter value of side b : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter value of side c (longest side) : ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c)
            //  The sum of the length of the two sides of a triangle is greater than the length of the third side.
            {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("Dimensions provided attest to a triangle.");
                Console.WriteLine($"Area of triangle is = {area}");
            }
            else
            {
              Console.WriteLine("Dimensions provided do not attest to a triangle");
            }
        }
    }
}
