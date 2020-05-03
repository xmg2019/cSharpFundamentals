using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_3_SectionD_Qn1
    {
        // Exercise 3 - Section D - Qn 1
        // Write a C# program that would keep prompting you to enter an integer number 
        // over and over again until you enter the number 88. 
        // If you enter 88 the computer should say: “Lucky you…” and exit the program.

            // My Attempt: 
        static void Main(String[] args)
        {

            /*
             Console.WriteLine("Please Enter a number:");
             int A = 0;

            do
             {
                 A = Convert.ToInt32(Console.ReadLine());
                 if (A != 88) Console.WriteLine("Wrong Guess. Please Enter another number:");
             } while (A != 88); 

                Console.WriteLine("Lucky You!");
            */

            int A = 0;

            while (A != 88)
            {
                Console.WriteLine("Please Enter a number:");
                A = Convert.ToInt32(Console.ReadLine());  
            }
                Console.WriteLine("Lucky You!");

        }

    }
}
