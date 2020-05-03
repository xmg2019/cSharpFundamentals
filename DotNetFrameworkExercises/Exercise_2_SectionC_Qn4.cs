using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_2_SectionC_Qn4
    {
        // Exercise 2 - Section C - Qn 4
        // ABC Taxi Company has the following meter charges based on the kilometres travelled.
        // Minimum charge: $2.40 (first 0.5 km no additional charges apply)
        // For the next 8.5 kms the rate is 4 cents for every 100 meters
        // After that: 5 cents for every 100 meters
        // In the above example you should assume that the meter falls every 100 meters. So
        // assume that if the distance travelled (i.e. input) is 12.13 km then it is rounded to 12.20
        // and the cost would be:
        // $ 2.40 (first 0.5 km) + $ 85 * 0.04 (next 8.5 km) + $ (122 -90) * 0.05 (for distance over 9.0 km) = $7.40
        // input: 0,        output: 2.4, 
        // input: 0.5,      output: 2.4,
        // input: 9,        output: 5.8,
        // input: 12.13,    output: 7.4

        // My Attempt:
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter distance travelled (in KM) to see meter charges: ");
            double X = Convert.ToDouble(Console.ReadLine());
            X = X * 1000;
            X = Math.Ceiling((X / 100));
            X = X / 10;
            if (X == 0)
            {
                Console.Write($"Total Meter Chargeable based on distance travelled = $ {(2.4 + (X * 0)):0.00}");
            }
            else if (X <= 9 && X > 0)
            {
                Console.Write($"Total Meter Chargeable based on distance travelled = $ { (2.4 + (X - 0.5) * 1000 / 100 * 0.04):0.00}");
            }
            else if (X > 9)
            {
                // Console.Write($"Total Meter Charges = $ { (5.80 + ((X - 9) * 1000 / 100) * 0.05):0.0}");
                Console.Write($"Total Meter Charges based on distance travelled = $ { (2.4 + (8.5 * 1000 / 100 * 0.04) + (X - 9) * 1000 / 100 * 0.05):0.00}");
            }

        }
    }
}
