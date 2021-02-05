using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Perform these actions and create a console app that includes the following:

            //    1.Ask the user for their age.
            //    2.Display the year the user was born.
            //    3.Exceptions must be handled using “try/catch.”
            try
            {
                Console.WriteLine("Please enter your age: ");
                int Age = Convert.ToInt32(Console.ReadLine());
                DateTime yearOfBirth = DateTime.Now.AddYears(-Age);
                if (Age <= 0)
                {
                    throw new CustomException();
                }

                Console.WriteLine($"According to my calculations...\nYou were born in the year of: {yearOfBirth.Year}");
                Console.ReadLine();
            }
            //    4.Display appropriate error messages if the user enters zero or negative numbers.
            //    5.Display a general message if an exception was caused by anything else
            catch (FormatException)
            {
                Console.WriteLine("You have entered something incorrectly...\nTry entering a number!");
                Console.ReadLine();
                return;
            }
            catch (CustomException)
            {
                Console.WriteLine("You have entered something incorrectly...\nPlease enter a whole number greater than zero!");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong....");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("The try/catch block was executed!");
                Console.ReadLine();
            }
            //Note From microsoft documentation https://docs.microsoft.com/en-us/dotnet/api/system.datetime.subtract?view=net-5.0
            //To subtract a particular time interval from the current instance, call the method that adds that time interval to the current date,
            //    and supply a negative value as the method argument. For example, to subtract two months from the current date,
            //    call the AddMonths(Int32) method with a value of - 2.


            //Console.WriteLine("Please enter your age: ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //DateTime yearOfBirth = DateTime.Now.AddYears(-Age);

            //Console.WriteLine($"According to my calculations you were born in the year of: {yearOfBirth.Year}");
            //Console.ReadLine();

            //DateTime userAge = Convert.ToDateTime(Console.ReadLine());
            //var birthYear = DateTime.Today.Subtract(userAge);
            //Console.WriteLine(birthYear);



        }
    }
}
