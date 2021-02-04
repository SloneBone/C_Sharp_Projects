using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {

            //    Perform these actions and create a console app that includes the following:

            //    1.Prints the current date and time to the console.
            //DateTime dateTime = new DateTime();
            var today = DateTime.Now;
            Console.WriteLine(today);

            //    2.Asks the user for a number.
            Console.WriteLine("Please enter a number: ");

            //    3.Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            double numHours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{today} + {numHours} hours = {today.AddHours(numHours)}");
            Console.ReadLine();


            
            
            
            //DateTime AddHours(double numHours);
            //TimeSpan inXHours = today.AddHours(numHours);

            //using (StreamWriter file = new StreamWriter(@"C:\Users\dslon\Logs\logs.txt", true))
            //{ 
            //    file.WriteLine(DateTime.Now);
            //    file.WriteLine(card);
            //}

            //DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearofBirth = new DateTime(1986, 30, 23, 8, 45, 20); 
            //DateTime yearofGraduation = new DateTime(2013, 6, 1, 16, 32, 22);
            //TimeSpan ageAtGraduation = yearofGraduation - yearofBirth;
            //ageAtGraduation.
        }
    }
}
