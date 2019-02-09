using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class MyException:Exception
    {
        public MyException(string s) : base(s)
        {

        }
    }
}
