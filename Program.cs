using System;
using System.Text;


namespace Playground
{
    class Program
    {
        static void getRent(ref int[] apartment, ref int[] rent, int number)
        {
            for (int i = 0; i < apartment.Length; i++)
            {
                if (apartment[i] == number)
                {
                    printIt(apartment[i], rent[i]);
                    break;
                }
            }
        }

        static void printIt(int choice, int rent)
        {
            StringBuilder builder = new StringBuilder();
            string sStart = "Rent for apartment # ";
            string sEnd = " is $";
            builder.Append(sStart).Append(choice).Append(sEnd).Append(rent);
            string finalString = builder.ToString();
            Console.WriteLine(finalString);
        }



        public static void Main()
        {

            int[] apartment = { 123, 204, 601, 609, 612 };
            int[] rent = { 500, 750, 495, 800, 940 };
            int apartmentNumber = 0;
            
            Console.Write("Enter the apartment number: ");
            while(!int.TryParse(Console.ReadLine(), out apartmentNumber))
            {
                Console.WriteLine("\n Invalid input, numeric values only!\n");
                Console.Write("Enter the apartment number: ");
            }

            getRent(ref apartment, ref rent, apartmentNumber);

        }    
    }
}


