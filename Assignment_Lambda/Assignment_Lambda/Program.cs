using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Lambda
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //Perform these actions and create a console app that includes the following:
            //1.In the Main() method, create a list of at least 10 employees.
            //Each employee should have a first and last name, as well as an Id.At least two employees should have the first name "Joe".
            List<Employee> employees = new List<Employee>();
            Employee employee1 = new Employee()
            {
                FirstName = "Bob",
                LastName = "Marley",
                Id = 1
                
            };
            employees.Add(employee1);
            Employee employee2 = new Employee()
            {
                FirstName = "Bob",
                LastName = "Dylan",
                Id = 2
                
            };
            employees.Add(employee2);
            Employee employee3 = new Employee()
            {
                FirstName = "Drew",
                LastName = "Slone",
                Id = 3
            };
            employees.Add(employee3);
            Employee employee4 = new Employee()
            {
                FirstName = "Joe",
                LastName = "Schmoe",
                Id = 4
            };
            employees.Add(employee4);
            Employee employee5 = new Employee()
            {
                FirstName = "Phil",
                LastName = "Collins",
                Id = 5
            };
            employees.Add(employee5);
            Employee employee6 =  new Employee()
            {
                FirstName = "Alvin",
                LastName = "Chipmunk",
                Id = 6
            };
            employees.Add(employee6);
            Employee employee7 =  new Employee()
            {
                FirstName = "Joe",
                LastName = "Montanna",
                Id = 7
            };
            employees.Add(employee7);
            Employee employee8 = new Employee()
            {
                FirstName = "Lisa",
                LastName = "Simpson",
                Id = 8
            };
            employees.Add(employee8);
            Employee employee9 = new Employee()
            {
                FirstName = "Albert",
                LastName = "Eintsein",
                Id = 9
            };
            employees.Add(employee9);
            Employee employee10 = new Employee()
            {
                FirstName = "Vana",
                LastName = "White",
                Id = 10
            };
            employees.Add(employee10);










            //2.Using a foreach loop, create a new list of all employees with the first name "Joe".
            List <Employee> FindJoe = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    FindJoe.Add(employee); 
                }
            }
            foreach (var employee in FindJoe)
            {
                Console.WriteLine($"\nEmployee Id: {employee.Id} -- Name: {employee.FirstName} {employee.LastName}");

            }


            //3.Perform the same action again, but this time with a lambda expression.
            List<Employee> Find_Joe = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (var employee in Find_Joe)
            {
                Console.WriteLine($"\nEmployee Id: {employee.Id} -- Name: {employee.FirstName} {employee.LastName}");
            }

            

            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> employeeId = employees.Where(x => x.Id > 5).ToList();
            foreach (var employee in employeeId)
            {
                Console.WriteLine($"\nEmployee Id: {employee.Id} --  Name: {employee.FirstName} {employee.LastName} ");
            }

            Console.ReadLine();

        }
    }
}
