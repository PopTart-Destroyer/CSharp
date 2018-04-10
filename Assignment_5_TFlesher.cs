//T. J. Flesher
//Assignment 5.1
//CIS243-T301 - Bellevue University
//*********************************
//Develop a C# console application that displays the two (2) following patterns separately, one below the other. 
//Use for loops (hint:  nested) to generate the patterns. All asterisks should be displayed by a single statement of 
//the form Console.Write("*"); which displays the asterisks leading up to the number value shown in the example. 
//A statement of the form Console.WriteLine(); can be used to move to the next line. Note the sequence of each number in turn.  
//Remember that this is two separate sets of loops which are used to generate these two patterns.  
//You will need to deduce how the numbers are computed (they are the result of a computation) and where that computation will 
//be placed in the loop structures.  You may not hardcode the displayed numbers into your loops.


using System;

namespace Playground
{
    class Assignment_5_TFlesher
    {
        static void Main(string[] args)
        {
            int i, j;
            //count up
            for (i = 0; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                if (i > 0 & (i * 2) % 2 == 0)
                {
                    Console.Write(i * 2);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //count down 
            for (i = 10; i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                if (i > 0 & (i * 2) % 2 == 0)
                {
                    Console.Write(i * 2);
                }
                Console.WriteLine();
            }
        }
    }
}
