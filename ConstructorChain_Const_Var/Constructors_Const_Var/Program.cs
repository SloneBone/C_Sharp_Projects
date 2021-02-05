using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Const_Var
{
    class Program
    {
        public static void Main(string[] args)
        {
            //1.Create a const variable.
            const string myName = "Drew";
            Console.WriteLine($"'{myName}' is a contsant variable that can not be changed.");
            Console.ReadLine();

            //2.Create a variable using the keyword "var.”
            var date = DateTime.Now;
            Console.WriteLine(date);
            Console.ReadLine();



            //3.Chain two constructors together.
            Employee employee = new Employee();

            Employee drew = new Employee("Drew", "Slone", 1001);

            Employee slone = new Employee("Slone", 101);

            //Note: The chained constructor is called before the invoking constructor


        }
    }
}
