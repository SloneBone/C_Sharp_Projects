using System;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a Daily Report Console program for students
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page are you on?");
            string currentPage = Console.ReadLine();
            byte pageNum = Convert.ToByte(currentPage);
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
            string needHelp = Console.ReadLine();
            bool Help = Convert.ToBoolean(needHelp);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int studyHours = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

            //This is for developer purposes.
            //Console.WriteLine(studentName);
            //Console.WriteLine(currentCourse);
            //Console.WriteLine(pageNum);
            //Console.WriteLine(Help);
            //Console.WriteLine(posExp);
            //Console.WriteLine(feedBack);
            //Console.WriteLine(studyHours);
            //Console.ReadLine();




            
            
        }
    }
}
