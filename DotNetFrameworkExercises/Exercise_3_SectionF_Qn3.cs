using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_3_SectionF_Qn3
    {
        // Exercise 3 - Section F - Qn 3
        // Modify program 2 to accommodate sentences which may have upper case letters,
        // punctuation or space that may need to be ignored while doing the test.
        // Examples:
        // A Santa at NASA
        // Mr. Owl ate my metal worm

            // My Attempt: 
        static void Main (String[]args)
        {
            Console.WriteLine("Please enter a word or phrase: ");
            String Word = Console.ReadLine();
            String NWord = Word.ToLower(); // transverse the word/sentence to lower case
            
            // command for replacing white spaces/punctuations " " with nothing"" --> (to be replaced, replacing item)
            String NPWord = NWord.Replace(" ","").Replace(".", "").Replace("?","").Replace(",","").Replace(";","").Replace("!","").Replace(":","");
                      

            String RWord = new String (NPWord.Reverse().ToArray()); // to reverse the whole word/phrase

            
            Console.Write($"*Entry in Reverse Order: {RWord}* ");

            if (RWord.Equals(NPWord)) // alternatively, can use RWord == NPWord 
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
