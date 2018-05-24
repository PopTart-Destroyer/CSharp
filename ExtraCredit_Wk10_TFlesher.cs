//T. J. Flesher
//Extra Credit Wk 10
//Bellevue University
//*****************************************************************************
//You will write a console program that will meet the following requirements:
//•	Create a console program where you will implement arrays and variables that are needed for this 
//   program and will implement the code within Main and any required static methods.
//•	Use the following string array declaration:
//   string[] compositeString = { "4for", "2is the", "3week 10 challenge assignment", "1This assignment", "5CIS243" };
//•	Note that each string in the string array has a different length and each has a number as the first 
//   character in the array.
//•	The number at the beginning of each string indicates the numeric order that the strings should be in.  
//   Note that in the output below the order numbers are not displayed.
//•	Construct the loops, comparisons, boolean conditionals and any other variables or arrays that will
//   extract each string in the array and arrange the separate strings into a single string which when 
//   displayed will produce the output shown below.
//You should format your output to look exactly like the following:
//This assignment is the week 10 challenge assignment for CIS243

using System;

namespace Playground
{
    class ExtraCredit_Wk10_TFlesher
    {
        static void Main(string[] args)
        {
            string[] compositeString = { "4for", "2is the", "3week 10 challenge assignment", "1This assignment", "5CIS243" };
            string[] copyString = new string[0];

            Array.Sort(compositeString);

            for (int i = 0; i < compositeString.Length; i++)
            {
                Array.Resize(ref copyString, copyString.Length + 1);
                copyString[copyString.Length - 1] = compositeString[i].Substring(1);
            }
            Console.Write(string.Join(" ", copyString));
            Console.WriteLine();
        }
    }
}
