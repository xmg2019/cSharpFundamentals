using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 5 - Section H - Qn 7
    // Write a static method: SetArray(int[] arr, int value) 
    // that would assign the value into al the elements of the array arr.

        // My Attempt: 

    class Exercise_5_SectionH_Qn7
    {
        static void SetArray(int[] arr, int value)
        {
            for (int j=0; j<arr.Length; j++)
            {
                arr[j] = value;
                Console.WriteLine(arr[j]);
            }
        }

        static void Main (string[]arg)
        {
            Console.WriteLine("Please select and choice a number between 1 to 10: ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter " + h + " numbers with a space in between: ");
            int [] p = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Console.WriteLine("Please enter a number to replace all the value in the previous entries.");
            int g = Convert.ToInt32(Console.ReadLine());

            // SetArray(integer to be set, setting integer)
            SetArray(p, g);

        }

    }
}
