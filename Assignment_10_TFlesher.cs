//T. J. Flesher
//Assignment 10
//Bellevue University
//*****************************************************************************
//Develop a C# console application that implements three arrays; a string array initialized with exactly the 
// following five data items { "Widget 15.50", "Thingy 50.99", "Ratchet25.00", "Clanger115.49", "Fracker75.25" }, 
// a string array to hold the five part names to be parsed from the previously detailed string array, an array
// of five double value prices to be parsed from the previously mentioned array.
//Create a void method that will accept as arguments the two arrays of strings and the array of doubles when
// called from Main.In the method you will access the five members of the first string array mentioned above and
// you will parse out the name portion of each string element(first 7 bytes), assigning the string value
// to the corresponding element in the array of names.In the method you will also parse out the numeric
// portion of each string and assign it to the corresponding element of the price array.  
//The parsing should be done using the string method SubString.
//In Main, after calling the parsing method you will display the elements of both the array of names and the
// array of prices side-by-side 

using System;

namespace Playground
{
    class Assignment_10_TFlesher
    {
        static void Stringy(string[] og, ref string[] name, ref double[] price)
        {
            for (int i = 0; i < og.Length; i++)
            {
                //Console.WriteLine(og[i].Substring(0, 7));
                name[i] = og[i].Substring(0, 7);
                price[i] = Convert.ToDouble(og[i].Substring(7));
            }
        }
        static void Main(string[] args)
        {
            string[] original = { "Widget 15.50", "Thingy 50.99", "Ratchet25.00", "Clanger115.49", "Fracker75.25" };
            string[] name = new string[5];
            double[] price = new double[5];

            //call static method
            Stringy(original,ref name,ref price);
            for(int j = 0; j < name.Length; j++)
            {
                Console.WriteLine($"{name[j]} {price[j]:C}");
            }
        }
    }
}
