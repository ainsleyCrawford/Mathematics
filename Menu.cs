using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    internal class Menu
    {
        internal static void User_Interface()
        {
            Console.WriteLine("Enter the number which corresponds to the function you would like to use: \n " +
                "1 - Fibonacci Sequence; \n 2 - Prime Numbers; \n 3 - Triangular Numbers; \n 4 - Factorial; \n 5 - Heaxagonal Numbers;");
            int function;
            if (Int32.TryParse(Console.ReadLine(), out function))
            {
                switch (function)
                {
                    case 1:
                        Fibonacci_Numbers.Fibonacci();
                        break;
                    case 2:
                        Prime_Numbers.Prime();
                        break;
                    case 3:
                        Triangular_Numbers.TriangularLoop();
                        break;
                    case 4:
                        Factorial.PrintFactorial();
                        break;
                    case 5:
                        Hexagonal_Numbers.HexagonalLoop();
                        break;
                    default:
                        Console.Write("{0} is not an option. ", function);
                        User_Interface();
                        break;
                }
            }
            else
            {
                Console.Write("Invalid input");
                User_Interface();
            }
            Console.Read();
        }
    }
}