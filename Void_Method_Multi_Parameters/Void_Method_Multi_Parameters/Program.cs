using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method_Multi_Parameters
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Perform these actions and create a console app that includes the following:

            //1.Create a class. In that class, create a void method that takes two integers as parameters.
            // Have the method do a math operation on the first integer and display the second integer to the screen.

            //2. In the Main() method of the console app, instantiate the class.
            Math_Two_Params math_Two_Params = new Math_Two_Params();
            //3. Call the method in the class, passing in two numbers.
            math_Two_Params.TwoParams(44, 77);
            //4. Call the method in the class, specifying the parameters by name.


            math_Two_Params.TwoParams(num1: 36, num2: 47);

            Console.ReadLine();
        }
    }
}
