using System;

namespace Mathematics
{
    internal class Triangular_Numbers
    {
        internal static void TriangularLoop()
        {
            int n;
            Console.Write("Enter a value to calculate its corresponding triangular number: ");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                if (n > 0)
                {
                    int i = 1, triangle = 0;
                    while (i <= n)
                    {
                        triangle += i;
                        i++;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    string oI = Ordinal_Indicator.GetSuffix(n);
                    Console.WriteLine($"The {n}{oI} triangular number is {triangle}.");
                }
                else Error.LesserThanOne();
            }
            else Error.InvalidInput();

            Menus.Second_Menu("triangle");
        }
    }
}
