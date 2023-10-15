using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    internal class Pentagonal_Numbers
    {
        internal static void PentagonalLoop()
        {
            int n;
            Console.Write("Enter a value for n to find the corresponding nth pentagonal number: ");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int i = 1, diff = 1, pentagon = 0;
                while (i <= n)
                {
                    pentagon += diff;
                    diff += 3;
                    i++;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The nth square number of {n} is {pentagon}.");
            }
            else Error.InvalidInput();

            Menus.Second_Menu("pentagon");
        }
    }
}
