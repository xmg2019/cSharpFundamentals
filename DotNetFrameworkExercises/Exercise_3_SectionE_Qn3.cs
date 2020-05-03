using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 3 - Section E - Qn 3
    // Given an integer as input determine whether the number is a prime number or not. Your
    // program should output “Prime” or “Not Prime” as the case may be.
    // A Prime Number is one which is only divisible by one and itself.
    // Consider how the efficiency of the program can be improved.
    // Normally the order of complexity is proportional to the number of times a loop is executed.
        
        // My Attempt:
    class Exercise_3_SectionE_Qn3
    {
        static void Main (String[]args)
        {
            Console.Write("Please enter a number : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int D = 1; // Divisor //
            // Double R = (N % D); // Remainder when Number divided by divisor BUT CANNOT PUT HERE, need TO PUT under the FOR Statement //
            int C = 0;

            for (D=1; D<=N; D++)
            {                
                if (N % D == 0) // PUT the equation here, so the FOR statement knows the equation to process.
                {
                    C++;
                }
            }
            if (C == 2)
            {
                Console.Write($"The number {N} IS a PRIME Number ");
            }
            else
            {
                Console.Write($"The number {N} provided is NOT a PRIME number");

            }
            Console.ReadLine();

        }
    }
}
