//T. J. Flesher
//Assignment 7 Extra Credit
//CIS243-T301 - Bellevue University
//*********************************
//You will write a console program that will generate a random number based on lower and upper range inputs.
//Create a console program where you will implement variables that are needed for this program and will implement 
// the code within Main and any static methods that are called.
//The program will take inputs for a range of integer numbers, a low end of the range and a high end of the range.
// These two integer numbers will be used to generate a random number that will be displayed.
//The program will consist of Main and three void methods.
//The first method will request the low number for the range and the high number in the range.  It will then pass the 
// two range numbers to a second method.
//The second method will take the two numbers passed to it and will generate a random number within the range.  
// It will then pass the two range numbers and the random number to the third method.
//The third method will take the three numbers passed to it and display then to the console in the format indicated
// in the sample output below.
//Main will only have one line of code which will call the first method.
//The first method will call the second method and the second method will call the third.

using System;

namespace Playground
{
    class ExtraCredit_Wk7_TFlesher
    {
        //declare Random class
        private static Random rnd = new Random();
        static void firstMethod()
        {
            int lowRange = 0;
            int highRange = 0;
            //get user input for low/high range
            Console.Write("Enter the low integer range number: ");
            while(!int.TryParse(Console.ReadLine(), out lowRange))
            {
                Console.WriteLine("Numeric values only!");
                Console.Write("Enter the low integer range number: ");
            }
            Console.Write("Enter the high integer range number: ");
            while (!int.TryParse(Console.ReadLine(), out highRange))
            {
                Console.WriteLine("Numeric values only!");
                Console.Write("Enter the high integer range number: ");
            }
            //call second method
            secondMethod(lowRange, highRange);
        }
        static void secondMethod(int low, int high)
        {
            int randomNumber = rnd.Next(low, high);
            //call third method
            thirdMethod(low, high, randomNumber);
        }
        static void thirdMethod(int low, int high, int rnd)
        {
            //display randomness! LOL
            Console.WriteLine($"Random number from range {low} and {high} is {rnd}");
        }

        static void Main(string[] args)
        {
            //single line - call first method
            firstMethod();
        }
    }
}
