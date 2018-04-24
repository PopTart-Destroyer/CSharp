//T. J. Flesher
//Assignment 6 Extra Credit
//CIS243-T301 - Bellevue University
//*********************************
//•	Create a console program where you will implement variables that are needed for this program and will 
//  implement the code within Main and any static methods that are called.
//•	You will need variables for temperature, minimum temperature, maximum temperature, average temperature,
//  total of temperatures and a count variable.
//•	Use a loop to call a static void calculate method four times, passing temperature, minimum temperature,
//  maximum temperature, average temperature and total temperature by reference and pass count by value.
//•	In the calculate method ask the user for a single temperature entry, add it to the total, determine the
//  minimum and maximum temperature for the current call to the method and compute the current average.
//•	When the loop in Main has taken all four entries and done the calculations call a static void display
//  method to display the output for the min, max and average temperature for the four entries.
//  You will pass the min temp, max temp and average temp.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Playground
{
    class ExtraCredit_Wk6_TFlesher
    {
        static void Main(string[] args)
        {
            int count = 0;
            double temperature = 0.0, minTemp = 500.0, maxTemp = 0.0, avgTemp = 0.0, total = 0;

            while (count < 4)  //this is a counted loop
            {

                //input data
                calcTemps(ref temperature, ref minTemp, ref maxTemp, ref avgTemp, ref total, count);
                count++;   //increment the counter
            }
            outputTemps(minTemp, maxTemp, avgTemp);
        }

        static void calcTemps(ref double temperature, ref double minTemp, ref double maxTemp, ref double avgTemp, ref double total, int count)
        {
            Console.Write("Please enter the average temperature for week " + (count + 1) + " of the month:  ");
            temperature = Convert.ToDouble(Console.ReadLine());

            //calculate the total of all the temperatures - this will later be used to calculate the average
            total = total + temperature;  //this is an accumulator to obtain a total of all 4 temperatures

            //calculate the minimum temperature
            if (temperature < minTemp)
                minTemp = temperature;

            //calculate the maximum temperature
            if (temperature > maxTemp)
                maxTemp = temperature;

            avgTemp = total / (count + 1);  //calculate the average temperature
        }
        static void outputTemps(double minTemp, double maxTemp, double avgTemp)
        {
            //output data
            Console.WriteLine("The lowest temperature for the month was :  " + minTemp + " degrees.  ");
            Console.WriteLine("The highest temperature for the month was :  " + maxTemp + " degrees.  ");
            Console.WriteLine("The average temperature for the month was:  " + avgTemp + " degrees.  ");
        }
    }
}
