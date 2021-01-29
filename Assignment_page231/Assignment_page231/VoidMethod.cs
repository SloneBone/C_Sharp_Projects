using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_page231
{
    public class VoidMethod
    {
        public int num1 = 0;
        public int num2 = 0;

        public void Void_Method(int num1)
        {
             this.num1 = num1 / 2;
        }
        //Creating a new method with output parameters
        public void Void_Method2(out int num2, out int result)
        {
            
            num2 = 25 * 4;
            result = 25 * 2;
        }
        //Overloading Void_Method with new output parameter and changed math operation
        public void Void_Method(int num2, out int result)
        {
        
            result  = num2 + 2;

        }
    }
}
