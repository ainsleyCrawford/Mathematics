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
    }
}