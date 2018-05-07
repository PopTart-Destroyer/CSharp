//T. J. Flesher
//Assignment 8 Extra Credit
//CIS243-T301 - Bellevue University
//*********************************
//You will write a console program that will meet the following requirements:
//•	Create a console program where you will implement variables that are needed for this program and will implement the code within Main.
//•	Create an array that stores 10 prices.
//•	Prompt the user to enter the 10 values as currency.
//•	Access the array elements and display a sum of the 10 values.
//•	Display all of the entered values less than $5.00.
//•	Calculate the average of the 10 values.
//•	Display the average of the entered values and the entered values higher than the average.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Playground
{
    class ExtraCredit_Wk8_TFlesher
    {
        static void Main(string[] args)
        {
            const int arrLength = 10;
            const double ltPrice = 5.0;
            double[] arrPrice = new double[arrLength];
            double[] arrHighPrice = new double[0];
            double[] arrLTFive = new double[0];

            double userInput = 0.0, sum = 0.0;

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write($"Enter price {i + 1}: ");
                while(!double.TryParse(Console.ReadLine(),out userInput))
                {
                    Console.WriteLine("Invalid input, numeric values only!");
                    Console.Write($"Enter price {i + 1}: ");
                }
                arrPrice[i] = userInput;
            }

            foreach(double number in arrPrice)
            {
                sum += number;
            }
            Console.WriteLine("The sum of the values entered is: {0:C}",sum);

            //find prices less than $5
            for (int h = 0; h < arrLength; h++)
            {
                if (arrPrice[h] < ltPrice)
                {
                    Array.Resize(ref arrLTFive, arrLTFive.Length + 1);
                    arrLTFive[arrLTFive.Length - 1] = arrPrice[h];
                }
            }
            Console.Write("Prices less than {0:C}: ", ltPrice);
            foreach(double number in arrLTFive)
            {
                Console.Write("{0:C} ", number);
            }

            //find prices above average and display
            for (int j = 0; j < arrLength; j++)
            {
                if (arrPrice[j] > (sum / arrLength))
                {
                    Array.Resize(ref arrHighPrice, arrHighPrice.Length + 1);
                    arrHighPrice[arrHighPrice.Length - 1] = arrPrice[j];
                }
            }
            Console.Write("\nPrices higher than average of {0:C}: ", sum / arrLength);
            foreach(double number in arrHighPrice)
            {
                Console.Write("{0:C} ", number);
            }
            Console.WriteLine();

        }
    }
}
