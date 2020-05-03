using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionA_Qn5
    {
        // Exercise 1 - Section A - Qn 5
        // Write a program that takes a double precision number 
        // as input and prints the number with 2 decimal points in the output.
        // e.g input 100.1 >>>> output 100.10
        // e.g input 4.232 >>>> output 3.23
        // e.g input 4.555 >>>> output 4.56


        // My Attempt:
        static void Main(String[] args)
        {
            while (true) { 
            Console.Write("Please enter a double precision number to be rounded off to 2 dec. pl.:");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Number rounded off to 2 dec.pl. : {number:0.00}");
            }
        }
    }
}
