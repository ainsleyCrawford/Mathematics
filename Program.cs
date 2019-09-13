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
            Console.Read();
        }
    }
    internal class Fibonacci_Numbers
    {
        public static void Fibonacci()
        {
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
}
