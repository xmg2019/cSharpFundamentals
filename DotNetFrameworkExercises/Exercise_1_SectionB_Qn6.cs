using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionB_Qn6
    {
        // Exercise 1 - Section B - Qn 6
        // Write a program that reads the (x, y) coordinates of two points. 
        // Compute the distance between the two points using the formula:
        // Distance = Sqrt [(X2 - X1)^2 + (y2-y1)^2]

        // My Attempt:
        static void Main(String[] args)
        {
            Console.WriteLine("To find the distance betw 2 coordinates;");
            Console.Write("Please enter value for X1: ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter value for X2: ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter value for Y1: ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter value for Y2: ");
            int Y2 = Convert.ToInt32(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            //Console.WriteLine($" Distance = {Math.Sqrt((X2-X1)*(X2-X1)+ (Y2-Y1)*(Y2-Y1))}");
            Console.WriteLine("Distance between 2 coordinates = " + distance);
        }
    }
}
