using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }


        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {

            Console.WriteLine($"Two week notice of resignation recieved for employee with Id number: {Id}");
            SayName();
            Console.WriteLine("\nBegin termination process...");
            Console.ReadLine();
        }
        public virtual void GetId()
        {
            Console.WriteLine($"Employee Id: {Id}");
        }
        //Note

        //The comparison operators must be overloaded in pairs.
        //That is, if either operator of a pair is overloaded, 
        //the other operator must be overloaded as well.
        //Such pairs are as follows:

        //== and != operators
        //< and > operators
        //<= and >= operators

        public static bool operator ==(Employee Id1, Employee Id2)
        {
            bool status = false;
            if (Id1.Id == Id2.Id)
            {
                status = true;
            }
            return status;
        }

        public static bool operator !=(Employee Id1, Employee Id2)
        {
            bool status = false;
            if (Id1.Id == Id2.Id)
            {
                status = true;
            }
            return status;
        }

    }
}
