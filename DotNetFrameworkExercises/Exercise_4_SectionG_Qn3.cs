using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_4_SectionG_Qn3
    {

        // Exercise 4 - Section G - Qn 3
        // The marks of students are stored in a two dimensional array with the subjects represented in columns 
        // and the students in the rows. That is Row 1 would pertain to Student 1 and the scores that this student 
        // has obtained is stored in various columns in row 1. Assuming that there are 12 students in a class and 4 subjects,
        // write a program that would do the following:
        // a. Compute the total marks obtained each student.
        // b. Compute the class average (and standard deviation* - optional) of Marks for each subject.
        // c. Determine the overall average of marks for the whole class for each subjects.
        // d. Compute the standard deviation of Marks for each subject


        // My Attempt:
        static void Main(String[] args)
        {
         
            double[,] Marks = new double[12, 4] { { 56, 84, 68, 29 }, { 94, 73, 31, 96 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 }, { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, { 81, 15, 27, 30 }, { 21, 70, 100, 22 }, { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 } };
            String[] studentNames = new string[12] { "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S10", "S11", "S12" };

            List<double> scoreperstudent = new List<double>();

            List<double> averages = new List<double>();

            double[] Total = new double[] { }; 

            double[] averagePerSubject = new double[] { };

           

            for (int j = 0; j < studentNames.Length; j++)
            {
                double sum = 0;

                for (int k = 0; k < Marks.GetLength(1); k++)
                {
                    sum += Marks[j, k];
                }

                scoreperstudent.Add(sum);

                // Console.WriteLine(sum);
                // Console.WriteLine(scoreperstudent[j]);

                Total = scoreperstudent.ToArray();

                // a. Comppute total marks obtained each student
                Console.WriteLine("Total mark for" + " " + studentNames[j] + " is:" + Total[j]);

                // b. Compute the class average (and standard deviation* - optional) of Marks for each subject.
                Console.WriteLine("Average mark for" + " " + studentNames[j] + " = " + Total[j]/Marks.GetLength(1));

                Console.WriteLine("");
            }



            // c. Determine the overall average of marks for the whole class for each subjects.

            double overallAverage = 0;

            for (int g = 0; g < Marks.GetLength(1); g++)
            {
                double ss = 0;
                
                
                for (int h = 0; h < studentNames.Length; h++)
                {
                    ss += Marks[h, g];
                }

                int gg = g + 1;

                ss = ss / studentNames.Length;

                averages.Add(ss);

                averagePerSubject = averages.ToArray();

                Console.WriteLine("Overall average mark for subject " + gg + " = " + ss);

                overallAverage += ss;

            }
            overallAverage = overallAverage / Marks.GetLength(1);
            Console.WriteLine("Overall average mark for all subjects = " + overallAverage);



            // d. Compute the standard deviation of Marks for each subject

            double noOfStudent = studentNames.Count();

            double sumOfV = 0;
            double sumOfV1 = 0;
            double sumOfV2 = 0;
            double sumOfV3 = 0;

            for (int t = 0; t < studentNames.Length; t++)
            {
                                
                double d = Marks[t,0] - averagePerSubject[0];
                double d1 = Marks[t, 1] - averagePerSubject[1];
                double d2 = Marks[t, 2] - averagePerSubject[2];
                double d3 = Marks[t, 3] - averagePerSubject[3];

                // Check
                // Console.WriteLine(d);

                double vSubj = Math.Pow(d,2);
                double vSubj1 = Math.Pow(d1,2);
                double vSubj2 = Math.Pow(d2,2);
                double vSubj3 = Math.Pow(d3, 2);

                // Check
                // Console.WriteLine(vSubj);

                sumOfV += vSubj;
                sumOfV1 += vSubj1;
                sumOfV2 += vSubj2;
                sumOfV3 += vSubj3;
               
            }

            // Check
            // Console.WriteLine(sumOfV);

            Console.WriteLine("");
            Console.WriteLine($" Variance for subject 1: {(sumOfV / noOfStudent)} \n " +
               $"Variance for subject 2: {(sumOfV1 / noOfStudent)} \n " +
               $"Variance for subject 3: {(sumOfV2 / noOfStudent)} \n" +
               $" Variance for subject 4: {(sumOfV3 / noOfStudent)}");


            Console.WriteLine("");
            Console.WriteLine($" Standard Deviation for subject 1: {Math.Sqrt(sumOfV/noOfStudent)} \n " +
                $"Standard Deviation for subject 2: {Math.Sqrt(sumOfV1 / noOfStudent)} \n " +
                $"Standard Deviation for subject 3: {Math.Sqrt(sumOfV2 / noOfStudent)} \n" +
                $" Standard Deviation for subject 4: {Math.Sqrt(sumOfV3 / noOfStudent)}"); 

        }
    }
}

