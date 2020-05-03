using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionB_Qn9_Correction
    {
        // Exercise 1 - Section B - Qn 9 - CORRECTIONS
        // In the ABC Taxi Company problem above, calculate the fare so that the fare is always rounded upwards to the nearest 10 cents. 
        // This is harder than the previous problem and requires your ingenuity.
        // You can move the decimal points by one place by multiplying
        // or dividing a real number with 10

        // My Attempt:
        static void Main(String[] args)
        {
            Console.Write("Please key in total distance travelled(in KM): ");
            double V = Convert.ToDouble(Console.ReadLine());
            double V2 = Math.Ceiling((V * 0.4 + 2.4) * 10);
            // Math.Ceiling returns the smallest integral value that is greater than or equal to 
            // the specified double-precision floating-point number.
            V2 = V2 / 10;
            Console.WriteLine("Total Charges AFTER rounding up to nearest 10 cents: $ {0:0.00}", V2);          
        }
    }
}
