//T. J. Flesher
//Assignment 9 Extra Credit
//CIS243-T301 - Bellevue University
//*********************************
//•	Create a console program where you will implement variables that are needed for this program and will implement the
//   code within Main and any required static methods.
//•	Create an array that stores 6 area codes as string and a parallel array that will store 6 per-minutes rates as double.
//•	Use initializers to set the values of each array according to the following table:
//Area Code   Per Minute Rate
//      262	    0.07
//      414	    0.10
//      608	    0.05
//      715	    0.16
//      815	    0.24
//      920	    0.14

//•	Declare variables in Main for a boolean found, string area code, string minutes.
//•	call a static method to calculate the total for the minutes and pass to it the two arrays, and the variables found, 
//  area and minutes  all by reference.
//•	In the method:
//o Prompt the user to enter an area code.
//o Loop through the area array to find a match to the entered area code.
//o When the code is found in the array ask the user for the length of time for a call in minutes.
//o Calculate the cost as minutes* rate from the corresponding rate array element.
//o Display the cost to the console as currency.
//o Set found to true.
//•	If when control returns to Main, the area code was not found from Main display "Sorry - no calls allowed to area XXX".


using System;


namespace Playground
{
    class ExtraCredit_Wk9_TFlesher
    {
        static void calcTotalMinutes(ref string[] areaCode, ref double[] perMinRate, ref bool found, ref string area_code, ref string minutes)
        {
            double cost = 0.0;

            Console.Write("What are code are you calling? ");
            area_code = Console.ReadLine();

            for (int i = 0; i < areaCode.Length; i++)
            {
                if(area_code == areaCode[i])
                {
                    Console.Write("How many minutes is your call? ");
                    minutes = Console.ReadLine();
                    found = true;
                    cost = perMinRate[i] * Convert.ToInt32(minutes);
                    Console.WriteLine("Your phone call to area code {0} cost {1:C} per minute", areaCode[i], perMinRate[i]);
                    Console.WriteLine("For {0} minutes the total is {1:C}", minutes, cost);
                }
            }
            

        }

        static void Main(string[] args)
        {
            string[] arrAreaCode = { "262", "414", "608", "715", "815", "920" };
            double[] arrPerMinuteRate = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };
            bool found = false;
            string area_code = string.Empty, minutes= string.Empty;
            calcTotalMinutes(ref arrAreaCode, ref arrPerMinuteRate, ref found, ref area_code, ref minutes);
            if (found == false)
            {
                Console.WriteLine("Sorry - no calls allowed to area code {0}", area_code);
            }
        }
    }
}
