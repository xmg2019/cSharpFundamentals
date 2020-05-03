using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 3 - Section E - Qn 4
    // Given an integer as input write a C# program to determine whether the number is Perfect Number or not.
    // A perfect number is one for which the sum of its factors (including number one) add up to the number itself.
    // For example number six is a perfect number because, 6 = 1 + 2 + 3.

        // My Attempt:
    class Exercise_3_SectionE_Qn4
    {
        static void Main (String[] args)
        {
            Console.WriteLine("Please enter a number to check if its perfect.");
            int N = Convert.ToInt32(Console.ReadLine());
            int B = 0;
            int sum = 0;

            for(B=1; B<N; B++) // B<N becos the sum excludes the digit itself//
            {
                if ( N % B == 0) // if remainder of N/B = 0 //
                {
                    sum+=B; // total sum = sum of list of n/b variables + B variables //
                }
            }

            if (sum==N)
            {
                Console.WriteLine("The number provided is a PERFECT number. ");
            }

            else
            {
                Console.WriteLine("The number provided is NOT a PERFECT number. ");
            }

           /* for (B = 1; B < N; B++)
            {
                N = B * C;
            }
                           
                if (B + C + 1 == N)
                {
                    Console.WriteLine("The number provided is a PERFECT number.");
                }
                if (B + C + 1 > N || (B + C + 1) < N)
                {
                    Console.WriteLine("The number is NOT a PERFECT number.");
                
                } */
        }
    }
}
