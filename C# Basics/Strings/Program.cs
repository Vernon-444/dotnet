class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green; // Change text color to green
        Console.WriteLine("String Formatting");
        Console.ResetColor(); // Reset the color to default

        StringFormatting.PrintInvoices();
        
        Console.ForegroundColor = ConsoleColor.Green; // Change text color to green
        Console.WriteLine("\nString Concatenation");
        Console.ResetColor(); // Reset the color to default

        StringConcat.PrintName();

        Console.ForegroundColor = ConsoleColor.Green; // Change text color to green
        Console.WriteLine("\nString Interpolation");
        Console.ResetColor(); // Reset the color to default

        StringInterpolation.PrintName();

        Console.ForegroundColor = ConsoleColor.Red; // Change text color to green
        Console.WriteLine("\nUnit Challenge");
        Console.ResetColor(); // Reset the color to default

        UnitChallenge.Challenge();
    }
}
