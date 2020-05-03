using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 5 - Section H - Qn11
    // Declare a delegate: double DoubleOps(double x) that represent method that will perform some double operation
    // Write a static method ProcessArray(double[] arr, DoubleOps ops) that will return an array that has the same size as arr, 
    // and apply the delegate on each of the element of arr and assign it to the corresponding elements in the new array.
    // Use ProcessArray method to get a new array that contains the square root of the elements of the original array 
    // and a new array that contains the square of the original array.

        // My Attempt:

    class Exercise_5_SectionH_Qn11
    {

        // delegate <return type> <delegate-name> <parameter list>
        delegate double DoubleOps(double x);

        static Array ProcessArray(double [] arr, DoubleOps ops)
        {
            double[] newArr = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = ops(arr[i]);
                Console.WriteLine(newArr[i]);
            }

            return newArr;
        }

        static double Rt (double s)
        {
            s = Math.Sqrt(s);
            return s;
        }

        static double Sq (double h)
        {
            h = Math.Pow(h, 2);
            return h;
        }

        static void Main (string[] arg)
        {
            
            Console.WriteLine("Please enter a number between 1 to 10");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a list of " + size + " numericals with space in between :");
            
            // convert the list of numbers entered into a double[] array
            double[] imputArr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Double.Parse(arrTemp));
   
            DoubleOps op1 = new DoubleOps(Rt);
            DoubleOps op2 = new DoubleOps(Sq);

            Console.WriteLine("\nSquare Root of Input: ");
            ProcessArray(imputArr, op1);

            Console.WriteLine("\nSquare of Input: ");
            ProcessArray(imputArr, op2);

        }

    }
}
