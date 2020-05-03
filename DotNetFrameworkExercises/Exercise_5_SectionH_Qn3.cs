using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_5_SectionH_Qn3
    {
        // Exercise 5 - Section H - Qn 3
        // Write a static method: InString(string s1, string s2) that would return a boolean. 
        // The method should find if the string s2 occurs in s1 and return true if it occurs else it would return false. 
        // After you write the InString method, write a Main method that calls InString method.

            // My Attempt:

        static bool Instring(string s1, string s2)
        {
            /*
             * Method 01
             *
            Boolean outcome=s1.Contains(s2);
                       
            if (outcome == true)
            {
                
                Console.WriteLine("S1 CONTAINS S2, Output = " + outcome); ;
            }
            else
            {
                
                Console.WriteLine("S1 DOES NOT CONTAINS S2, Output = " + outcome);
            } */

            // Method 02

            Boolean outcome;

            if (s1.Contains(s2))
            {
                outcome = true;
                Console.WriteLine("S1 CONTAINS S2, Output = " + outcome); ;
            }
            else
            {
                outcome = false;
                Console.WriteLine("S1 DOES NOT CONTAINS S2, Output = " + outcome);
            }

            return outcome;
        }

        static void Main(String[]arg)
        {
            Console.WriteLine("Please type a message");
            String input1 = Console.ReadLine();
            input1 = input1.ToLower();

            Console.WriteLine("Please enter a word/ alphabet/ phrase");
            String input2 = Console.ReadLine();
            input2 = input2.ToLower();

            Instring(input1, input2);
        }
    }
}
