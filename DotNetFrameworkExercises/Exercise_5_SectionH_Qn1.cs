using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 5 SectionH Qn1
    // Write a static method ReadInteger(string message) that would return an integer. 
    // The method should prompt the user with the message, get the input from the user using Console.ReadLine 
    // and if the input can be parsed into integer return the integer. 
    // If the input cannot be parsed into integer, the method should repeat the prompt until the user enter an integer input.

        // My Attempt:

    class Exercise_5_SectionH_Qn1
    {      
        static bool ReadInteger (string m)
        {
            string M=m;
            int im;

            bool success = Int32.TryParse(M, out im);
            // Int32.TryParse --> take in a string and convert to its Int32 bit integer equivalent 
            // return '0' if conversion fails and return output if success
            // command Int32.Parse ('input var', out 'output variable')


            if (success)
            {
                Console.WriteLine($"Converted {M} to {im}.");
            }
            else
            {
                Console.WriteLine($"Attempted Conversion of {M} to {im} fails");
                Console.WriteLine("Please enter another value ");
                ReadInteger(Console.ReadLine());
            }
            return true; // if success
        }

        static void Main (string[]args)
        {
            Console.WriteLine("Please enter a message: ");
            ReadInteger(Console.ReadLine()); // calling out to ReadInteger method
            
        }
    }
}
