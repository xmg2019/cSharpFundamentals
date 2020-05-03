using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionB_Qn4
    {
        // Exercise 1 - Section B - Qn 4
        // Write a program that would convert temperature given in Centigrade scale to 
        // Fahrenheit – the number can be integer or real. To convert temperature in Centigrade (C) to Fahrenheit (F) 
        // use the formula: F = 1.8*C + 32

        // My Attempt:
        static void Main(String[] args)
        {
            Console.Write("Please enter temperature in degree Celsius to obtain temperature in Farenheit: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{number} degree Celsius = {(number * 1.8 + 32):0.00} Farenheit");
        }
    }
}
