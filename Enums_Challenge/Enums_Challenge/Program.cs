using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Challenge
{
    public class Program
    {
        


        static void Main(string[] args)
        {


            //CHALLENGE
            //NOTE: To complete this challenge, you will need to do some online research on how to parse enums.

            //Testing:
            //foreach (string day in Enum.GetNames(typeof(DaysoftheWeek)))
            //{
            //    Console.WriteLine("{0] = [1:D]", day, Enum.Parse(typeof(DaysoftheWeek), day));
            //}
            //Console.ReadLine();

            //Perform these actions and create a console app that includes the following:
            //1.Create an enum for the days of the week.


            //2. Prompt the user to enter the current day of the week.
            try
            {
                Console.WriteLine("Enter the current day of the week: ");
                string userInputDay = Console.ReadLine().ToLower();
                Console.WriteLine($"You entered: {userInputDay}");
                //3. Assign the value to a variable of that enum data type you just created.
                
                
                DaysoftheWeek WhatDayIsIt = (DaysoftheWeek)Enum.Parse(typeof(DaysoftheWeek), userInputDay);
                Console.WriteLine("Day Found!");
                


                //4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter and actual day of the week.", e);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nPlease enter an actual day of the week.", ex.Message);
            }
            finally
            {
                Console.WriteLine("\nThe Try/Catch if finished");
            }
            Console.ReadLine();
        }
        public enum DaysoftheWeek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
    }
    
}
