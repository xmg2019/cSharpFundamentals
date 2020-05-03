using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{

    class Exercise_3_SectionF_Qn1b
    {
        // Exercise 3 - Section F - Qn 1b
        // Program to count the number of vowels in a given phrase and print out the number of
        // each vowel. (a, e, i, o & u are vowels)
        // b. Modify the above program to make your program explicitly count the number of
        // occurrences of each vowel ie: number of a’s, number of e’s etc.)

            // My Attempt:
        static void Main(String[] arg)
        {
            Console.WriteLine("Please enter a word (in lower case) containing vowels");
            string Word = Console.ReadLine();
            int CA=0, CE=0, CI=0, CO=0, CU=0; // IMPORTANT to declare this here and not below

            for (int B = 0; B < Word.Length; B++)
            {
                if (Word[B] == 'a')
                {
                   // CA = 0;
                    CA++;
                }

                if (Word[B] == 'e')
                {
                   // CE = 0;
                    CE++;
                }

                if (Word[B] == 'i')
                {
                   // CI = 0;
                    CI++;
                }

                if (Word[B] == 'o')
                {
                    //CO = 0;
                    CO++;
                }

                if (Word[B] == 'u')
                {
                    //CU = 0;
                    CU++;
                }

            }
            
            Console.WriteLine($"no. of vowels in the word entered" +
                $" \n 'A's: {CA}, \n 'E's: {CE}, \n 'I's: {CI} \n 'O's: {CO},\n 'U's: {CU}");
}   }   }    

