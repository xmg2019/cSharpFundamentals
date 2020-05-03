using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 3 - Section E - Qn 6
    // Modify the Perfect Number C# program to print out all the perfect numbers from 1 to 1000.
     
        // My Attempt:
    class Exercise_3_SectionE_Qn6
    {
        static void Main(String[] arg)
        {
            
            Console.WriteLine("List of Perfect Numbers from 1 to 1000 : ");
            
            int B = 0;
            
            for (B=1; B<=1000; B++)
            {
                int sum = 0; // MUST PUT HERE!!!! if not, SUM cannot be equal to B below!!!

                for (int A=1; A<B; A++)
                {

                    if (B % A == 0)
                    {
                        sum += A;

                    }
                }
                if (sum == B)
                {
                    Console.WriteLine(B);
                }


            }

           



        }
    }
}
        
            
            
        
        

            
        

