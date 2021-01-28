using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Parameters_Class
{
    class Math_Multi_Parameter
    {
        public int DoSomeMath (int input1, int optionalint = 7)
      
        {
            int result = input1 + optionalint;

            return result;
            
        }
    }
}
