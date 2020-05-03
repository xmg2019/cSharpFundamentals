using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_2_SectionC_Qn1
    {
        // Exercise 2 - Section C - Qn 1
        // Write a program that would request for your name and gender (M or F assume capital letter) 
        //and print a greeting like this: Good Morning Mr. Venkat where you entered Venkat for name and M for gender.

        // My Attempt:
        static void Main (String[] args)
        {
            Console.WriteLine("Please enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Please enter your gender-M/F");
            String gender = Console.ReadLine();
            if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr. {0}", name);
            }
            else
            {
                Console.WriteLine("Good Morning Ms. {0}", name);
            }


        }
    }
}
