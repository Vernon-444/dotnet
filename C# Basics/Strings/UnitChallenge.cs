using System;

public class UnitChallenge
{
    public static void Challenge()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string projectName = "ACME";
        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

        Console.WriteLine("View English output:");
        Console.WriteLine("\tC:\\Output\\{projectName}\\Data.txt\n");

        // russian output with semi colon
        Console.WriteLine($"{russianMessage}:");
        Console.WriteLine("\tC:\\Output\\{projectName}\\ru-RU\\Data.txt\n");
    }
}
