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
            math.AddOneHundred(input);
            Console.ReadLine();
            math.MultiplyByTen(input);
            Console.ReadLine();
            math.DivideByFour(input);
            Console.ReadLine();
            Console.WriteLine("End Program...");
            Console.WriteLine("Have a nice day!");
          
            Console.ReadLine();

        }
    }
}
