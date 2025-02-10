public class Fraction
{
    private int numerator;
    private int denominator;

    // Constructor 1: No parameters, initializes to 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor 2: One parameter (numerator), denominator set to 1
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        denominator = 1;
    }

    // Constructor 3: Two parameters (numerator and denominator)
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this.numerator = numerator;
        this.denominator = denominator;
    }

    // Getter and Setter for Numerator
    public int GetNumerator() { return numerator; }
    public void SetNumerator(int numerator) { this.numerator = numerator; }

    // Getter and Setter for Denominator
    public int GetDenominator() { return denominator; }
    public void SetDenominator(int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this.denominator = denominator;
    }

    // Method to return the fraction as a string (fractional view)
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to return the decimal value
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}
