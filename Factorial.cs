using System;

namespace Mathematics
{
    internal class Factorial
    {
        internal static void PrintFactorial()
        {
            int n;
            Console.Write("Enter a number to find its factorial: ");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                if (n > -1)
                {
                    int factorial = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 2; i <= n; i++) factorial *= i;
                    Console.WriteLine($"The factorial of {n} is {factorial}.");
                    Console.ResetColor();
                }
                else Error.LesserThanZero();
            }
            else Error.InvalidInput();

            Menus.Second_Menu("factorial");
        }
    }
}
