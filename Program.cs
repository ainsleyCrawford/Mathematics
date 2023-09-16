using System;
using System.Collections.Generic;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome, user! ");
            User_Interface();
        }
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
    internal class Fibonacci_Numbers
    {
        internal static void Fibonacci()
        {
            int d;
            Console.Write("Enter an upper limit for the Fibonacci sequence: ");
            if (Int32.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("The Fibonacci numbers below "+ d +" are the following:");
                int a = 0, b = 1, c = 0;
                while (c < d)
                {
                    Console.Write(c);
                    c = a + b;
                    string punctuationMark = (c < d) ? ", " : ".";
                    Console.Write(punctuationMark);
                    a = b;
                    b = c;
                }
            }
            else Console.WriteLine("Invalid input");

            Console.WriteLine("\n\nKey 1 to continue with this function, 2 to return to the main menu, or any other key to close the program.");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Fibonacci(); ;
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Program.User_Interface(); ;
                    break;
                default:
                    break;
            }
        }
    }
    internal class Prime_Numbers
    {
        internal static void Prime()
        {
            int limit;
            Console.WriteLine("Enter an upper limit for your Prime Number sequence: ");
            if (Int32.TryParse(Console.ReadLine(), out limit))
            {
                Console.WriteLine("The exhaustive list of prime numbers less than " + limit + " is:");
                List<int> compositeNumbers = new List<int>();
                for (int i = 1; i < limit; i++)
                {
                    for (int divisor = 2; divisor <= Math.Sqrt(i); divisor++)
                    {
                        if (i % divisor == 0) compositeNumbers.Add(i);
                    }
                }
                int numbersTolimit = 1;
                while (numbersTolimit < limit)
                {
                    if (!compositeNumbers.Contains(numbersTolimit)) Console.Write(numbersTolimit + ", ");
                    //{
                    //}
                    //else
                    //{
                    //    Console.Write(numbersTolimit + ", ");
                    //}
                    numbersTolimit++;
                }
            } 
            else Console.WriteLine("Invalid input");
            
            Console.WriteLine("\n\nKey 1 to continue with this function, 2 to return to the main menu, or any other key to close the program.");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Prime();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Program.User_Interface(); ;
                    break;
                default:
                    break;
            }
        }
    }
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
                    Program.User_Interface(); ;
                    break;
                default:
                    break;
            }
        }
    }
    internal class Factorial
    {
        internal static void PrintFactorial()
        {
            int n;
            Console.Write("Enter a number to find it's factorial: ");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int factorial = 1;
                for (int i = 1; i <= n; i++) factorial *= i;
                Console.WriteLine($"The factorial of {n} is {factorial}.");
            }
            else Console.WriteLine("Invalid input");

            Console.WriteLine("\n\nKey 1 to continue with this function, 2 to return to the main menu, or any other key to close the program.");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    PrintFactorial(); ;
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Program.User_Interface(); ;
                    break;
                default:
                    break;
            }
        }
    }
    internal class Hexagonal_Numbers
    {
        internal static void HexagonalLoop()
        {
            int n;
            Console.Write("Enter a value for n to find the corresponding nth hexagonal number: ");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int i = 1, hexagon = 0;
                while (i <= (n*2)-1)
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
                    Program.User_Interface(); ;
                    break;
                default:
                    break;
            }
        }
    }
}
