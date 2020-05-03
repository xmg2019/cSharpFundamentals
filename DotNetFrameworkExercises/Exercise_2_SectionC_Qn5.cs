using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_2_SectionC_Qn5
    {
        // Exercise 2 - Section C - Qn 5
        // Given a three-digit integer as input write a C# program to determine whether the number is an Armstrong number.
        // An Armstrong number is one for which the sum of each digit raised to the power of number of digits results in the number itself.
        // For a three digit number 153 = 1^3 + 5^3 + 3^3
        // Confine the input to 3 digit examples only i.e., number values 100…999.
        // Input: 100, Output: False
        // Input: 370, Output: True
        // Input: 371, Output: True
        // Input: 372, Output: False

        // My Attempt:
        static void Main(String[] args)
        {
            Console.WriteLine("Please key in a 3 digits number to find out if it is an Armstrong number:");

            /*
             
            int X = Convert.ToInt32(Console.ReadLine());
            int X1 = (X / 100);
            int X2 = (X % 10);
            int X3 = (X - (X1 * 100) - X2)/10;
            int X4 = (X1*X1*X1 + X2*X2*X2 + X3*X3*X3);
            Double X5 = Convert.ToDouble(X4);

            if (X5/X == 1)
            {
                Console.WriteLine("TRUE.The 3 digits number IS an Armstrong number");
            }
            else
            {
                Console.WriteLine("FALSE, The 3 digits number is NOT an Armstrong number");
            }

            */

            double X = Convert.ToDouble(Console.ReadLine());

            double digitinhundredsplace = Math.Floor(X / 100);
            double digitintensplace = Math.Floor(X/10) - digitinhundredsplace * 10;
            double digitinonesplace = Math.Floor(X % 10);

            double number = Math.Pow(digitinhundredsplace, 3) + Math.Pow(digitintensplace,3) + Math.Pow(digitinonesplace, 3);
            
            if (number == X)
            {
                Console.WriteLine("TRUE.The 3 digits number IS an Armstrong number");
            }
            else
            {
                Console.WriteLine("FALSE, The 3 digits number is NOT an Armstrong number");
            }
        }
    }
}
