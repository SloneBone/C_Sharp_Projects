using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects_Methods_Assignment
{
    class Math
    {
        public void AddOneHundred(int input)
        {
            int result = input + 100;

            Console.WriteLine("Input value  of " + input + " Plus 100 equals " + result);
            Console.WriteLine(input + " + " + 100 + " = " + result);

        }
        public void MultiplyByTen(int input)
        {
            int result = input * 10;

            Console.WriteLine("Input value of " + input + " Multiplied by 10 equals " + result);
            Console.WriteLine(input + " * " + 10 + " = " + result);
        }
        public void DivideByFour(int input)
        {
            int result = input / 4;

            Console.WriteLine("Input value of " + input + " Divided by 4 equals " + result);
            Console.WriteLine(input + " / " + 4 + " = " + result);
        }

        



       
        
    }
}
