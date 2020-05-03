using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_5_SectionH_Qn2a
    {
        // Exercise 5 - Section H - Qn 2a
        // Write a static method PrintArray(string [] arr) that doesn’t return any value.
        // This method should print out all the elements of an array to the console in any format that you prefer.

            // My attempt:

        // method doesn't return any value, then use static void
        static void PrintArray(String [] arr)
        {
          
            for(int j=0; j<arr.Length; j++)
            {
                Console.WriteLine( arr[j] );
            }
            
        }

        static void Main (string[] args)
        {
            Console.WriteLine("Please enter a message");
            String input = Console.ReadLine();

            // split the input via spacing into individual words before storing into an array
            String[] userImput = input.Split(' ');

            PrintArray(userImput);

        } 
    }
}
