using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_3_SectionE_Qn01
    {
        // Exercise 3 - Section E - Qn 01
        // Incorrect 
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter an integer:");
            Double N = Convert.ToDouble(Console.ReadLine());
            Double A = 0;
            Double B = 0;
            N = A * B;

            for (A=0; B<=N; A++)
            {
                Console.WriteLine($"Value of A: {A}, B:{B} & N: {N}");
            }
                

        }

    }
}
