using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 3 Section E - Qn 5
    // Modify the Prime Number C# program to print out all the prime numbers from 5 to 10000.

        // My Attempt: 
    class Exercise_3_SectionE_Qn5
    {
        static void Main(String[] arg)
        {
            Console.BufferHeight= 12000;
            Console.Write("List of Prime Numbers between 5 to 10,000"); // ? the upper bound is 10,005//

            int N = 10000;
            int D;
            int C = 0;
            int A;

            for (D = 5; D <= N; D++)
            {
                C= 0; // VERY IMPORTANT TO place C==0 here, if not, C will not be equal to 2 at the END LOOP ---> resulting in all numbers being printed//
                for (A = 1; A <= N; A++)
                {
                    if (D % A == 0)
                    {
                        C++;
                    }
                }
                if (C==2) // MUST come OUT of the FOR loop in order to be printed !!! //
                {
                    
                    Console.WriteLine(D);
                }
            }
        }
    }
            }



            
                     
            
        
    

