using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a list to store the numbers
        List<int> numbers = new List<int>();

        // Step 2: Ask the user to enter numbers until they enter 0
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int userInput;
        while (true)
        {
            // Ask for user input
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 0)
            {
                break; // Exit the loop when the user enters 0
            }
            numbers.Add(userInput); // Add the number to the list
        }

        // Step 3: Compute the sum of the numbers
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        // Step 4: Compute the average of the numbers
        double average = (double)sum / numbers.Count;

        // Step 5: Find the largest number in the list
        int largest = int.MinValue;
        foreach (var num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        // Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        // Stretch Challenge - Find the smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (var num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Stretch Challenge - Sort the list and display the sorted numbers
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}