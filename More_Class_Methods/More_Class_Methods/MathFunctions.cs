using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Class_Methods
{
    class MathFunctions
    {
        public int DoSomeMath(int integer_Input)
        {
            int int_Result = integer_Input + 256;
            return int_Result;
        }
        public decimal DoSomeMath(decimal decimal_Input)
        {
            decimal dec_Result = decimal_Input * 100;
            return dec_Result;
        }
        public int DoSomeMath(string str_Input)
        {
            string intString = str_Input;
            int i = 0;
            if (!Int32.TryParse(intString, out i))
            {
                i = -1;
            }
            return i;
            
        }

            

    }
}
