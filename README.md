# Mathematics
This console application holds manifold functions that each enact a mathematical phenomenon. The user is invited to input arguments. The current build contains methods for the Fibonacci sequence, prime numbers, triangular numbers and factorials.  
The objectives of this project are twofold: to improve by problem-solving ability and my knowledge of C#.

## Table of Contents
- [User Interface](#user-interface)
- [Fibonacci Sequence](#the-fibonacci-sequence)  
- [Prime Numbers](#prime-numbers)  
- [Triangular Numbers](#triangular-numbers)  
- [Factorials](#factorials)
- [Cumulated Summation](#cumulated-summation)  

## User Interface
....
To make each function interactive, the user is invited to input the an argument to pass in. This has been achieved in each method using the TryParse method which reads an integer from the console. In the case of [the Fibonacci sequence function](#the-fibonacci-sequence) the input, `d`, is verified. 

  `if (Int32.TryParse(Console.ReadLine(), out d))
              {
                  Console.WriteLine("The Fibonacci numbers below "+ d +" are the following:");
                  int a = 0; int b = 1; int c = 0;
                  while (c < d)
                  {
                      Console.Write(c);
                      c = a + b;
                      if (c < d)
                      {
                          Console.Write(", ");
                      } else
                      {
                          Console.Write(".");
                      }
                      a = b;
                      b = c;
                 }
              } else {
                  Console.WriteLine("Invalid input");
              }`
## The Fibonacci Sequence
### Description
The Fibonacci sequence, one of the most well-known mathematical formulae, is formed by, beginning with the numbers 0 and 1, continually adding the sum of the two preceding numbers to the sequence. This gives the following: 
> 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, ad infinitum.

The Fibonacci sequence may be observed in nature. For instance hurricanes and the shape of human faces follow the rule. Applications of the sequence includes music, architecture and, interestingly for us, Agile. In the latter, Agile-team members choose a Fibonacci number from 1 to 21 to estimate either the time or effort required for a user story. 
### Logic


## Prime Numbers
### Description
### Logic
## Triangular Numbers
### Description
### Logic
## Factorials
### Description
### Logic
## Cumulated Summation
### Description
### Logic
