using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_5_SectionH_Qn6

    // Exercise 5 - Section H - Qn 6
    // Write a static method: Substitute(string s, char c1, char c2) that would return a string.
    // The method should find all occurrences of the character c1 in the string s and substitute
    // c1 with character c2.The new word so formed would be the return value of this method.

        // My Attempt:
    {
        static string Substitute(string s, char c1, char c2)
        {
          
            if (s.Contains(c1))
            {
                s = s.Replace(c1, c2);
                Console.WriteLine("After replacing '" + c1 + "' in input, the new " +
                    "string is: " + s);
            }
            else
            {
                Console.WriteLine("The character '" + c1 + "' is not found in input.");
            }
            return s;
        }

        static void Main (string []arg)
        {
            Console.WriteLine("Please enter a phrase or sentance:");
            string entry = Console.ReadLine();

            Console.WriteLine("Please enter an alphabet or character: ");
            
            // converting string to char
            char g = char.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another alphabet or character to replace the previous: ");

            // converting string to char
            char h = char.Parse(Console.ReadLine());

            Substitute(entry, g, h);

        }
    }
}
