//T. J. Flesher
//Assignment 7.1
//CIS243-T301 - Bellevue University
//*********************************
//Develop a C# console application that implements two int arrays. One array will hold 10 randomly generated integer numbers,
// the second array will hold 10 integer numbers entered from the console.
//Implement 2 'for' loops, the first to fill the array using the Random class to generate 10 random integers between 1 and 100
// (see p241, section 7.9) and a second 'for' loop that will fill the second array with input entries between 1 and 100 taken from the console.
//Implement a third 'for' loop to iterate through both arrays and perform the following comparisons of the corresponding 
// (identical subscripts) array entries:
//if the entered array value is less than the corresponding random array value then print "The entered number XX is less than YY", otherwise
//if the entered array value is greater than the corresponding random array value then print "The entered number XX is greater than YY" 
// otherwise print "The entered number XX is equal to YY"
//Use the array length variable to stay within the array bounds for all three loops.

using System;

namespace Playground
{
    class Assignment_8_TFlesher
    {
        //global constants
        const int arrayLength = 10;
        const int rangeStart = 1;
        const int rangeEnd = 100;

        //Random number generator
        static int getRandom(int seed)
        {
            Random random = new Random(seed);
            int randomNumber = random.Next(1, 101);
            return randomNumber;
        }
        
        //check range of user input
        static bool RangeCheck(int a, int b, int number)
        {
            return (a <= number && number <= b);
        }
        static void Main(string[] args)
        {
            
            int[] arrOne = new int[arrayLength];
            int[] arrTwo = new int[arrayLength];

            int seed = 0; //seed for random number default value

            int userInput = 0;
            
            //implement first for loop for random int between 1 and 100
            for (int i = 0; i < arrayLength; i++)
            {
                seed = (int)DateTime.Now.TimeOfDay.Ticks + i;
                arrOne[i] = getRandom(seed);
            }

            //implement second for loop for user input
            for (int j = 0; j < arrayLength; j++)
            {
                Console.Write("Enter an integer number between 1 and 100: ");
                while (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("\nInvalid input, numeric values only!\n");
                    Console.Write("Enter an integer number between 1 and 100: ");
                }
                //while loop, checking range between 1 (rangeStart) and 100 (rangeEnd)
                while (!RangeCheck(rangeStart, rangeEnd, userInput))
                {
                    Console.WriteLine("\nEntry not in range, try again.\n");
                    Console.Write("Enter an integer number between 1 and 100: ");
                    while (!int.TryParse(Console.ReadLine(), out userInput))
                    {
                        Console.WriteLine("\n Invalid input, numeric values only!\n");
                        Console.Write("Enter an integer number between 1 and 100: ");
                    }
                }
                arrTwo[j] = userInput;
            }

            Console.WriteLine("\nResults:");

            //implement third loop, iterate through both arrays and compare
            //display results
            for(int z = 0; z < arrayLength; z++)
            {
                if (arrTwo[z] < arrOne[z])
                {
                    Console.WriteLine($"The entered number {arrTwo[z]} is less than {arrOne[z]}");
                }
                else if (arrTwo[z] > arrOne[z])
                {
                    Console.WriteLine($"The entered number {arrTwo[z]} is greater than {arrOne[z]}");
                }
                else if (arrTwo[z] == arrOne[z])
                {
                    Console.WriteLine($"The entered number {arrTwo[z]} is equal to {arrOne[z]}");
                }
            }
        }
    }
}
