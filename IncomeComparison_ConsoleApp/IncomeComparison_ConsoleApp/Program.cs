using System;


namespace IncomeComparison_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Console App for comparing income 
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate? ");
            int Rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int Hours1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int Rate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int Hours2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual Salary of Person: ");
            int Salary1 = (Rate1 * Hours1) * 52;
            Console.WriteLine(Salary1);
            Console.WriteLine("Annual Salary of Person 2: ");
            int Salary2 = (Rate2 * Hours2) * 52;
            Console.WriteLine(Salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isGreaterThan = Salary1 > Salary2;
            Console.WriteLine(isGreaterThan);
            Console.ReadLine();

            //For developer purposes/testing
            // Utilizing 'double' data type for practical uses 
            // hourly rates that are not an integer
            // ei. '25.50', '52.17', etc.
            //Console.WriteLine("Anonymous Income Comparison Program");
            //Console.WriteLine("Person 1");
            //Console.WriteLine("Hourly Rate? ");
            //double Rate1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Hours worked per week?");
            //double Hours1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Person 2");
            //Console.WriteLine("Hourly Rate?");
            //double Rate2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Hours worked per week?");
            //double Hours2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Annual Salary of Person: ");
            //double Salary1 = (Rate1 * Hours1) * 52;
            //Console.WriteLine(Salary1);
            //Console.WriteLine("Annual Salary of Person 2: ");
            //double Salary2 = (Rate2 * Hours2) * 52;
            //Console.WriteLine(Salary2);
            //Console.WriteLine("Does Person 1 make more money than Person 2?");
            //bool isGreaterThan = Salary1 > Salary2;
            //Console.WriteLine(isGreaterThan);
            //Console.ReadLine();










        }
    }
}
