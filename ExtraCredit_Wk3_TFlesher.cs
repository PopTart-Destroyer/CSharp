//T. J. Flesher
//Assignment 3 Extra Credit
//CIS243-T301 - Bellevue University

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Playground
{
    class ExtraCredit_Wk3_TFlesher
    {
        public static void Main(string[] args)
        {
            float hourly_wage;
            float hours_worked;
            float ot_hours = 0;
            const float ot_rate = 1.5f;
            float gross_pay = 0;
            float ot_gross_pay = 0;
            float net_pay = 0;

            Console.Write("Enter pay rate: ");
            while(!float.TryParse(Console.ReadLine(), out hourly_wage))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.Write("Please enter pay rate again: ");
            }
            Console.Write("Enter hours worked: ");
            while (!float.TryParse(Console.ReadLine(), out hours_worked))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.Write("Please enter hours worked again: ");
            }

            //compute gross weekly w/ overtime
            ot_hours = hours_worked - 40;
            if (ot_hours > 0)
            {
                ot_gross_pay = (hourly_wage * ot_rate) * ot_hours;
            }
            
            //sum gross pay
            gross_pay = hourly_wage * (hours_worked - ot_hours) + ot_gross_pay;

            //compute net pay (gross pay minus withholdings)
            if (gross_pay > 1000)
            {
                net_pay = gross_pay * .28f;
            }
            if (gross_pay > 600 && gross_pay <= 1000) {
                net_pay = gross_pay * .21f;
            }
            if (gross_pay <= 600)
            {
                net_pay = gross_pay * .10f;
            }

            Console.WriteLine(); //blank space

            Console.WriteLine($"Grosspay is {gross_pay:C} and net pay is {gross_pay - net_pay:C}");
        }


    }
}
