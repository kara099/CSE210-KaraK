using System;

class Program
{
    // Main method with proper signature
    public static void Main(string[] args)
    {
        try
        {
            // Create instances using all constructors
            Fraction fraction1 = new Fraction();  // Default 1/1
            Fraction fraction2 = new Fraction(6);  // 6/1
            Fraction fraction3 = new Fraction(6, 7);  // 6/7

            // Display fractions and their decimal values
            Console.WriteLine(fraction1.GetFractionString());
            Console.WriteLine(fraction1.GetDecimalValue());

            Console.WriteLine(fraction2.GetFractionString());
            Console.WriteLine(fraction2.GetDecimalValue());

            Console.WriteLine(fraction3.GetFractionString());
            Console.WriteLine(fraction3.GetDecimalValue());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
