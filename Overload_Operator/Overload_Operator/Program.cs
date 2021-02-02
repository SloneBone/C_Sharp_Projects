using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Perform these actions and create a console app that includes the following:

            //1.Overload the "==" operator so it checks if two Employee objects 
            //are equal by comparing their Id property.
            Employee employee1 = new Employee()
            {
                Id = 339,
                firstName = "John",
                lastName = "Smith"
            };
            //employee1.SayName();
            //employee1.Quit();
            //employee1.GetId();

            Employee employee2 = new Employee()
            {
                Id = 338,
                firstName = "John",
                lastName = "Smith"
            };
            //employee2.SayName();
            

            

            if (employee1 == employee2)
            {
                employee1.GetId();
                employee2.GetId();
                Console.WriteLine(employee1 == employee2);

                Console.WriteLine("These Id's are the same!");
            }
            else
            {
                employee1.GetId();
                employee2.GetId();
                Console.WriteLine(employee1 != employee2);

                Console.WriteLine("These Id's are not the same!");
                
            }
            Console.ReadLine();
                    
            

            
        }
    }
}
