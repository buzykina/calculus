using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Term
    {
        public Term nextTerm { get; set; }
        public double number { get; set; }
        public Term(double num)
        {
            this.number = num;
        }

    }
}
