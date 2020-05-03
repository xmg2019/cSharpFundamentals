using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 3 - Section E - Qn 2
    // Write a program to print all numbers between 1 and 10 with the values of its inverse,
    // square root and square as below:

        // My Attempt:
    class Exercise_3_SectionE_Qn2
    {
        static void Main (String[]args)
        {
            Console.WriteLine("Please enter a number betw. 1 and 10");
            int N = Convert.ToInt32(Console.ReadLine());
            Double A = 1;
            
            for (A=1; A<=N; A++)
            {
                Console.Write("{0:0.0}\t", A);  // new tab //
                
                Console.Write("{0:0.000}\t", 1/A); // Console.Write instead of Console.WriteLine so that results will print 1 line instead of run on lines//

                Console.Write("{0:0.000}\t", Math.Sqrt(A)); 

                Console.Write("{0:0.0}\n", A * A); // \n means new line //
            }
            

        }

    }
}
