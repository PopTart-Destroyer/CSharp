using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Playground
{
    class Assignment_1_TFlesher
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
            while (!int.TryParse(Console.ReadLine(), out input1))
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
            Console.WriteLine("Average of {0}, {1}, {2} is {3} with a remainder of {4}", input1 ,input2,input3,average,remainder);
            //Console.ReadLine();
            //Console.WriteLine("Press any key to continue...");
        }
    }
}
