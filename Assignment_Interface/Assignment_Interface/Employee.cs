using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Interface
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

    }
}
