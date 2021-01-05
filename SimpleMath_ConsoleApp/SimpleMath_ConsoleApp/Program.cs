using System;


namespace SimpleMath_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  the Simple Math Console App\nLet's Play!");
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int product = num1 * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + product);
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int add = num2 + 25;
            Console.WriteLine("Your number plus 25 equals: " + add);
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double divide = num3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + divide);
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool isGreaterThan = num4 > 50;
            Console.WriteLine("Your number is greater than 50: " + isGreaterThan.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int remainder = num5 % 7;
            Console.WriteLine("Your number divided by 7 has a remainder of: " + remainder);
            Console.ReadLine();

            Console.WriteLine("Thank you for using the Simple Math Console App\nSee you next time!");
            Console.ReadLine();



             

             

        }
    }
}
