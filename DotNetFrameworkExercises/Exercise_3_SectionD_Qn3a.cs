using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_3_SectionD_Qn3a
    {
        // Exercise 3 - Section D - Qn 3a
        // Guess the Number Game: Write a C# program that would let you guess the number that the computer has in its “mind”. 
        // Computer thinks of an integer between 0 and 9.
        // a. The program uses the random number function to first “think of” a number.
        // It should then prompt you for a guess. If your guess is correct, 
        // then it would congratulate you and tell out how many attempts that you took to make the guess.

            // My Attempt:
        static void Main(String[] arg)
        {
            Console.WriteLine("Welcome to the Guessing Game, Please key in a random number");
            Random rnd = new Random();
            int A = rnd.Next(9);
            int B = Convert.ToInt32(Console.ReadLine());
            int Guesses = 1;
            

            while (B!=A)
            {

                if (B != A) Console.WriteLine("Please enter another number");
                B = Convert.ToInt32(Console.ReadLine());
                Guesses++;
            }
            Console.WriteLine("Congratulations, You have made the right guess!");
            Console.WriteLine($"Number of Guesses Made = {Guesses}");
        }

    }
}
