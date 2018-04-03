//T. J. Flesher
//Assignment 4 Extra Credit
//CIS243-T301 - Bellevue University

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ExtraCredit_Wk4_TFlesher
    {
        const double COMM1 = 0.10d;
        const double COMM2 = 0.20d;
        const double COMM3 = 0.30d;

        static void Main(string[] args)
        {
            double sales;
            int salesmanNumber;
            double empPay;

        while(true)
            {
                //prompt user for input and validate it!
                Console.Write("Enter sale # for employee: ");
                while(!int.TryParse(Console.ReadLine(), out salesmanNumber))
                {
                    Console.WriteLine("Please enter valid numeric values!");
                    Console.Write("Enter sale # from employee again: ");
                };
                //checking input for zero value, end program
                if (salesmanNumber == 0)
                {
                    Console.WriteLine("Ending Program...");
                    break;
                }
                //prompt for sales input and validate it!
                Console.Write($"Enter sales amount for employee {salesmanNumber}: ");
                while(!double.TryParse(Console.ReadLine(), out sales))
                {
                    Console.WriteLine("Please enter valid numeric values!");
                    Console.Write($"Enter sales amount for employee {salesmanNumber}: ");
                }
                //evaluate sales input
                if (sales > 3000)
                {
                    Console.WriteLine("Invalid sales entry.");
                    empPay = 0;
                }
                else if (sales >= 500 && sales <= 1000){
                    empPay = sales * COMM1;
                }
                else if (sales > 1000 && sales <= 2000)
                {
                    empPay = sales * COMM2;
                }
                else if (sales > 2000 && sales <= 3000)
                {
                    empPay = sales * COMM3;
                }
                else
                {
                    empPay = sales;
                }
                //display emp pay for employee
                Console.WriteLine($"The pay for salesman # {salesmanNumber} is {empPay}\n");
            };

        }
    }
}
