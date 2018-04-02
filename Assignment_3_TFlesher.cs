//T. J. Flesher
//Assignment 3.1
//Create class to evaluate input 1 and 2 and print out results
// and get user inputs for each value
//CIS243-T301 - Bellevue University

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Playground
{
    class changeValue
    {
        public int value1;
        public int value2;

        //properties
        public int Value1
        {
            get { return value1; }
            set { value1 = value; }
        }
        public int Value2
        {
            get { return value2; }
            set { value2 = value; }
        }
        //constructor to intialize two class variables
        public changeValue(int v1, int v2)
        {
            //Value1 = v1;
            //Value2 = v2;
            //evaluate input
            if (v1 > 5) { Value1 = v1; } //val1 gt 5 set value1 = passed in value 1
            if (v1 <= 5) { Value1 = v1 + v2; } //val1 lt or eq 5 set value1 = value 1 and 2
            if (v2 < 10) { Value2 = (v2 * v2) + 5; } //val2 < 10 set value 2 times value 2 plus 5
            if (v2 >= 10) { Value2 = v2; } //val2 gt or eq 10 set value 2 to passed in value 2
        }
        //public class method
        public void printIt()
        {
            Console.WriteLine("The calculated value is: {0}", Value1 * Value2);
        }

    }

    class Assignment_3_TFlesher
    {
        public static void Main(string[] args)
        {
            int val1;
            int val2;

            Console.Write("Enter an integer value: ");
            while (!int.TryParse(Console.ReadLine(), out val1))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.Write("Please enter an integer value: ");
            }
            Console.Write("Enter a second integer value: ");
            while (!int.TryParse(Console.ReadLine(), out val2))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.Write("Please enter an integer value: ");
            }

            //instantiate object / pass values to it
            changeValue cValue = new changeValue(val1, val2);
            cValue.printIt();
        }

    }
}

