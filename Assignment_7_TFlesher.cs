//T. J. Flesher
//Assignment 7.1
//CIS243-T301 - Bellevue University
//*********************************
//In Main:
//You will need four variables:  an integer value to hold a random value, a double value to hold an average, 
// a double value to hold a total, and a double value to hold an input entry.
//Using a for loop that will call a getRandom method 20 times.In the loop you will pass a seed value to the 
// getRandom method to use with the random generator and it will return a random value to be added to(accumulate) 
// to the local integer variable in Main.In the getRandom method you will generate a random value between 1 and 100  
// (see p241, section 7.9) and return that random value to Main.The random value will be generated in getRandom using 
// a Random class object.
//Once the loop has completed the 20 method calls you will call a calculate method which returns no value and to which 
// you will pass the total of the random values, the  average variable  by reference, and the literal value of 20.  
//In the calculate method you will compute and average by dividing the total of the random number passed in by the 
// literal value 20 that was passed into the calculate method.
//After the calculate method executes you will display the average to the console.
//Following the writeline statement noted above, you will implement a second for loop that will process 5 iterations.
//Within this for loop you will prompt the user to enter a double value from the console and then assign that input 
// to the double variable declared to hold the input entry.  Also within the loop you will call an overload of the void 
// calculate method and will pass two arguments:  the entry taken from the console and the variable to hold the total 
// by reference.The overload of the void calculate method will receive the double entry value and the byref double variable 
// that will receive the total.In the overloaded calculate method you will add the value passed in to the total variable.
//After the overloaded calculate method executes you will display the total to the console.


using System;

namespace Playground
{
    class Assignment_7_TFlesher
    {
        //getRandom method
      static int getRandom(int seed)
        {
            Random random = new Random(seed);
            int randomNumber = random.Next(1, 101);
            return randomNumber;
        } 

        //calculate average of randomness!  Is this even possible? 
        static void calculate(double rValues, ref double average, int litValue)
        {
            average = rValues / litValue;
        }
        static void calculate(double input, ref double total)
        {
            total += input;
        }
        static void Main(string[] args)
        {
            // variables
            int randValues = 0;
            double average = 0.0, total = 0.0, input = 0.0;
            int seed = 0;
            
            for(int i = 0; i < 20; i++)
            {
                seed = (int)DateTime.Now.TimeOfDay.Ticks;
                randValues += getRandom(seed);
            }
            //call calc method finding average of random #s
            calculate(randValues, ref average, 20);
            Console.WriteLine($"The average of the 20 random numbers is {average}");
            
            //prompt user for input 5x
            for (int j = 0; j < 5; j++)
            {
                Console.Write("Enter a double value: ");
                while(!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Numeric values only!");
                    Console.Write("Enter a double value: ");
                }
                calculate(input, ref total);
            }
            Console.WriteLine($"The total is {total}");
        }
    }
}
