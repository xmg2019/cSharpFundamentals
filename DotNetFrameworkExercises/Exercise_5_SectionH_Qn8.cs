using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 5 - Section H - Qn 8
    // Write a static method: ResizeArray(int[] arr, int newSize) that would return a new array
    // with the new size and copy all the content of the old array to the new array

        // My Attempt: 

    class Exercise_5_SectionH_Qn8
    {
        static int[] ResizeArray(int[] arr, int newSize)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine("Original Array Index: " + k + " = " + arr[k]);
                
            }

            Console.WriteLine(" ");

            //Resize the original array to a new size(newSize number of elements)
            Array.Resize(ref arr, newSize);

            int[] arrNew = arr;

            for (int j=0; j<arrNew.Length; j++)
            {
                Console.WriteLine("New Array Index: " + j + " = " + arrNew[j]);
            }

             return (arr);
        }

        static void Main(string[] arg)
        {
            Console.WriteLine("Please select and choice a number between 1 to 10: ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter " + h + " numbers with a space in between: ");
            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Console.WriteLine("Please enter a new array elements size: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            ResizeArray(p, g);
        }


    }
}
