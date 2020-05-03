using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_3_SectionF_Qn6
    {
        // Exercise 3 - Section F - Qn 6
        // In Neverland University, each student is identified by their matriculation number. 
        // The format of matriculation number is A00000X (alphabet A followed with 5 digits and another alphabets). The last alphabet is called as the checksum
        // The checksum can be used to validate the matriculation number. 
        // The calculation to determine the checksum is as follow:
        // - sample matriculation no. - A56742
        // - Take the first number digit and multiply with 6 // 5*6 = 30
        // - Take the second digit and multiply with 5 // 6*5 = 30
        // - Take the third digit and multiply with 4 // 7*4 = 30
        // - Take the fourth digit and multiply with 3 // 4*3 = 12
        // - Take the fifth digit and multiply with 2 // 2*2 = 4
        // - Take the fifth digit and multiply with 2 // 30 + 30 + 28 + 12 + 4 = 104
        // - Divide by 5 and take the remainder // 104%5 = 4
        // - Obtain the checksum based on the remainder value:
        // - remainder:0, checksum: O // remainder:1, checksum: P // remainder:2, checksum: Q
        // - remainder:3, checksum: R // remainder:4, checksum: S
        // - 4 mapped to "S" // "S"
        // Based on the above example, A56742S is a valid matriculation number, while A56742O is not.
        // Write a program that will ask the user to enter a matriculation number and returns whether the matriculation number is valid or not. 
        // Specifically the program should do the following:
        // - Check that the length of the input is exactly 7 characters, otherwise it’s invalid
        // - Convert the entire string to uppercase so that we don’t have to worry about case
        // - Calculate the checksum based on the rule.
        // - Check whether the last character matches the calculated checksum


        static void Main(string[] args)
        {
            Console.WriteLine("Pls enter your 7-digits matriculation number:");
            string s = Console.ReadLine();
            string cs = s.ToUpper();
            
            

            if (cs.Length==7)
            {
               
                    int d1 = Convert.ToInt32(cs.Substring(1, 1));
                    int d2 = Convert.ToInt32(cs.Substring(2, 1));
                    int d3 = Convert.ToInt32(cs.Substring(3, 1));
                    int d4 = Convert.ToInt32(cs.Substring(4, 1));
                    int d5 = Convert.ToInt32(cs.Substring(5, 1));

                    int checksum = d1 * 6 + d2 * 5 + d3 * 4 + d4 * 3 + d5 * 2;
                    int r = checksum % 5;
                   
                           
                    if (r == 0 && cs[6] == 'O')
                    {
                        Console.WriteLine("Valid");
                    }
                    else if (r == 1 && cs[6] == 'P')
                    {
                        Console.WriteLine("Valid");
                    }
                    else if (r == 2 && cs[6] == 'Q')
                    {
                        Console.WriteLine("Valid");
                    }
                    else if (r == 3 && cs[6] == 'R')
                    {
                        Console.WriteLine("Valid");
                    }
                    else if (r == 4 && cs[6] == 'S')
                    {
                        Console.WriteLine("Valid");
                    } 


                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                
            }

            else
            { 
                Console.WriteLine("Wrong Entry. Pls try again: ");
            }

        }
    }
}

