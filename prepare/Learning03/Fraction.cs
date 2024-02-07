using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction() {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int wholeNumber) {
        numerator = wholeNumber;
        denominator = 1;
    }

    public Fraction(int top, int bottom) {
        numerator = top;
        denominator = bottom;
    }

    public string GetFractionString() {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{numerator}/{denominator}";
        return text;
    }

    public double GetDecimalValue() {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)numerator / (double)denominator;
    }
}