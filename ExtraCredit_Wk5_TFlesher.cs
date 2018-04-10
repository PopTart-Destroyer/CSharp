//T. J. Flesher
//Assignment 5 Extra Credit
//CIS243-T301 - Bellevue University
//*********************************
//You are responsible for tracking the progress of a junior-high fundraiser.You decide to write a program which will help you with the task.
//•	Create a console program where you will implement variables that are needed for this program and will implement the code entirely within Main.
//•	Prompt the user for contributions.It should first ask for the contributor's grade.
//•	You should then it should ask how much the student is contributing.
//•	These prompts should be placed inside of a loop so that the program will continue to ask for contributions until a value of 999 is entered for the contributor's grade.
//•	Once that value is entered, the program should calculate the average value of the contributions.
//•	Display the results, with a congratulatory message for the class which collected the largest amount.
//•	Use a Boolean variable to control the while loop
//•	Use a switch statement to help get the input into the proper variables
//•	Place the switch statement within the while loop and use the Boolean variable to control the loop and set its value to false when the sentinel value (999) is detected.
//•	When calculating the averages you will need a selection statement for each grade contribution to either compute the individual grade contribution average or to set it to zero if there were no contributions for that grade.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Playground
{
    class ExtraCredit_Wk5_TFlesher
    {
        static void Main(string[] args)
        {
            bool sentinalValue = true;
            int gradeLevel = 0;
            int aCount = 0; //Sixth Grade
            int bCount = 0; //Seventh Grade
            int cCount = 0; //Eigth Grade
            decimal amount = 0m; //Generic holder
            decimal aAmount = 0m; //Sixth Grade Amount
            decimal bAmount = 0m; //Seventh Grade Amount
            decimal cAmount = 0m; //Eight Grade Amount
            decimal aAverageAmt = 0m; //Sixth Grade Average Amount
            decimal bAverageAmt = 0m; //Seventh Grade Average Amount
            decimal cAverageAmt = 0m; //Eight Grade Average Amount
            string winners = ""; 

            //get user input for contributor grade level/ validate input
            Console.Write("Please enter the grade of the contributor (6, 7, or 8) (enter 999 to quit): ");
            while (!int.TryParse(Console.ReadLine(), out gradeLevel))
            {
                Console.WriteLine("Please enter a valid numerical value.");
                Console.Write("Please enter the grade of the contributor (6, 7, or 8) (enter 999 to quit): ");

            }

            while (sentinalValue == true)
            {

                if ((gradeLevel >= 6 && gradeLevel <= 8) || gradeLevel == 999)
                {
                    //figure gradeLevel and bucket appropriate amount into said bucket
                    switch (gradeLevel)
                    {
                        case 6:
                            //get contribution value
                            Console.Write("Pleae enter the amount of the contribution: ");
                            while (!decimal.TryParse(Console.ReadLine(), out amount))
                            {
                                Console.WriteLine("Please enter numerical values.");
                                Console.Write("Pleae enter amount of the contribution: ");
                            }
                            aAmount += amount;
                            if (aAmount > 0)
                            {
                                ++aCount;
                            }
                            break;
                        case 7:
                            //get contribution value
                            Console.Write("Pleae enter the amount of the contribution: ");
                            while (!decimal.TryParse(Console.ReadLine(), out amount))
                            {
                                Console.WriteLine("Please enter numerical values.");
                                Console.Write("Pleae enter amount of the contribution: ");
                            }
                            bAmount += amount;
                            if (bAmount > 0)
                            {
                                ++bCount;
                            }
                            break;
                        case 8:
                            //get contribution value
                            Console.Write("Pleae enter the amount of the contribution: ");
                            while (!decimal.TryParse(Console.ReadLine(), out amount))
                            {
                                Console.WriteLine("Please enter numerical values.");
                                Console.Write("Pleae enter amount of the contribution: ");
                            }
                            cAmount += amount;
                            if (cAmount > 0)
                            {
                                ++cCount;
                            }
                            break;
                        case 999:
                            //detected sentinal value exit while loop
                            sentinalValue = false;
                            break;
                        default:
                            break;
                    }
                    if (sentinalValue == true) //only display if sentinal value is true
                    {
                        //get user input for contributor grade level/ validate input
                        Console.Write("Please enter the grade of the contributor (6, 7, or 8) (enter 999 to quit): ");
                        while (!int.TryParse(Console.ReadLine(), out gradeLevel))
                        {
                            Console.WriteLine("Please enter a valid numerical value.");
                            Console.Write("Please enter the grade of the contributor (6, 7, or 8) (enter 999 to quit): ");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nInput out of range!\n");
                    Console.Write("Please enter the grade of the contributor (6, 7, or 8) (enter 999 to quit): ");
                    while (!int.TryParse(Console.ReadLine(), out gradeLevel))
                    {
                        Console.WriteLine("Please enter a valid numerical value.");
                        Console.Write("Please enter the grade of the contributor (6, 7, or 8) (enter 999 to quit): ");

                    }
                } //end if statement for range


            }
            //calculations
            if (aAmount > 0)
            {
                aAverageAmt = aAmount / aCount;
            }
            if (bAmount > 0)
            {
                bAverageAmt = bAmount / bCount;
            }
            if (cAmount > 0)
            {
                cAverageAmt = cAmount / cCount;
            }
            //finding winning grade via amount contributed
            if (aAmount > bAmount && aAmount > cAmount)
            {
                winners = "6th";
            }
            else if (bAmount > aAmount && bAmount > cAmount)
            {
                winners = "7th";
            }
            else if (cAmount > aAmount && cAmount > bAmount)
            {
                winners = "8th";
            }
       
            //display tally & winners
            Console.WriteLine();
            Console.WriteLine("{0,-13}{1, -14}{2, -14}{3,-8}","Grade Level","# of Contrib","Total Amount","Average");
            Console.WriteLine("{0,-16}{1, -11}{2, -14:C}{3,-8:C}","6th Grade", aCount, aAmount, aAverageAmt);
            Console.WriteLine("{0,-16}{1, -11}{2, -14:C}{3,-8:C}", "7th Grade", bCount, bAmount, bAverageAmt);
            Console.WriteLine("{0,-16}{1, -11}{2, -14:C}{3,-8:C}", "8th Grade", cCount, cAmount, cAverageAmt);
            if (winners != "")
            {
                Console.WriteLine("\nCongratulations " + winners + " graders!");
            }
 
        }
    }
}
