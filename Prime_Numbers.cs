using System;
using System.Collections.Generic;
using System.Linq;

namespace Mathematics
{
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
                int numbersTolimit = 2;
                List<int> primeNumbers = new List<int>();
                while (numbersTolimit < limit)
                {
                    if (!compositeNumbers.Contains(numbersTolimit)) primeNumbers.Add(numbersTolimit);
                    numbersTolimit++;
                }
                int numberOfPrimeNumbers = primeNumbers.Count;
                if (numberOfPrimeNumbers == 0) Console.WriteLine($"\tThere are not any prime numbers less than {limit}.");
                else if (numberOfPrimeNumbers == 1) Console.WriteLine(primeNumbers[0] + ".");
                else
                {
                    for (int i = 0; i < numberOfPrimeNumbers - 2; i++) Console.Write(primeNumbers[i] + ", ");
                    Console.WriteLine($"{primeNumbers[^2]} and {primeNumbers[^1]}.");
                }
            }
            else Console.WriteLine("Invalid input");

            Menus.Second_Menu("prime");
        }
    }
}