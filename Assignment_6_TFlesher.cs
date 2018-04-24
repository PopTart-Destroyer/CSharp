//T. J. Flesher
//Assignment 6.1
//CIS243-T301 - Bellevue University
//*********************************
//Develop a C# console application that computes the hypotenuse of a right triangle.  The computation of the hypotenuse
//of a right triangle is based on the Pythagorean Theorem: c2 = a2 + b2 and the hypotenuse, c ("long side") of the triangle
//can be computed with the formula the hypotenuse is equal to the square root of the side a squared plus side b squared.
//The application should take as many side pairs inputs as the user desires and calculate each until the user enters a zero
//for both side one and side two(sentinel loop).You should use at least two(2) Math class methods.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Playground
{
    class Assignment_6_TFlesher
    {
        static void displayHypontenuse(double h)
        {
            Console.WriteLine($"\nThe hypontenuse is: {h}");
        }

        static void calculateRightAngle(double aSide, double bSide)
        {
            double hypotonuse = 0d;
            int powerOf = 2;
            //calculate using 2 Math class methods
            hypotonuse = Math.Sqrt(Math.Pow(aSide, powerOf) + Math.Pow(bSide, powerOf));

            //display results
            displayHypontenuse(hypotonuse);
        }

        static void getSides()
        {
            double a, b;
            //greetings
            Console.WriteLine("Welcome to the computation of the hypontenuse!");
            Console.WriteLine("** To exit program a 0 (zero) has to be entered");
            Console.WriteLine("   into the first and second side inputs.\n");
            //get user input
            Console.Write("Enter the length of the first side: ");
            while(!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input - numerical only!");
                Console.Write("Enter the length of the first side: ");
            }
            Console.Write("Enter the length of the second side: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input - numerical only!");
                Console.Write("Enter the length of the second side: ");
            }
            //sentinel loop (repeat as necessary until zero is entered for both inputs)
            while(a != 0 || b != 0)
            {
                //call method w/ two values
                calculateRightAngle(a, b);

                Console.Write("\nEnter the length of the first side: ");
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Invalid input - numerical only!");
                    Console.Write("Enter the length of the first side: ");
                }
                Console.Write("Enter the length of the second side: ");
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Invalid input - numerical only!");
                    Console.Write("Enter the length of the second side: ");
                }

            }
            
        }
        
        static void Main(string[] args)
        {
            getSides();
        }

    }
}
