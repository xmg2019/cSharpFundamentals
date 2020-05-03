using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionB_Qn8
    {
        // Exercise 1 - Section B - Qn 8
        // ABC Taxi Company has the following meter charges based on the kilometres travelled.
        // Minimum fixed charge: $2.40
        // In addition the fare would be computed at 40 cents per kilometer.
        // E.g. If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4
        // print the output so that the fare is the output is printed always rounded to nearest 10 cents 
        // and printed to two decimal places.

        // My Attempt:
        static void Main (String[]args)
        {

            Console.Write("Please key in total distance travelled (in KM) to find fare charges: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Total Fare Charges after rounding-off (to 2 dec. pl.) = ${Math.Round((number * 0.4 + 2.4),1):0.00}");

        }
    }
}
