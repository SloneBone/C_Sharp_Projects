using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Interface
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Perform these actions and create a console app that includes the following:

            //1.Create an interface called IQuittable and have it define a void method called Quit().

            //2. Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.

            //3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            //  Hint: an object can be of an interface type if it implements that specific interface.

            //Employee employee = new Employee();
            //{
            //    employee.firstName = "Sample";
            //    employee.lastName = "Student";
            //}
            //employee.SayName();

            IQuittable employee = new Employee
            {
                firstName = "Mr.",
                lastName = "Anderson",
                Id = 0100110101 
            };
          
            employee.Quit();
            
            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
