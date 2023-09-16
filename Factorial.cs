using System;

namespace Mathematics
{
    internal class Factorial
    {
        internal static void PrintFactorial()
        {
            int n;
            Console.Write("Enter a number to find it's factorial: ");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int factorial = 1;
                for (int i = 1; i <= n; i++) factorial *= i;
                Console.WriteLine($"The factorial of {n} is {factorial}.");
            }
            else Console.WriteLine("Invalid input");

            Console.WriteLine("\n\nKey 1 to continue with this function, 2 to return to the main menu, or any other key to close the program.");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    PrintFactorial(); ;
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Menu.User_Interface(); ;
                    break;
                default:
                    break;
            }
        }
    }
}
