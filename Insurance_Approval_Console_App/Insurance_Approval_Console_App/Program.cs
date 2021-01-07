using System;

namespace Insurance_Approval_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("What is your age?");
            int applicant_Age = Convert.ToInt32(Console.ReadLine());
            //*CURIOUS* Try to implement 'Yes' and 'No' responses if possible
            Console.WriteLine("Have you ever had a DUI?  Please respond with 'True' or 'False'.");
            bool have_DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int num_Tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            if (applicant_Age > 15 && have_DUI == false && num_Tickets <= 3)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.ReadLine();
        }
    }
}
