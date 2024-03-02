using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int numGuesses = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numGuesses++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"You made {numGuesses} guesses.");

            Console.Write("Do you want to play again? (yes/no) ");
            string playAgainInput = Console.ReadLine();

            if (playAgainInput.ToLower() == "yes")
            {
                playAgain = true;
                Console.WriteLine();
            }
            else
            {
                playAgain = false;
            }
        }
    }
}