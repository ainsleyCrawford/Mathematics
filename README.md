# Mathematics
This console application holds manifold functions that each enact a mathematical phenomenon. The user is invited to input arguments. The current build contains methods for the Fibonacci sequence, prime numbers, triangular numbers and factorials.  
The objectives of this project are twofold: to improve by problem-solving ability and my knowledge of C#.

## Table of Contents
- [Fibonacci Sequence](#the-fibonacci-sequence)  
- [Prime Numbers](#prime-numbers)
- [Factorials](#factorials)
- [Triangular Numbers](#triangular-numbers)  
- [Square Numbers](#square-numbers)
- [Pentagonal Numbers](#pentagonal-numbers)
- [Hexagonal Numbers](#hexagonal-numbers)  
- [User Interface](#user-interface)

## The Fibonacci Sequence
### Description
The Fibonacci sequence, one of the most well-known mathematical formulae, is formed by, beginning with the numbers 0 and 1, continually adding the sum of the two preceding numbers to the sequence. This gives the following:  
<p align="center"><i>0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, ad infinitum.</i></p>

The Fibonacci sequence may be observed in nature. For instance hurricanes and the shape of human faces follow the rule. Applications of the sequence includes music, architecture and, interestingly for us, Agile. In the latter, Agile-team members choose a Fibonacci number from 1 to 21 to estimate either the time or effort required for a user story. 
### Logic
*n<sub>i</sub> = n<sub>i-1</sub> + n<sub>i-2</sub>*.

This sequence requires two numbers to be added to generate a third, so three variables were initialised as follows: `int a = 0; int b = 1; int c = 0;`. A fourth, `d`, is the user-specified limit of the Fibonacci sequence. While `c < d`, `c` is printed to the console before `c` is assigned the value of `a + b`, `a` assigned the value of `b` and `b` assigned the value of `a`.
## Prime Numbers
### Description
A positive integer that is the product of two smaller numbers is called composite; all other positive integers greater than 1 are prime. Prime numbers are prominent in number theory because every composite may be factorised into a unique set of prime numbers. This function lists all prime numbers up to a user-specified upper limit.
### Logic
Given that all positive integers are either composite or prime, and all composite numbers are multiples of prime numbers, the solution chosen was to add all composite numbers to a list and print to the console all numbers not in this list. The for loop `for (int divisor = 2; divisor <= Math.Sqrt(i); divisor++)` divides every integer from up to the user-specfied limit against divisors which increment from two to the square root of the limit. It was observed that surpassing the square root is excessive because all composite numbers have a prime factor less than the square root.
## Factorials
### Description
To find the factorial of a positive integer multiply that integer by all lesser positive integers. Thus, the factorial of five is found by multiplying five by four, three and two, resulting in 120. This is written notationally as *5! = 5 x 4 x 3 x 2 x 1 = 120*.
### Logic
<p align="center"><i>n! = n x (n - 1) x (n - 2) x ... x 2 x 1</i>.</p>

The following for loop multiplies the variable `factorial` by the next increment of `i` until the user-specified input `n`:  

    for (int i = 1; i <= n; i++) 
    { 
        factorial *= i;
    }
## Triangular Numbers
### Description
If a particular number of equally spaced dots can form an equilateral triangle (*Figure 1*), that number may be called triangular.

    O         O O         O O O         O O O O         O O O O O         O O O O O O         O O O O O O O
               O           O O           O O O           O O O O           O O O O O           O O O O O O
                            O             O O             O O O             O O O O             O O O O O
                                           O               O O               O O O               O O O O
                                                            O                 O O                 O O O
                                                                               O                   O O
                                                                                                    O
*Figure 1: The first seven triangular numbers represented diagrammatically.*

This function, thus, reads a a user input (which must be a positive whole number) and sums every integer from 1 through this number.
### Logic
Following the pattern in *Figure 1*, two variables were initialised: `int i = 1`, where `i` is the iteration; and `int triangle = 0`, which represents triangular numbers. The following while loop was, then, sufficient: 

    while (i <= n)
    { 
        triangle += i;
        i++;
    }
## Square Numbers
### Description
A number of equally space dots that may form a square (*Figure 2*) is a square number.

    O        O O        O O O        O O O O        O O O O O        O O O O O O        O O O O O O O
             O O        O O O        O O O O        O O O O O        O O O O O O        O O O O O O O
                        O O O        O O O O        O O O O O        O O O O O O        O O O O O O O
                                     O O O O        O O O O O        O O O O O O        O O O O O O O
                                                    O O O O O        O O O O O O        O O O O O O O
                                                                     O O O O O O        O O O O O O O
                                                                                        O O O O O O O
*Figure 2: The first seven square numbers represented diagrammatically.*

Inspection of *Figure 2* reveals that from the first square number to the second is an increase of three dots, from the second to the third is an increase of five, and from the third to the fourth is an increase of seven. This pattern of the additional number of dots increases by two each time is persistent and is easily coded. 
### Logic
Declaring and initialising `int i = 1, difference = 1, square = 0;`, where `i` is the iteration, `diff` is the increase in the area from the previous square number to the current one and `square` is the area of the current square number, the square number of a given input, `n`, is output by the following loop. The System.Math.Abs() method extends functionality to negative numbers by returning the absolute value of `n` to the loop.
    
    while (i <= Math.Abs(n))
    { 
        square += diff;
        diff += 2;
        i++
    }
## Pentagonal Numbers
### Description
A pentagonal number is to a pentagon that which a triangular number and a square number are to a triangle and a square, respectively. Unlike the first two concepts, a visual representation of a pentagonal number (*Figure 3*) cannot be rotationally symmetrical.

    O         O O           O O O             O O O O               O O O O O                O O O O O O
             O   O         O O   O           O O O   O             O O O O   O              O O O O O   O
               O          O   O   O         O O   O   O           O O O   O   O            O O O O   O   O
                            O   O          O   O   O   O         O O   O   O   O          O O O   O   O   O
                              O              O   O   O          O   O   O   O   O        O O   O   O   O   O
                                               O   O              O   O   O   O         O   O   O   O   O   O
                                                 O                  O   O   O             O   O   O   O   O
                                                                      O   O                 O   O   O   O
                                                                        O                     O   O   O
                                                                                                O   O
                                                                                                  O
*Figure 3: The first six pentagonal numbers represented diagrammatically. The leftmost vertex is shared.*

Some analysis reveals that the additional number of dots increases by three with each subsequent increase between pentagonal number iterations.
### Logic
Minor modificatons of the [square numbers](#square-numbers) logic provides a satisfactory solution.

    int i = 1, diff = 1, pentagon = 0;
    while (i <= n)
    {
        pentagon += diff;
        diff += 3;
        i++;
    }
## Hexagonal Numbers
### Description
Beginning with 1, every other [triangular number](#triangular-numbers) is a hexagonal number. Figure 4 illustrates that a hexagonal number is one where that number of dots form the outline(s) of regular hexagons where all hexagons share a single vertex.

    O          O O              O O O                  O O O O                      O O O O O
             O     O          O       O              O         O                  O           O
               O O          O   O O     O          O   O O O     O              O   O O O O     O
                              O     O O          O   O       O     O          O   O         O     O
                                O O O              O   O O     O O          O   O   O O O     O     O
                                                     O     O O O              O   O       O     O O
                                                       O O O O                  O   O O     O O O
                                                                                  O     O O O O
                                                                                    O O O O O
*Figure 4: The first five hexagonal numbers represented diagrammatically. The bottom-left vertex is shared.*

### Logic
Alternating triangular numbers are hexagonal in this manner: 1, ~~3~~, 6, ~~10~~, 15, ~~21~~, 28, ~~36~~, 45, ~~55~~, 66, ~~78~~, ad infinitum. Table 1 helps us to further understand this relationship: *n<sub>h</sub> = 2\*n<sub>t</sub> - 1*. For instance, the fourth hexagonal number (*n<sub>h</sub> = 4*) and the seventh triangular number (*n<sub>t</sub> = 7*) are equal (*28*).

|n              |1              |2              |3              |4              |5              |6              |7              |
|:-------------:|:-------------:|:-------------:|:-------------:|:-------------:|:-------------:|:-------------:|:-------------:|
|Triangles      |1              |3              |**6**          |10             |**15**         |21             |**28**         |
|Hexagons       |1              |**6**          |**15**         |**28**         |45             |66             |91             |

*Table 1: A visual aid to deduce the relationship between triangular and hexagonal numbers with respect to n.*

Thus, to modify the triangular-number while loop into a hexagonal-number while loop, the condition was edited by replacing `n` with `(n*2)-1`, which gave the following: `while (i <= (n*2)-1) { hexagon += i; i++; }`.
## User Interface
The Main method contains only two statements: `Console.Write("Welcome, user! ");` and `Menus.Start_Menu();`. The logic behind this is to allow the user to cycle through the other program methods as much as he desire before returning to the Main method, and thus, closing the console application.

Upon opening the application the user is welcomed and presented with the exhaustive list of functions:

    Console.WriteLine("Welcome, user! Type the number which corresponds to the function you would like to use:");
Each number represents a case in a switch statement that calls a particular function via its class. For instance, the case to call the triangular numbers method, `TriangularLoop()`, in the triangular numbers class, `Triangular_Numbers`, is the following: `case 4: Triangular_Numbers.TriangularLoop();`.

To make each function interactive, the user is invited to input an argument to pass in. This has been achieved in each method using the TryParse method which reads an integer from the console. This argument is verified as the condition for an if statement which returns the message "Invalid Input" for invalid inputs. The code block below presents the general structure used to filter user input for each function:

    if (Int32.TryParse(Console.ReadLine(), out n))  
      // function logic
    else Error.InvalidInput(); 
Regardless of whrther the function logic or exception path is taken, the function invocates `Menus.Second_Menu()` before terminating, passing in a string that represents the function from which the menu is being called, e.g.,

    Menus.Second_Menu("triangle");
At this point another switch statement reads the user's key press to either recall the function that it was called from, call the menu of functions (`Start_Menu`), or to exit the program.
