using System;


namespace Playground
{
    class Program
    {
        static void changePrices(ref double[] item_price, double pricePoint, double percent) {
            
            for (int j = 0; j < item_price.Length; j++)
            {
                if (item_price[j] < pricePoint){
                    item_price[j] += item_price[j] * percent;                    
                }
            }
        }

        static void printIt(string[] itemName, double[] itemPrice){
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
                Console.WriteLine("The price for item {0} is {1:C}",item_name[i],item_price[i]);
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
