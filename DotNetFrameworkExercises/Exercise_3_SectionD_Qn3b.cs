using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkExercises
{
    class Exercise_3_SectionD_Qn3b
    {

        // Exercise 3 - Section D - Qn 3b
        // Guess the Number Game: Write a C# program that would let you guess the number that the computer has in its “mind”. 
        // Computer thinks of an integer between 0 and 9.
        // a. The program uses the random number function to first “think of” a number.
        // It should then prompt you for a guess. If your guess is correct, 
        // then it would congratulate you and tell out how many attempts that you took to make the guess.
        // b. Modify the program you wrote in 3(a) so that in addition to the basic guessing
        // function, it would also say “You are a Wizard!” if you succeed in the first two
        // attempts or say “You are a good guess” if you make it next three attempts else it
        // would say “You are lousy!” Every time you make a wrong guess, the program
        // would prompt “Try again” and accept another guess.The program repeats until
        // you have made the correct guess.

            // My attempt:
        static void Main (String[]args)
        {
            Console.WriteLine("Welcome to the Guessing Game, Please key in a random number");
            int B = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int A = rnd.Next(9);
            int Guesses = 1;



            while (B != A)
            {
                Guesses++;
                /*
                if (B != A)
                {
                    Console.WriteLine("Try Again");
                    B = Convert.ToInt32(Console.ReadLine());
                } */

                Console.WriteLine("Try Again");
                B = Convert.ToInt32(Console.ReadLine());

            }        
            if (B==A && Guesses <= 2)
            {
                   Console.WriteLine(" You are a Wizard");
                   
            }

            if (B == A && Guesses > 2 && Guesses <= 5)
            {
                   Console.WriteLine("Congratulations, You are a good guess");
                  
            }

            if (B == A && Guesses > 5) 
            {
                    Console.WriteLine("You are Lousy");
                    
            }

            Console.WriteLine($"Number of Guesses Made = {Guesses}");

        }

    }
}
