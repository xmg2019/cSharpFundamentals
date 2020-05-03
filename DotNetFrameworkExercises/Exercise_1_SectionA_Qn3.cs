using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionA_Qn3
    {
        // Exercise 1 - Section A - Qn 3
        // Write a program that takes an integer as input and prints the square of that number.

        // My Attempt:
        static void Main(string[] args)
        {
            while (true)  // while(true) enables the running of the block of codes w/o the app exiting
            {
                Console.Write("Please enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{number} X {number} = {number * number}");
            }
            
        }

    }
}
