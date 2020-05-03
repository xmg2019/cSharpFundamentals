using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_3_SectionD_Qn2
    {
        // Use Euclid's Algorithm given below to determine the lowest common multiply (LCM) and highest common factor (HCF) for given two integer numbers.
        // Take in as input two numbers A and B.
        // Subtract the smaller of the two numbers from the Larger Number and assign the answer to the larger number.
        // The above process is repeated until both the numbers are equal, say X.
        // Apparently the residual number (X) that we have obtained is the HCF.
        // LCM could then be computed using the formula(A* B)/HCF
        // Print out your answers.
        // A: 8, B: 4, HCF: 4, LCM: 8
        // A: 120, B: 2000, HCF: 40, LCM: 6000
        static void Main (String[] arg)
        {
            Console.WriteLine("Loop Starts ... ...");
            Console.WriteLine("Please enter a value for A:");
            int A = Convert.ToInt32(Console.ReadLine());
            int D = A;
            // does not matter if we perform other operations on A later on, as we have stored the original value of A into "D"
            Console.WriteLine("Please enter a value for B:");
            int B = Convert.ToInt32(Console.ReadLine());
            int E = B;

            while (A!=B)
            {
                if (A > B) A = A - B;
                if (B > A) B = B - A;
                // pls mind the syntax 
            }
            int HCF = A;
            //Console.WriteLine($"Check the value of {HCF} at this step");
            int LCM = D * E / HCF;
            // need to insert the original value of A & B into this 
            Console.WriteLine($"Result = A:{D}, B:{E}, HCF:{HCF}, LCM:{LCM}");
            Console.WriteLine($"End of Operation");
                                           
        }
    }
}
