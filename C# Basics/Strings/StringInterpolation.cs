using System;

public class StringInterpolation
{
    public static void PrintName()
    {
        string firstName = "John";
        string lastName = "Doe";
        string fullName = $"{firstName} {lastName}";
        Console.WriteLine(fullName);

        int version = 11;
        string updateText = "Do not update to Windows";
        string updateMessage = $"{updateText} {version}";
        Console.WriteLine(updateMessage);

        string projectName = "C# Basics";
        Console.WriteLine($@"C:\Output\{projectName}\Data");
    }
}
