using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_2_SectionC_Qn2
    {
        // Exercise 2 - Section C - Qn 2
        // Write a program that would request for your name, gender and age 
        //and would print a greeting like this: Good morning Uncle Sam ( if Sam, M, 45 is entered)
        //(any gentlemen 40 years or more is Uncle any lady 40 years or more is Aunty, 
        //if less than forty they become just Mr or Ms. as the case may be.)

        // My Attempt:
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your gender");
            string gender = Console.ReadLine();
            if (gender == "M" || gender =="m")
            {
                if (age >= 40)
                {
                    Console.WriteLine("Good Morning Uncle. {0}", name);
                }
                else
                {
                    Console.WriteLine("Good Morning Mr. {0}", name);
                }

            }
            else
            {
                if (age >= 40)
                {
                    Console.WriteLine("Good Morning Auntie.{0}", name);
                }
                else
                {
                    Console.WriteLine("Good Morning Ms. {0}", name);
                }
            }
        }
    }
}
