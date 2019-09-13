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
            //Printing Fibonacci numbers less than 500
            Fibonacci_Numbers.Fibonacci();
            //Prime numbers under 200
            Prime_Numbers.Prime(); 
            Console.Read();
        }
    }
    internal class Fibonacci_Numbers
    {
        public static void Fibonacci()
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
        public static void Prime()
        {
            Console.WriteLine("The exhaustive list of less-than-two-digit prime numbers is:");
            List<int> compositeNumbers = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                for (int divisor = 2; divisor <= (i/2); divisor++)
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
}
