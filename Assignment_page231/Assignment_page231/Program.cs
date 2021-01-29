using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_page231
{
    class Program
    {
        static void Main(string[] args)
        {
            //Perform these actions and create a console app that includes the following:

            //1.Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

            //2. In the Main() method, instantiate that class.
            VoidMethod voidMethod = new VoidMethod();

            //3. Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.
            Console.WriteLine("Please enter a number: ");
            int Input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered: {Input}");
            voidMethod.Void_Method(Input);

            Console.WriteLine($"{Input} divided by 2 is {voidMethod.num1}");
            Console.ReadLine();
            //4. Create a method with output parameters.
            Console.WriteLine("Creating a method with 2 output parameters...");
            Console.WriteLine();
            
            voidMethod.Void_Method2(out int num2, out int result);
            Console.WriteLine($"The two output values of this method are {num2} and {result}");
            Console.ReadLine();




            //5. Overload a method.
            
            Console.WriteLine("Overloading Void_Method Class Method with new output parameter and changed math operator ...");
            Console.WriteLine();
                
            voidMethod.Void_Method(num2, out result);
            Console.WriteLine($"The input value is {num2} and the output result is {result}");
            Console.ReadLine();

            //6. Declare a class to be static.
            StaticClass.Whats_For_Dinner();
            Console.WriteLine(StaticClass.dinner);
            Console.ReadLine();
            


        }
    }
}
