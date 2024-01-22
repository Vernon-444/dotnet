using System;

class LetterGrade
{
    public static string LetterGradeCalc(decimal grade)
    {
        string letterGrade = "A";

        switch (grade)
        {
            case decimal g when g >= 90:
                letterGrade = "A";
                break;
            case decimal g when g >= 80:
                letterGrade = "B";
                break;
            case decimal g when g >= 70:
                letterGrade = "C";
                break;
            case decimal g when g >= 60:
                letterGrade = "D";
                break;
            default:
                letterGrade = "F";
                break;
        }

        return letterGrade;
    }
}