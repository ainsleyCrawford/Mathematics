using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Improve program using methods which are called by the user from the console
            Console.Write("Welcome, user! Type the number which corresponds to the function you would like to use:");
            Console.WriteLine("1 - Fibonacci Sequence;");
            Console.WriteLine("2 - Prime Numbers;");
            Console.WriteLine("3 - Triangular Numbers;");
            Console.WriteLine("4 - Factorial;");
            int function;
            if (Int32.TryParse(Console.ReadLine(), out function))
            {
                // Switch statement
                switch (function)
                {
                    case 1:
                        Console.WriteLine("Fibonacci!");
                        break;
                    case 2:
                        Console.WriteLine("Prime!");
                        break;
                    case 3:
                        Console.WriteLine("Triangular!");
                        break;
                    case 4:
                        Console.WriteLine("Factorial!");
                        break;
                    default:
                        Console.WriteLine("Pardon?");
                        break;
                }
            } else {
                Console.WriteLine("Invalid input");
            }
            
            //Printing Fibonacci numbers less than 500
            //Fibonacci_Numbers.Fibonacci();
            //Prime numbers under 100
            //Prime_Numbers.Prime();
            //Printing the triangular number of n
            //Triangular_Numbers.TriangularLoop(6); //using a while loop
            //Triangular_Numbers.TriangularFormula(6); //using a formula
            //Printing the factorial of n
            //Factorial.PrintFactorial(3);
            //Factorial.PrintFactorial(6);
            Console.Read();
        }
    }
    internal class Fibonacci_Numbers
    {
        internal static void Fibonacci()
        {
            Console.WriteLine("The Fibonacci numbers below 500 are the following:");
            int a = 0; int b = 1; int c = 0;
            while (c < 500)
            {
                Console.WriteLine(c);
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
    internal class Prime_Numbers
    {
        internal static void Prime()
        {
            Console.WriteLine("The exhaustive list of less-than-two-digit prime numbers is:");
            List<int> compositeNumbers = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                for (int divisor = 2; divisor <= Math.Sqrt(i); divisor++)
                {
                    if (i % divisor == 0)
                    {
                        compositeNumbers.Add(i);
                    }
                }
            }
            int numbersTo100 = 1;
            while (numbersTo100 < 100)
            {
                if (compositeNumbers.Contains(numbersTo100))
                {
                }
                else
                {
                    Console.WriteLine(numbersTo100);
                }
                numbersTo100++;
            }
        }
    }
    internal class Triangular_Numbers
    {
        internal static void TriangularLoop(int n)
        {
            int i = 1; int triangle = 0;
            while (i <= n)
            {
                triangle = triangle + i;
                i++;
            }
            Console.WriteLine("Using a while loop, The nth triangular number of {0} is {1}", n, triangle);
        }
        internal static void TriangularFormula(int n)
        {
            Console.WriteLine("Using a formula, the triangular number of {0} is {1}", n, n*(n + 1)/2);
        }
    }
    internal class Factorial
    {
        internal static void PrintFactorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("The factorial of {0} is {1}", n, factorial);
        }
    }
}
