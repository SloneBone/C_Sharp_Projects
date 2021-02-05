using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Const_Var
{
    public class Employee
    {
        private string _FName;
        private string _LName;
        private int _Id;

        public Employee() : this("Default", "Default", 01)
        {
            Console.WriteLine("The 'Employee()' Constructor has been called.");
            Console.ReadLine();
        }
        public Employee(string LName, int Id) : this(String.Empty, LName, Id)
        {
            _Id = Id;
            _LName = LName;
            Console.WriteLine("The 'Employee(LName, Id)' Constructor has been called.");
            Console.ReadLine();
        }

        public Employee(string FName, string LName, int Id)
        {
            _FName = FName;
            _LName = LName;
            _Id = Id;
            Console.WriteLine("The 'Employee(FName, LName, Id)' Constructor has been called.");
            Console.ReadLine();
           

            
        }
    }
}
