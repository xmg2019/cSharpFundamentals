using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_3_SectionF_Qn1a
    {
        // Exercise 3 - Section F - Qn 1a
        // Program to count the number of vowels in a given phrase and print out the number of
        // each vowel. (a, e, i, o & u are vowels)
        // a. Write a program to read a phrase from the console and count the number of vowels there are in the phrase.
        // You should substring one character at a time and match it to the vowels and increment the counter.

            // My Attempt: 
        static void Main (String[]args)
        {
            Console.Write("Write a word containing vowels (in lower case): ");
            string Word = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == 'a' || Word[i] == 'e' || Word[i] == 'i' || Word[i] == 'o' || Word[i] == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of Vowels in the entered word = {count}");
            

           
            /* char v1 = 'a';
           int v11 = 'a'; 

           char v2 = 'e';
           int v22 = v2;

           char v3 = 'i';
           int v33 = v3;

           char v4 = 'o';
           int v44 = v4;

           char v5 = 'u';
           int v55 = v5;

           string[] characters = Word.Split();*/





        }
    }
}
