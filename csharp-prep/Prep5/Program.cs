using System;

class Program
{
    // Function to display the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt for the user's name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt for the user's favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to square the number and return the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result with the user's name and the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }

    static void Main(string[] args)
    {
        // Step 1: Call DisplayWelcome to display the welcome message
        DisplayWelcome();

        // Step 2: Prompt the user for their name and favorite number
        string userName = PromptUserName();
        int userFavoriteNumber = PromptUserNumber();

        // Step 3: Square the user's favorite number
        int squaredNumber = SquareNumber(userFavoriteNumber);

        // Step 4: Display the result
        DisplayResult(userName, squaredNumber);
    }
}