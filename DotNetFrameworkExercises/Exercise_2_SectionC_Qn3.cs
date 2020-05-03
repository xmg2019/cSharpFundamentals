using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_2_SectionC_Qn3
    {
        // Exercise 2 - Section C - Qn 3
        // Write a program that would compute the grade for a mark that the student gets. 
        // The program should take an integer number between 0 and 100 and print the following:
        // You scored 73 marks which is B grade.where 73 is the input and B is calculated by the program. 
        // Use the following table for computing the grades:
        // 80 to 100 == Grade A, 60 to 79 == Grade B, 40 to 59 == Grade C, 0 to 40 == Grade F
        // < 0 == Error
        // > 100 ==  Error

            // My Attempt:
        static void Main(String[]args)
        {
            Console.WriteLine("Please enter your marks to find your grade");
            int X = Convert.ToInt32(Console.ReadLine());
           
            if (X>=80 && X<=100)
            {
                Console.WriteLine("You scored {0} marks which is A grade.", X);
            }
            if (X<=79 && X>=60)
            {
                Console.WriteLine("You scored {0} marks which is B grade.", X);          
            }
            if (X>=40 && X<=59)
            {
                Console.WriteLine("You scored {0} marks which is C grade.", X);
            }
            if (X>=0 && X<40)
            {
                Console.WriteLine("You scored {0} marks which is F grade.", X);
            }
            if (X<0||X>100)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
