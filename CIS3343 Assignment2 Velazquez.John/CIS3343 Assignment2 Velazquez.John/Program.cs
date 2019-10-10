/**********************************
 * CIS 3343 
 * John Velazquez
 *************************************
 * Assignment 2
 * Class Average
 * Date: 9/10/2019
 *************************************
 * Takes as many inputs as user wants
 * and takes the average and displays
 * both the numerical value and the
 * letter grade for the average.
 *************************************/

using System;

namespace CIS3343_Assignment2_Velazquez.John
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gradebook v1.0\n");

            //Variables to keep track of or calculate and assign to
            double gradeSum = 0, gradeAvg;
            int students = 0;
            Grade CIS3343 = new Grade();
            
            while(students != -1)
            {
                Console.Write("Enter a numeric grade or -1 to quit: ");
                int input = Convert.ToInt32(Console.ReadLine());

                //If user inputs '-1' program exits the loop
                if(input == -1)
                    break;
                else
                {
                    gradeSum += input;//Adds input to value in gradeSum, assigns new sum
                    students++; //Students also gets incremented
                }
                    
            }

            gradeAvg = gradeSum / students; //Caculating average

            //Console.WriteLine($"The average grade is {Math.Round(gradeAvg, 2)}");
            Console.WriteLine($"The average grade is {gradeAvg:F2}");
            Console.WriteLine($"The average letter grade for CIS3343 " +
                $"is {CIS3343.ConvertToLetter((int)gradeAvg)}");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
