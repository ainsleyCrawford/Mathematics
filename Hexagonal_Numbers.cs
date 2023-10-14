using System;

namespace Mathematics
{
    internal class Hexagonal_Numbers
    {
        internal static void HexagonalLoop()
        {
            int n;
            Console.Write("Enter a value for n to find the corresponding nth hexagonal number: ");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int i = 1, hexagon = 0;
                while (i <= (n * 2) - 1)
                {
                    hexagon += i;
                    i++;
                }
                Console.WriteLine($"The nth hexagonal number of {n} is {hexagon}.");
            }
            else Error.InvalidInput();

            Menus.Second_Menu("hexagon");
        }
    }
}
