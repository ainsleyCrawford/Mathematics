using System;

namespace Mathematics
{
    internal class Fibonacci_Numbers
    {
        internal static void Fibonacci()
        {
            int d;
            Console.Write("Enter an upper limit for the Fibonacci sequence: ");
            if (Int32.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("The Fibonacci numbers below " + d + " are the following:");
                int a = 0, b = 1, c = 0;
                while (c < d)
                {
                    Console.Write(c);
                    c = a + b;
                    string punctuationMark = (c < d) ? ", " : ".";
                    Console.Write(punctuationMark);
                    a = b;
                    b = c;
                }
            }
            else Console.WriteLine("Invalid input");

            Console.WriteLine("\n\nKey 1 to continue with this function, 2 to return to the main menu, or any other key to close the program.");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Fibonacci(); ;
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
