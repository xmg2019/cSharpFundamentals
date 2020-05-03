using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    
    class Exercise_5_SectionH_Qn4

    // Exercise 5 - Section H - Qn 4
    // Write a static method: FindWord(string s1, string s2) that would return an integer.
    // The method should find if the string s2 occurs in s1 and return an integer that would indicate the starting position of the word s2 in s1.
    // If the word does not occur the return value should be –1.

        // My Attempt:
    {
        static int FindWord (string s1, string s2)
        {
            Char[] arr =  s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();

            int s = 0;

            for (int j = 0; j < arr2.Length; j++)
            {

                if (arr.Contains(arr2[j]))
                {
                    s = Array.IndexOf(arr, arr2[j]);
                    Console.WriteLine("The character '" + arr2[j] + "' in the word/alphabet/phase DOES OCCUR in the message at position: " + s);
                } 
                else
                {
                    s = -1;
                    Console.WriteLine("The character '" + arr2[j] + "' in the word/alphabet/phase DOES NOT OCCUR in the message. Position = " + s);
                }
            
            }
            return s;       
        }

        static void Main (String[]arg)
        {
            Console.WriteLine("Please type a message");
            String input1 = Console.ReadLine();
            input1 = input1.ToLower();

            Console.WriteLine("Please enter a word/alphabet/phrase");
            String input2 = Console.ReadLine();
            input2 = input2.ToLower();

            FindWord(input1,input2);
        }

    }
}
