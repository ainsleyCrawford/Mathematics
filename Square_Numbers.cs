using System;

namespace Mathematics
{
    internal class Square_Numbers
    {
        internal static void SquareLoop()
        {
            int n;
            Console.Write("Enter a value for n to find the corresponding nth square number: ");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int i = 1, diff = 1, square = 0;
                while (i <= n)
                {
                    square += diff;
                    diff += 2;
                    i++;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The nth square number of {n} is {square}.");
            }
            else Error.InvalidInput();

            Menus.Second_Menu("square");
        }
    }
}