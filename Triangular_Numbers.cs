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

            Console.WriteLine("\n\nKey 1 to continue with this function, 2 to return to the main menu, or any other key to close the program.");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    TriangularLoop(); ;
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
