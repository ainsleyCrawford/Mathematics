using System;

namespace Mathematics
{
    internal class Hexagonal_Numbers
    {
        internal static void HexagonalLoop()
        {
            int n;
            Console.Write("Enter a value to calculate its corresponding hexagonal number: ");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                if (n > 0)
                {
                    int i = 1, hexagon = 0;
                    while (i <= (n * 2) - 1)
                    {
                        hexagon += i;
                        i++;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    string oI = Ordinal_Indicator.GetSuffix(n);
                    Console.WriteLine($"The {n}{oI} hexagonal number is {hexagon}.");
                }
                else Error.LesserThanOne();
            }
            else Error.InvalidInput();

            Menus.Second_Menu("hexagon");
        }
    }
}
