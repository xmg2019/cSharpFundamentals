using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionA_Qn1_Qn2
    {
        /*
        Exercise 1 - Section A - Q1 & Q2
        Write a program that will print out your detail in the following format:
        Line 1: Name
        Line 2: Email
        */

        // My attempt:
        static void Main(string[] args)
        {
            Console.WriteLine("Xiao Min");
            Console.WriteLine("e0481153@u.nus.edu");
                        
            Console.Write("Please enter your name:");
            string name = Console.ReadLine();
             // Console.WriteLine("Good Morning {0}", name);
            Console.WriteLine("Good Morning "+ name);       
        }
    }
}
