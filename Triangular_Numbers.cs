using System;

namespace Mathematics
{
    internal class Triangular_Numbers
    {
        internal static void TriangularLoop()
        {
            int n;
            Console.Write("Enter a value for n to find the corresponding nth triangular number: ");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int i = 1, triangle = 0;
                while (i <= n)
                {
                    triangle += i;
                    i++;
                }
                Console.WriteLine($"The nth triangular number of {n} is {triangle}.");
            }
            else Console.WriteLine("Invalid input");

            Menus.Second_Menu("triangle");
        }
    }
}
