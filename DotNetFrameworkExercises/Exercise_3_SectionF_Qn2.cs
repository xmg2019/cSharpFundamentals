using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 3 - Section F - Qn 2

    // Write a C# program to determine if a given string is a palindrome.
    // Your program should take a string from the console and test if the word is a palindrome:
    // A palindrome is a word/phrase that reads the same forwards or backwards.
    // Examples: ABBA, 747, radar, madam

         // My Attempt:
    class Exercise_3_SectionF_Qn2
    {
        static void Main (String[]args)
        {
            Console.WriteLine("Please enter a word (in lower case): ");
            String Word = Console.ReadLine();
            String RWord = new string(Word.Reverse().ToArray());
            Console.Write($"*Entered Word in Reverse Order: {RWord}* ");

            if (RWord==Word)
            {
                Console.Write("The word entered IS a Palidrome. ");
            }
            else
            {
                Console.Write("The word entered is NOT a Palidrome.\n ");
            }

           
        }
    }
}

