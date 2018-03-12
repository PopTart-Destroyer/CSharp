/**
T. J. Flesher
Assignment 1.1
Bellevue University
CIS243-T301
Write an application that reads three integers, adds all three together and computes an average of the three entries
    and computes any remainder of the integer division.
A remainder represents the modulus result of dividing an even by an odd number or vice versa. Display the output.
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1;
            int input2;
            int input3;
            const int number_of_inputs = 3;
            int average;
            int remainder;

            //get user input, check validation
            Console.Write("Enter an integer score: ");
            while(!int.TryParse(Console.ReadLine(), out input1))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.Write("Please enter an integer score: ");
            }
            Console.Write("Enter an integer score: ");
            while (!int.TryParse(Console.ReadLine(), out input2))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.Write("Please enter an integer score: ");
            }
            Console.Write("Enter an integer score: ");
            while (!int.TryParse(Console.ReadLine(), out input3))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.Write("Please enter an integer score: ");
            }

            //calculation
            average = (input1 + input2 + input3) / number_of_inputs;
            remainder = average % number_of_inputs;
            Console.WriteLine("Average of " + input1 + ", " + input2 + ", " + input3 + " is " + average);
            Console.WriteLine("Remainder of " + remainder);
            Console.ReadLine();
            Console.WriteLine("Press any key to continue...");
        }
    }
}
