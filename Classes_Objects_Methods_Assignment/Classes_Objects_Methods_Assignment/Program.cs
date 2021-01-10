using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome to Console App Math");
            Console.WriteLine("Get ready...");
            Console.ReadLine();
            Console.WriteLine("Set....");
            Console.ReadLine();
            Console.WriteLine("Go!");
            Console.ReadLine();
            Console.WriteLine("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Math math = new Math();
            int result = math.AddOneHundred(input);
            Console.WriteLine("Input value  of " + input + " Plus 100 equals " + result);
            Console.WriteLine(input + " + " + 100 + " = " + result);
            Console.ReadLine();
            int result1 = math.MultiplyByTen(input);
            Console.WriteLine("Input value of " + input + " Multiplied by 10 equals " + result1);
            Console.WriteLine(input + " * " + 10 + " = " + result1);
            Console.ReadLine();
            int result2 = math.DivideByFour(input);
            Console.WriteLine("Input value of {0} Divided by 4 equals {1} ",input, result2);
            Console.WriteLine(input + " / " + 4 + " = " + result2);
            Console.ReadLine();
            Console.WriteLine("End Program...");
            Console.WriteLine("Have a nice day!");
          
            Console.ReadLine();

        }
    }
}
