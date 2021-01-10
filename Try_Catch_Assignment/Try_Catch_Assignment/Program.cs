using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                Console.WriteLine("Hello Welcome to another Assignment");
                Console.ReadLine();
                List<int> numList = new List<int>() { 20, 30, 55, 22, 88, 100 };
                Console.WriteLine("Input a number to divide by: ");
                int divideBy = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numList)
                {
                    Console.WriteLine("The number (" + number + ") Divided by (" + divideBy + ") equals " + (number / divideBy));

                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("Try/Catch Block executed. Continue on with program...");
            Console.ReadLine();
        }
    }
}

