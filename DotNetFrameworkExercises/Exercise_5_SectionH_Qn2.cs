using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_5_SectionH_Qn2
    {
        // Exercise 5 - Section H - Qn 2
        // Write a static method PrintArray(int [] arr) that doesn’t return any value.
        // This method should print out all the elements of an array to the console in any format that you prefer.

        // My attempt:

        // method doesn't return any value, then use static void
        static void PrintArray(int[] arr)
        {

            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }

        }
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a list of " + s + " numbers with a space in between each number : ");

            // convert and store input as array
            int [] userImput = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            PrintArray(userImput);
        }
    }
}
