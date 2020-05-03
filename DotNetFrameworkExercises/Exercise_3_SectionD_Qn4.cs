using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_3_SectionD_Qn4
    {
        // Exercise 3 - Section D - Qn 4
        // Using iteration write a C# program to determine the square root of a given number (N).
        // If required, your instructor would explain the method using a numerical example.
        // Many efficient methods are available; we use a simple one for demonstrating the looping.
        // STEPS: 
        // a. Take N as input the number for finding the square root.
        // b. Take a random number between 1 and N using the function
        // random.NextDouble(). Let the number be called a Guess or G(not necessarily an integer).
        // c. If the Guess is correct then G*G should be N.
        // d. If not use the following formula iteratively until G*G approximates to N to an accuracy of 5 decimal places:
        // G = (G + N/G)/2
        // Input= 0, Output = 0.000, 
        // Input= 25, Output = 5,
        // Input= 3, Output = 1.732


        // My Attempt:
        static void Main (String[]args)
        {
            Console.Write("Please Enter a number: ");
            Double N = Convert.ToDouble(Console.ReadLine());
            Random rnd = new Random();

            Double G = rnd.NextDouble()*(N-1)+1;
            // Random.NextDouble returns a double between 0 and 1.
            // You then multiply that by the range you need to go into(difference between maximum and minimum) 
            // and then add that to the base(minimum).
            /*
              Example
             public double GetRandomNumber(double minimum, double maximum)
            {
                Random random = new Random();
                return random.NextDouble() * (maximum - minimum) + minimum;
            }
            */

            while ( Math.Abs(G*G - N) > 0.000001) 
            // need Math.Asb, to avoid negative number or diff
            {
                G =  0.5*(G + N / G); 
            }

            Console.WriteLine($"Value of G = Sqrt of N: {G:0.###}");


        }
    }
}
// IsAppEqual (double 1, double 2)
//  double diff = Math.Asb(n1-n2);
// if (diff<0.000001)
    // return this
    // else 
    // return taken
    // while (!IsAppEqual (G*G,N) // correspondences 
