using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_1_SectionB_Qn7
    {
        // Exercise 1 - Ssection B - Qn 7
        // ABC Taxi Company has the following meter charges based on the kilometres travelled.
        // Minimum fixed charge: $2.40
        // In addition the fare would be computed at 40 cents per kilometer.
        // E.g. If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4

        // My Attempt:
        static void Main(String[] args)
        {
            Console.Write("Please key in total distance travelled (in KM) to find total fare charges: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Total Fare Charges = $ {(number * 0.4 + 2.4)}");
        }

    }
}
