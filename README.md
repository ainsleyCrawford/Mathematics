# Mathematics
This console application holds manifold functions that each enact a mathematical phenomenon. The user is invited to input arguments. The current build contains methods for the Fibonacci sequence, prime numbers, triangular numbers and factorials.  
The objectives of this project are twofold: to improve by problem-solving ability and my knowledge of C#.

## Table of Contents
- [User Interface](#user-interface)
- [Fibonacci Sequence](#the-fibonacci-sequence)  
- [Prime Numbers](#prime-numbers)  
- [Triangular Numbers](#triangular-numbers)  
- [Factorials](#factorials)
- [Hexagonal Numbers](#hexagonal-numbers)  

## User Interface
Upon opening the application the user is welcomed and presented with the exhaustive list of functions:

    Console.WriteLine("Welcome, user! Type the number which corresponds to the function you would like to use:");
Each number represents a case in a switch statement that calls a particular function via its class. For instance, to case to call the triangular numbers method, `TriangularLoop()`, in the triangular numbers class, `Triangular_Numbers`, is the following: `case 3: Triangular_Numbers.TriangularLoop();`.

To make each function interactive, the user is invited to input an argument to pass in. This has been achieved in each method using the TryParse method which reads an integer from the console. This argument is verified as the condition for an if statement which returns the message "Invalid Input" for invalid inputs. The code block below presents the general structure used to filter user input for each function:

    if (Int32.TryParse(Console.ReadLine(), out input))  
      {...}  
    else {Console.WriteLine("Invalid input");}  
## The Fibonacci Sequence
### Description
The Fibonacci sequence, one of the most well-known mathematical formulae, is formed by, beginning with the numbers 0 and 1, continually adding the sum of the two preceding numbers to the sequence. This gives the following: 
> 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, ad infinitum.

The Fibonacci sequence may be observed in nature. For instance hurricanes and the shape of human faces follow the rule. Applications of the sequence includes music, architecture and, interestingly for us, Agile. In the latter, Agile-team members choose a Fibonacci number from 1 to 21 to estimate either the time or effort required for a user story. 
### Logic
*n<sub>i</sub> = n<sub>i-1</sub> + n<sub>i-2</sub>*.

This sequence requires two numbers to be added to generate a third, so three variables were initialised as follows: `int a = 0; int b = 1; int c = 0;`. A fourth, `d`, is the user-specified limit of the Fibonacci sequence. While `c < d`, `c` is printed to the console before `c` is assigned the value of `a + b`, `a` assigned the value of `b` and `b` assigned the value of `a`.
## Prime Numbers
### Description
A positive integer that is the product of two smaller numbers is called composite; all other positive integers greater than 1 are prime. Prime numbers are prominent in number theory because every composite may be factorised into a unique set of prime numbers. This function lists all prime numbers up to a user-specified upper limit.
### Logic
## Triangular Numbers
### Description
If a particular number of equally spaced dots can form an equilateral triangle (Figure 1), that number may be called triangular.

    O           O O         O O O       O O O O         O O O O O        O O O O O O         O O O O O O O
                 O           O O         O O O           O O O O          O O O O O           O O O O O O
                              O           O O             O O O            O O O O             O O O O O
                                           O               O O              O O O               O O O O
                                                            O                O O                 O O O
                                                                              O                   O O
                                                                                                   O
*Figure 1: The first seven triangular numbers represented diagrammatically.*
This function, thus, reads a a user input (which must be a positive whole number) and sums every integer from 1 through this number.
### Logic
## Factorials
### Description
To find the factorial of a positive integer multiply that integer by all lesser positive integers. Thus, the factorial of five is found by multiplying five by four, three and two, resulting in 120.
### Logic
## Hexagonal Numbers
### Description
Beginning with 1 every other [triangular number](#triangular-numbers) is a hexagonal number. Figure 2 illustrates that a hexagonal number is one where that number of dots forms the outline(s) of regular hexagons where all hexagons share a single vertex.

    O             O O             O O O              O O O O                  O O O O O
                O     O         O       O          O         O              O           O
                  O O         O   O O     O      O   O O O     O          O   O O O O     O
                                O     O O      O   O       O     O      O   O         O     O
                                  O O O          O   O O     O O      O   O   O O O     O     O
                                                   O     O O O          O   O       O     O O
                                                     O O O O              O   O O     O O O
                                                                            O     O O O O
                                                                              O O O O O
*Figure 2: The first five hexagonal numbers represented diagrammatically. The bottom-left vertex is shared.*
### Logic
