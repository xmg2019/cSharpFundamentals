using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 5 - Section H - Qn 9
    // Write a static method: IsPrime(int n) that would return a boolean and use IsPrime
    // method to print out prime number from 5 to 1000

        // My Attempt:
    class Exercise_5_SectionH_Qn9
    {
        static bool IsPrime(int n)
        {
            
            int timesWhereRemainderisZero = 0;

            for (int divisor=1; divisor<=n; divisor++)
            {
                if (n % divisor == 0 )
                {
                    timesWhereRemainderisZero++;
                }
            }

            if(timesWhereRemainderisZero == 2)
            {
                Console.WriteLine("Integer " + n + " is a Prime Number.");
                return true;
            }else
            {
                Console.WriteLine("Integer " + n + " is NOT a Prime Number.");
                return false;
            }
   
        }

        static void Main (string[] arg)
        {
            Console.WriteLine("Please key in a number between 5 to 1000 to check if it is a Prime number: ");
            int h = Convert.ToInt32(Console.ReadLine());

            IsPrime(h);
        }
    }
}
