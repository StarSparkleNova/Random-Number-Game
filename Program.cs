using System;

namespace RandomNumberGame
{
    class Program
    {
        static Random random = new Random();
        static int maxGuesses = 10;

        static void Main(string[] args)
        {
            int randomNumber = GetRandomNumber();
            int numGuesses = 0;

            Console.WriteLine("Guess the random number between 1 and 100.");

            while (numGuesses < maxGuesses)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int guess) || guess < 1 || guess > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                    continue;
                }

                numGuesses++;

                if (guess == randomNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {numGuesses} tries.");
                    return;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                else
                {
                    Console.WriteLine("Too high. Try again.");
                }
            }

            Console.WriteLine($"Sorry, you ran out of guesses. The number was {randomNumber}.");
        }

        static int GetRandomNumber()
        {
            return random.Next(1, 101);
        }
    }
}
