using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_4_SectionG_Qn2
    {
        // Exercise 4 - Section G - Qn 2
        // Write a C# program that would sort a numeric array in descending order using the simplified selection sort method described.
        // At the end of each pass print out the array to know the progress!

               // My Attwmpt:
        static void Main(String[] args)
        {
            Console.WriteLine("Pls enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pls enter an array of whole numbers separated by a single space ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int temp = 0;

            for (int i= 0; i < arr.Length; i++)
            {
                for (int j=0; j<arr.Length-1; j++)
                {
                    if( arr[j] > arr[j+1] )
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }             
            } foreach (var item in arr)
            {
                Console.Write(item.ToString() + " ");
            } 
        }
    }
}