using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    // Exercise 5 - Section H - Qn 10
    // Write a static method MatrixMultiply(int[,] A, int [,] B) that will perform a matrix multiplication and return another 2 dimensional array. 
    // Matrix multiplication is done as follows:

        // My Attempt:
    class Exercise_5_SectionH_Qn10
    {
        static int[,] MatrixMultiply(int[,] A, int[,] B)
        {
            // need to declare the size of array, to fit the size of A * B
             int[,] C = new int[A.GetLength(0), B.GetLength(1)];

            for (int j=0; j<A.GetLength(0); j++)
            {
                for(int k=0; k<B.GetLength(1); k++)
                {
                    for(int g=0; g<A.GetLength(1); g++)
                    {
                        // need to add to the empty array 
                        C[j, k] += A[j, g] * B[g, k];
                       // C[j, k] = A[j, g] * B[g, k];
                    }
                                  
                    Console.WriteLine(C[j,k]);                   
                }               
            }

            return C;
        }

        static void Main(string[] arg)
        {
            // fixed array
            int[,] C = new int[,] { { 2, 4 }, { 3, 5 }, { 6, 2 }, { 3, 4 } };
      
            int[,] D = new int[,] { { 2, 1, 4 }, { 2, 3, 5 } };

            MatrixMultiply(C, D);

            // resultant matrix
            // | 12 14 28 |
            // | 16 18 37 |
            // | 16 12 34 |
            // | 14 15 32 |

            // food for thoughts: lyrandom generated array
            // https://stackoverflow.com/questions/20776768/2d-array-in-c-sharp-with-random-numbers
        }

    }
}
