using System;

namespace Mathematics
{
    internal static class Error
    {
        internal static void InvalidInput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input");
        }
        internal static void LesserThanZero()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input: n must not be lesser than zero.");
        }
        internal static void LesserThanOne()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input: n must be greater than zero.");
        }
    }
}