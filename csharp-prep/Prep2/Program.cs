using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        float gradePercentage = float.Parse(Console.ReadLine());

        // Step 2: Determine the Letter grade using if-else statements
        string letterGrade = "";

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Step 3: Determine the "+" or "-" sign based on the last digit
        string gradeSign = "";
        int lastDigit = (int)gradePercentage % 10;

        if (letterGrade != "F")
        {
            if (lastDigit >= 7)
            {
                gradeSign = "+";
            }
            else if (lastDigit < 3)
            {
                gradeSign = "-";
            }
        }

        // Step 4: Handle special cases for "A+" and "F" grades
        if (letterGrade == "A" && gradeSign == "+")
        {
            gradeSign = ""; // No A+ grade, so remove the "+" sign
        }
        else if (letterGrade == "F")
        {
            gradeSign = ""; // No F+ or F- grade, so no sign
        }

        // Step 5: Output the final grade with the sign
        Console.WriteLine($"Your letter grade is {letterGrade}{gradeSign}.");

        // Step 6: Determine if the student passed or not
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations on passing!");
        }
        else
        {
            Console.WriteLine("Keep trying, you'll get it next time!");
        }
    }
}