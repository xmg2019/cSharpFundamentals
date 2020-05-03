using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionB_Qn9
    {
        // Exercise 1 - Section B - Qn 9
        // In the ABC Taxi Company problem above, calculate the fare so that the fare is always rounded upwards to the nearest 10 cents. 
        // This is harder than the previous problem and requires your ingenuity.
        // You can move the decimal points by one place by multiplying
        // or dividing a real number with 10

        // My Attempt:
        static void Main(String[] args)
        {
            Console.Write("Please key in total distance travelled(in KM): ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Total Charges BEFORE rounding up to the nearest 10 cents = ${number*0.4+2.4 : 0.00}");
            Console.WriteLine($"Total Charges AFTER rounding up to nearest 10 cents = ${Math.Round((number * 0.4 + 2.4 + 0.04), 1, MidpointRounding.AwayFromZero)}");
            
            // when adding 0.04 to the input before rounding off (however, this
            // is not a gd way as this may only work for the 3 nos. (0, 3.3, 10.23) provided but not others)
            // Corrections to Follow

            // Math.Round(int dec., int decimal place, MidpointRounding.AwayFromZero);   
        }
    }

}
