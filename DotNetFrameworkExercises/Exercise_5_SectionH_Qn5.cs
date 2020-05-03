using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 5 - Section H - Qn 5
    // Write a function (static method) that would take in an integer and return the hexadecimal.
    // Print out the Hex of all numbers 1 to 100 and compare your answer with that of the built in function.

        // My Attempt: 
        // Only works for conversions of integers from 1 to 100

    class Exercise_5_SectionH_Qn5
    {
                
        static void hexadecimal(int test)
        {
   
            string[] setA = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

            double factor = test / 16;
            factor = Math.Round(factor, MidpointRounding.ToEven);
            int cFactor = Convert.ToInt32(factor);
            //Console.WriteLine(factor);

            double rem = test % 16;
            rem = Math.Round(rem, MidpointRounding.ToEven);
            int cRem = Convert.ToInt32(rem);
            //Console.WriteLine(rem);

            if (test <= 100)
            {
                Console.WriteLine($"Integer: " + test + " = Hexadecimal no. : " + cFactor + setA[cRem]);
            }
            else if (test <= 95)
            {
                Console.WriteLine($"Integer: " + test + " = Hexadecimal no. : " + cFactor + setA[cRem]);
            }
            else if (test <= 79)
            {
                Console.WriteLine($"Integer: " + test + " = Hexadecimal no. : " + cFactor + setA[cRem]);
            }
            else if (test <= 63)
            {
                Console.WriteLine($"Integer: " + test + " = Hexadecimal no. : " + cFactor + setA[cRem]);
            }
            else if (test <= 47)
            {
                Console.WriteLine($"Integer: " + test + " = Hexadecimal no. : " + cFactor + setA[cRem]);
            }
            else if (test <= 31)
            {
                Console.WriteLine($"Integer: " + test + " = Hexadecimal no. : " + cFactor + setA[cRem] );
            }
            else if (test <= 15)
            {
                
                Console.WriteLine($"Integer: " + test + " = Hexadecimal no. : " + setA[cRem] );
            }         
            else if (test > 100)
            {
                Console.WriteLine("Please choose a valid number.");
            }
            
        }


        static void Main(string[] arg)
        {
            
            Console.WriteLine("Please enter an integer from betweeen 1 and 100 : ");       
            int e = Convert.ToInt32(Console.ReadLine());

            // Convert integer to hexadecimal via ToString("X") - https://stackoverflow.com/questions/1139957/convert-integer-to-hexadecimal-and-back-again
            string g = e.ToString("X");
            Console.WriteLine("System Generated Hexadecimal no. : " + g);

            hexadecimal(e);
           
        }

    }
}
