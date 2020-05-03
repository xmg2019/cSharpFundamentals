using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_4_SectionG_Qn1
    {
        // Exercise 4 - Section G - Qn 1
        // A company records its monthly sales information in an array of size 12; where Sales[0] represents January sales, 
        // Sales[1] is February sales etc. 
        // After entering the data the company wants to perform some queries on the data. Write a program that would do the following:
        // a. Take in the sales for the 12 months.
        // b. Print the month when Maximum Sales is recorded.
        // c. Print the month where Minimum Sales is recorded.
        // d. Print the average monthly sales for the year.
        // Note: You may use the array initialisation inside the program for storing these.

        // My Attempt: 
        static void Main(String[] args)
        {
            // Part - Qn 1a
            string[] Month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            double[] Sales = new double [12] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120 };

            double totalSales = 0;
            double averageMonthlySales = 0;

            for (int i = 0; i < Sales.Length; i++)
            {
                // Part Qn 1a
                Console.WriteLine(" {0} \t ${1}", Month[i], Sales[i]);


                // Part Qn 1b
                double maxSales = Sales.Max();

                if (Sales[i] == maxSales)
                {
                    Console.WriteLine($" Maximum Sales and Recorded Month: ${Sales[i]} \t {Month[i]}");
                }

        

                // Part Qn 1c
                double minSales = Sales.Min();

                if (Sales[i] == minSales)
                {
                    Console.WriteLine($" Minimum Sales and Recorded Month: ${Sales[i]} \t {Month[i]}");
                }


                // Part Qn 1d
                totalSales += Sales[i];
            }
                averageMonthlySales = totalSales / 12;

                Console.WriteLine(" Average Monthly Sales for the year: $" + averageMonthlySales);
        }
    }
}
 

