using System;

namespace Mathematics
{
    internal class Menus
    {
        internal static void Start_Menu()
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
                        Console.Write($"{function} is not an option. ");
                        Start_Menu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
                Start_Menu();
            }
            Console.Read();
        }
        public static void Second_Menu(string currentFunction)
        {
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
                        case "triangle":
                            Triangular_Numbers.TriangularLoop();
                            break;
                        case "factorial":
                            Factorial.PrintFactorial();
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