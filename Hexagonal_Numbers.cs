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
            else Console.WriteLine("Invalid input");

            Console.WriteLine("\n\nKey 1 to continue with this function, 2 to return to the main menu, or any other key to close the program.");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    HexagonalLoop(); ;
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
