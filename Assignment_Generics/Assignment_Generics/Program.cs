using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Perform these actions and create a console app that includes the following:

            //1.Make the Employee class take a generic type parameter.

            //2. Add a property to the Employee class called "things" and
            //have its data type be a generic list matching the generic type of the class.

            //3. Instantiate an Employee object with type "string" as its generic parameter.
            //Assign a list of strings as the property value of Things.
            Employee<string> employeeThings = new Employee<string>()
            {
                firstName = "Drew",
                lastName = "Slone", 
                Things = new List<string>() {"Laptop",  "Mouse", "Keyboard", "Family Picture", "Files/Folders", "Cardboard Box" }
            };

            //4. Instantiate an Employee object with type "int" as its generic parameter.
            //Assign a list of integers as the property value of Things.
            Employee<int> employeeCostOfThings = new Employee<int>()
            {
                Id = 101,
                Things = new List<int>() { 200, 25, 50, 10, 40, 0 }
            };

            //5. Create a loop that prints all of the Things to the Console.
            foreach (string thing in employeeThings.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int cost in employeeCostOfThings.Things)
            {
                Console.WriteLine(cost);
            }
            Console.ReadLine();
        }
    }
}
