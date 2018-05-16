//T. J. Flesher
//Assignment 9.1
//CIS243-T301 - Bellevue University
//*********************************
//Develop a C# console application that implements two parallel arrays in Main, one to hold double values called item_price and
//the other to hold strings called item_name. Each array will hold 5 values.  Use an initializer to fill the item_price array 
//with the values  15.50, 50.99, 25.00, 115.49, 75.25.  Use an initializer to fill the item_name array with the values "Widget", 
//"Thingy", "Ratchet", "Clanger", "Fracker".  This application will use a method to change the corresponding prices for items 
//based on a price point and a multiplier which will require double value types.  The inputs for the price and multiplier are 
//input from the console.
//Create two static methods, one called changePrices and one called printit.When the changePrices method is called from 
//Main you should pass the item_price array by reference, the price point and price difference values input from the console to it.
//The changePrices method should loop through the item price array and check the price point to determine the increase in price 
//for each price array element.The basic computation is:
// ** if the current price is less than the price point then set the price equal to the current price plus the current price times
//    the price multiplier
//In the printit method print the item name and the corresponding item price to the console as shown in the output example below

using System;


namespace Playground
{
    class Assignment_9_TFlesher
    {
        static void changePrices(ref double[] item_price, double pricePoint, double percent)
        {

            for (int j = 0; j < item_price.Length; j++)
            {
                if (item_price[j] < pricePoint)
                {
                    item_price[j] += item_price[j] * percent;
                }
            }
        }

        static void printIt(string[] itemName, double[] itemPrice)
        {
            for (int x = 0; x < itemPrice.Length; x++)
            {
                Console.WriteLine("The price for item {0} is {1:C}", itemName[x], itemPrice[x]);
            }
        }

        static void Main(string[] args)
        {
            double[] item_price = { 15.50, 50.99, 25.00, 115.49, 75.25 };
            string[] item_name = { "Widget", "Thingy", "Ratchet", "Clanger", "Fracker" };
            double price_point = 0.0;  //price point
            double percentage_change = 0.0; //percentage price change

            for (int i = 0; i < item_price.Length; i++)
            {
                Console.WriteLine("The price for item {0} is {1:C}", item_name[i], item_price[i]);
            }

            Console.Write("Enter the price cutoff point (eg $15.00): ");
            while (!double.TryParse(Console.ReadLine(), out price_point))
            {
                Console.Write("Invalid input, numeric values only!");
                Console.Write("Enter the price cutoff point (eg $15.00): ");
            }
            Console.Write("Enter the percentage price change (eg 0.25): ");
            while (!double.TryParse(Console.ReadLine(), out percentage_change))
            {
                Console.Write("Invalid input, numeric values only!");
                Console.Write("Enter the percentage price change (eg 0.25): ");
            }

            changePrices(ref item_price, price_point, percentage_change);
            printIt(item_name, item_price);

        }
    }
}
