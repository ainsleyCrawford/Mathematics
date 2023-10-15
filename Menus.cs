using System;

namespace Mathematics
{
    internal static class Menus
    {
        internal static void Start_Menu()
        {
            Console.WriteLine("Enter the number which corresponds to the function you would like to use: \n " +
                "1 - Fibonacci Sequence; \n 2 - Prime Numbers; \n 3 - Factorial; \n 4 - Triangular Numbers; \n 5 - Square Numbers; \n 6 - Pentagonal Numbers; \n 7 - Heaxagonal Numbers;");
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
                        Factorial.PrintFactorial();
                        break;
                    case 4:
                        Triangular_Numbers.TriangularLoop();
                        break;
                    case 5:
                        Square_Numbers.SquareLoop();
                        break;
                    case 6:
                        Pentagonal_Numbers.PentagonalLoop();
                        break;
                    case 7:
                        Hexagonal_Numbers.HexagonalLoop();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{function} is not an option.");
                        Console.ResetColor();
                        Start_Menu();
                        break;
                }
            }
            else
            {
                Error.InvalidInput();
                Console.ResetColor();
                Start_Menu();
            }
        }
        internal static void Second_Menu(string currentFunction)
        {
            Console.ResetColor();
            Console.WriteLine("\n\nKey 1 to continue with this function, 2 to return to the main menu, or any other key to close the program.");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    switch (currentFunction)
                    {
                        case "fibonacci":
                            Fibonacci_Numbers.Fibonacci();
                            break;
                        case "prime":
                            Prime_Numbers.Prime();
                            break;
                        case "factorial":
                            Factorial.PrintFactorial();
                            break;
                        case "triangle":
                            Triangular_Numbers.TriangularLoop();
                            break;
                        case "square":
                            Square_Numbers.SquareLoop();
                            break;
                        case "pentagon":
                            Pentagonal_Numbers.PentagonalLoop();
                            break;
                        case "hexagon":
                            Hexagonal_Numbers.HexagonalLoop();
                            break;
                    }
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Start_Menu();
                    break;
                default:
                    break;
            }
        }
    }
}