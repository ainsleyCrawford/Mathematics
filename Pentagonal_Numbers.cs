using System;

namespace Mathematics
{
    internal class Pentagonal_Numbers
    {
        internal static void PentagonalLoop()
        {
            int n;
            Console.Write("Enter a value to calculate its corresponding pentagonal number: ");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                if (n > 0)
                {
                    int i = 1, diff = 1, pentagon = 0;
                    while (i <= n)
                    {
                        pentagon += diff;
                        diff += 3;
                        i++;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    string ordinalIndicator = "th";
                    if (n % 10 == 1 && n != 11) ordinalIndicator = "st";
                    else if (n % 10 == 2 && n != 12) ordinalIndicator = "nd";
                    else if (n % 10 == 3 && n != 13) ordinalIndicator = "rd";
                    Console.WriteLine($"The {n}{ordinalIndicator} pentagonal number is {pentagon}.");
                }
                else Error.LesserThanOne();
            }
            else Error.InvalidInput();

            Menus.Second_Menu("pentagon");
        }
    }
}
