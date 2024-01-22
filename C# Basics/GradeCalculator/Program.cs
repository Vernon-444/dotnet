using System;

class GradeCalculator
{
    static void Main()
    {
        decimal[] sophiaGrades = new decimal[] { 93, 87, 98, 95, 100 };
        decimal[] nicolasGrades = new decimal[] { 80, 83, 82, 88, 95 };
        decimal[] zahriahGrades = new decimal[] { 84, 96, 73, 85, 79 };
        decimal[] jeongGrades = new decimal[] { 90, 92, 98, 100, 97 };

        decimal sophiaAverage = AverageCalculator.Average(sophiaGrades);
        decimal nicolasAverage = AverageCalculator.Average(nicolasGrades);
        decimal zahriahAverage = AverageCalculator.Average(zahriahGrades);
        decimal jeongAverage = AverageCalculator.Average(jeongGrades);

        string sophiaLetterGrade = LetterGrade.LetterGradeCalc(sophiaAverage);
        string nicolasLetterGrade = LetterGrade.LetterGradeCalc(nicolasAverage);
        string zahriahLetterGrade = LetterGrade.LetterGradeCalc(zahriahAverage);
        string jeongLetterGrade = LetterGrade.LetterGradeCalc(jeongAverage);

        Console.WriteLine($"Student\tGrade");
        Console.WriteLine($"Sophia\t{sophiaAverage} {sophiaLetterGrade}");
        Console.WriteLine($"Nicolas\t{nicolasAverage} {nicolasLetterGrade}");
        Console.WriteLine($"Zahriah\t{zahriahAverage} {zahriahLetterGrade}");
        Console.WriteLine($"Jeong\t{jeongAverage} {jeongLetterGrade}");

    }
}