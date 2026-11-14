using System;

namespace StockManagementApp_EFCore.Infrastructure
{
    public static class ConsoleLogger
    {
        public static void Header(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n==================================================");
            Console.WriteLine($"  {title}");
            Console.WriteLine("==================================================");
            Console.ResetColor();
        }

        public static void Info(string message) { Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(message); Console.ResetColor(); }
        public static void Success(string message) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(message); Console.ResetColor(); }
        public static void Warning(string message) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(message); Console.ResetColor(); }
        public static void Error(string message) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(message); Console.ResetColor(); }
    }
}