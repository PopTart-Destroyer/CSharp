//T. J. Flesher
//Assignment 4.1
// Develop a C# console application that will determine the gross pay for each of three employees.
//CIS243-T301 - Bellevue University

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrossPay
{
    class Assignment_4_TFlesher
    {
        const decimal BASE_HOURS = 40m;
        const decimal OT_RATE = 1.5m;

        static void Main(string[] args)
        {
            decimal hoursWorked;
            decimal hourlyPayRate;
            decimal basePay;
            decimal otHours;
            decimal otPay;
            decimal grossPay;

            //Implement the inputs and calculations
            int i = 1;
            while(i <= 3)
            {
                //Get/Check user input
                Console.Write("Enter hourly rate: ");
                while(!decimal.TryParse(Console.ReadLine(), out hourlyPayRate))
                {
                    Console.WriteLine("Please enter a valid numerical value!");
                    Console.Write("Enter hourly rate again: ");
                }
                Console.Write("Enter hours worked: ");
                while (!decimal.TryParse(Console.ReadLine(), out hoursWorked))
                {
                    Console.WriteLine("Please enter a valid numerical value!");
                    Console.Write("Enter hours worked again: ");
                }
                //determine gross pay
                if (hoursWorked > BASE_HOURS)
                {
                    basePay = hourlyPayRate * BASE_HOURS;
                    otHours = hoursWorked - BASE_HOURS;
                    otPay = otHours * hourlyPayRate * OT_RATE;
                    grossPay = basePay + otPay;
                }
                else
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                //display results
                Console.WriteLine($"Pay for employee {i} is {grossPay:C}\n");
                
                i += 1; //increment count
            };//end while

        }
    }
}
