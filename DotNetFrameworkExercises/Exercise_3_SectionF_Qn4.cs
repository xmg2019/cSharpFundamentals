using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 3 - Section F - Qn 4
    // The C# language gives facilities for changing cases all to upper or lower - however, not
    // to title case. Write a program that would convert a given sentence/phrase to title case.
    // Example: “institute of systems science” => “Institute Of System Science”

        // My Attempt:
    class Exercise_3_SectionF_Qn4
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Please enter a Title Phrase all in lower case");
            String Phrase = Console.ReadLine();
            String NPhrase = Phrase.Replace("."," ").Replace(","," ").Replace("?"," ").Replace(";"," ").Replace(";"," ").Replace("!","");
            String[] Words = NPhrase.Split(' '); // String.Split uses space to split phrase into Words


            for (int A=0; A<Words.Length; A++) // counter of the words in the string 
            {
                int chalen = Words[A].Length; // length of characters in a word e.g no. of characters in "Institute" 

                if (chalen==1) // NOTE : LENGTH count starts from '1'!!! // meant for 1st word in the phrase
                {
                    Words[A] = Words[A].Substring(0, 1).ToUpper(); //1st character of word to upper case
                }
                else if (chalen>1) // meant for subsequent word in the phrase => " "space + word ... can start with "if"
                {
                    Words[A] = Words[A].Substring(0, 1).ToUpper() + Words[A].Substring(1, chalen - 1);
                }
            }
            // reconstruction of the phrase

            String NWords= ""; 

            for (int A=0; A<Words.Length;A++)
            {
                NWords = NWords+Words[A];

                if (A!=Words.Length) // basically all the words
                {
                    NWords = NWords+" ";
                }
            }

            Console.WriteLine(NWords);


            /*for (int i = 0; i < Words.Length; i++) // words.length is the no. of words of split phrase
            {
                Words[i] = Words[i][0].ToString().ToUpper() + Words[i].Substring(1, Words[i].Length - 1);
                // count of words & not count of cha in thw word
                //1st cha of each word convert to string

             }*/

            /*foreach (var word in Words)
            {
               Console.WriteLine($"{word}");
            }*/

        }
    }
}
