using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_3_SectionF_Qn5b
    {

        // Exercise 3 - Section F - Qn 5b
        // The marks obtained by five students in Programming course are as below:
        // John: 63 marks, Venkat: 29, Mary: 75, Victor: 82, Betty: 55
        // Write a program that would take store the above information in two arrays (one for
        // Name and one for Marks.The program would then print two reports:
        // a. First report sorted in descending order of the Marks (i.e. student rank)
        // b. Second report sorted on student names alphabetically.

            // My Attempt:
        static void Main(String[]args)
        {
            string[] Name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] Mark = new int[5] { 63, 29, 75, 82, 55 };

            for (int i = 0; i < Name.Length; i++) // initializing for loop to start counter for the 1st set of number
            {
                for (int j = i + 1; j<Name.Length; j++)
                {
                    if (String.Compare(Name[j],Name[i])>0) 
                    {
                        string temp = Name[i];
                        Name[i] = Name[j];
                        Name[j]= temp;

                        int pemt = Mark[i];
                        Mark[i] = Mark[j];
                        Mark[j] = pemt;
                    }

                }

            }

            for (int p=0; p<Name.Length;p++)
            {
                Console.WriteLine($"{Name[p]}\t{Mark[p]}");
            }
        } //https://docs.microsoft.com/en-us/dotnet/api/system.string.compareto?view=netframework-4.8
    }
}
