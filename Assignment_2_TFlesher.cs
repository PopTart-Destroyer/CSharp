using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Playground
{
    public class Average
    {
        //declared variables
        int remainder;
        int avg;

        //implicite instance variables
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Score3 { get; set; }

        //constructor
        public Average(int score1Value, int score2Value, int score3Value)
        {
            Score1 = score1Value;
            Score2 = score2Value;
            Score3 = score3Value;
        }

        //calculate average of the three scores
        public void computeAverage()
        {
            avg = (Score1 + Score2 + Score3) / 3;
            remainder = (Score1 + Score2 + Score3) % 3;
        }

        public void DisplayAverage()
        {
            Console.WriteLine("The average of {0}, {1}, {2} is {3} with a remainder of {4}", Score1, Score2, Score3, avg, remainder);
        }
        
    }
    class Assignment_2_TFlesher
    {
        public static void Main(string[] args)
        {
            //instaniate new object passing in values
            Average objA = new Average(3,6,9);

            //calling objects classes
            objA.computeAverage();
            objA.DisplayAverage();

            Console.WriteLine();
        }
    }
}
