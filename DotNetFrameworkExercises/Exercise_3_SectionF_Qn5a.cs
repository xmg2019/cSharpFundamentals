using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
 
    class Exercise_3_SectionF_Qn5a
    {
        // Exercise 3 - Section F - Qn 5a

        // The marks obtained by five students in Programming course are as below:
        // John: 63 marks, Venkat: 29, Mary: 75, Victor: 82, Betty: 55
        // Write a program that would take store the above information in two arrays (one for
        // Name and one for Marks.The program would then print two reports:
        // a. First report sorted in descending order of the Marks (i.e. student rank)
        // b. Second report sorted on student names alphabetically.

            // My Attempt:
        static void Main (String[]args)
        {
            string[] Name = new string[5]{"John", "Venkat","Mary","Victor","Betty"};
            int[] Mark = new int[5] {63, 29, 75, 82, 55};

            for (int i = 0; i < Mark.Length; i++)
            {
                for(int j = i+1; j<Mark.Length; j++) // j is always a step ahead of i, hence, it must start with i+1 //
                {
                    if (Mark[j]>Mark[i]) 
                    {
                        int temp = Mark[i]; // SWAP block for marks
                        Mark[i] = Mark[j];
                        Mark[j] = temp;

                        string pemt = Name[i]; // SWAP block for name, following & in parallel with marks
                        Name[i] = Name[j];
                        Name[j] = pemt;

                    }
                }
            }
            
            for(int p=0; p<Name.Length; p++)
            {
                Console.WriteLine($"{Name[p]} \t{Mark[p]}");
            }

           
        }
    }
}
