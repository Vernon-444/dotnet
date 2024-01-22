using System;

class AverageCalculator
{
    public static decimal Average(decimal[] grades)
    {
        decimal sum = 0;
        foreach (decimal grade in grades)
        {
            sum += grade;
        }
        return sum / grades.Length;
    }
}
