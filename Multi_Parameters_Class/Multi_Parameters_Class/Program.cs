using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Parameters_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Perform these actions and create a console app that includes the following:

            //1.Create a class. In that class, create a method that takes two integers as parameters.
            //Make one of them optional.Have the method do a math operation and return an integer result.

            //2. In the Main() method of the console app, instantiate the class.
            Math_Multi_Parameter math_Multi_Parameter = new Math_Multi_Parameter();
            //3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.
            Console.WriteLine("I ask that you input two numbers one at a time!");
            Console.WriteLine("Please input a number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You need not enter anything for this second number. Please input another number: ");
            string optionalStr = Console.ReadLine();

            //4. Call the method in the class, passing in the one or two numbers entered.
            //5. Try various combinations of numbers on the code, including having no second number.
            if (optionalStr == "")
            {
                int result = math_Multi_Parameter.DoSomeMath(input1);
                Console.WriteLine(result);
            }
            else
            {

                int optionalint = Convert.ToInt32(optionalStr);
                int result = math_Multi_Parameter.DoSomeMath(input1, optionalint);
                Console.WriteLine(result);
            }

            Console.ReadLine();
            

            
        }
    }
}
