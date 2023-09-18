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
                int numbersTolimit = 1;
                List<int> primeNumbers = new List<int>();
                while (numbersTolimit < limit)
                {
                    if (!compositeNumbers.Contains(numbersTolimit)) primeNumbers.Add(numbersTolimit);
                    numbersTolimit++;
                }
                for (int i = 0; i < primeNumbers.Count - 1; i++)
                {
                    Console.Write(primeNumbers[i] + ", ");
                }
                Console.WriteLine(primeNumbers.Last() + "."); //Need exception handling
            }
            else Console.WriteLine("Invalid input");

            Menus.Second_Menu("prime");
        }
    }
}
