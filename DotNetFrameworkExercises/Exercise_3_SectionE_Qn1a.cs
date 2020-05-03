﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_3_SectionE_Qn1a
    {
        // Exercise 3 - Section E - Q1a
        // Given a number find out its factorial.
        // Write two different C# program variations for the problem:
        // a. Using increment counter
        // b. Using a decrement counter.
        // Carefully study the similarities and differences between the two approaches.

            // My Attempt:
        static void Main (String[]args)
        {
            // using Increment Counter//
            Console.Write("Write any number: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int A = 0;
            int N = 1;
            
            
            for (A = 1; A<=B; A++)
            {
                N = A * N;
            }
            Console.WriteLine($"Value of {N}");
        }
    }
}
