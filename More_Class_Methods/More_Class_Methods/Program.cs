using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Class_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a class. In that class, create a method that will take in an integer, 
            //create a math operation for this integer (addition, subtraction, etc.),
            //then return the answer as an integer.
            //
            Console.WriteLine("Good Day! Let's Begin...");
            Console.ReadLine();
            //2. In the Main() method of the console app, instantiate the class and call the one method, 
            //passing in an integer. Display the result to the screen.
            Console.WriteLine("Let's call my good friend \"DoSomeMath\" over and we can apply some math functions to numbers!");
            Console.ReadLine();
            int integer_Input = 27;
            MathFunctions mathFunctions = new MathFunctions();
            int int_Result = mathFunctions.DoSomeMath(integer_Input);
            Console.WriteLine(int_Result);
            Console.WriteLine("Dang! That was fast. DoSomeMath really knows his stuff!");
            Console.ReadLine();
            //3. Add a second method to the class with the same name that will take in a decimal,
            //create a different math operation for it, then return the answer as an integer.
            //4. In the Main() method of the console app, instantiate the class and call the second method,
            //passing in a decimal. Display the result to the screen.
            Console.WriteLine("Moving on...");
            decimal decimal_Input = 20.5178m;
            decimal dec_Result = mathFunctions.DoSomeMath(decimal_Input);
            Console.WriteLine(dec_Result);
            Console.ReadLine();
            //5. Add a third method to the class, with the same name, that will take in a string, 
            //convert it to an integer if possible, do a different math operation to it, 
            //then return the answer as an integer.
            //6. In the Main() method of the console app, instantiate the class and call the third method, 
            //passing in a string that equates to an integer. Display the result to the screen.
            Console.WriteLine("And lastly....");
            string str_Input = "899";
            int str_Result = mathFunctions.DoSomeMath(str_Input);
            Console.WriteLine(str_Result);
            
            Console.ReadLine();
            

            

        }
    }
}
