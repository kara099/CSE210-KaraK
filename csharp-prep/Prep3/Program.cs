using System;

class Program
{
    static void Main(string[] args)
    {
        // Loop to allow the user to play again
        bool playAgain = true;
        while (playAgain)
        {
            // Step 1: Generate a random magic number between 1 and 100
            Random rand = new Random();
            int magicNumber = rand.Next(1, 101); // Generates a number between 1 and 100

            int userGuess = 0;
            int guessCount = 0; // To track how many guesses the user has made

            // Step 2: Keep asking for guesses until the user gets the correct number
            while (userGuess != magicNumber)
            {
                // Ask for the user's guess
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());

                // Increment the guess count
                guessCount++;

                // Step 3: Give feedback
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                }
            }

            // Step 4: Ask the user if they want to play again
            Console.Write("Do you want to play again (yes/no)? ");
            string playAgainInput = Console.ReadLine().ToLower();

            // If the user types "yes", the game will restart; otherwise, it will stop
            playAgain = playAgainInput == "yes";
        }

        // Thank the user after they are done
        Console.WriteLine("Thanks for playing!");
    }
}