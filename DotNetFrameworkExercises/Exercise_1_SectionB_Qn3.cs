using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionB_Qn3
    {
        // Exercise 1 - Section B - Qn3
        // The ABC Company pays its employees salary plus benefits. 
        //The benefits are calculated as a percentage of the salary. 
        //The company pays every employee 10% housing allowance and 3% transport allowance. 
        //Write a program that takes the salary as input and prints the total income (salary + housing allowance + transport allowance) as output. 
        //Format the output in currency format.

        // My Attempt:
        static void Main(string[] args)
        {
            Console.Write("Please key in your salary to find out your overall compensation package: $ ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Salary $ {number} = Full Package $ {number * 1.13:0.00}");
        }
    }
}
