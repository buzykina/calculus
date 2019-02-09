using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class digits : Node
    {
        public digits(string inside) : base(null, null, inside)
        {

        }
        public override double Calculations(double x)
        {
            return Convert.ToDouble(inside);
        }

        public override Node Derivative()
        {
            digits d = new digits("0");
            return d;
        }
        public override Node Simplify()
        {
            return this;
        }
        public override string ToString()
        {
           return Math.Round(Convert.ToDecimal(this.inside), 2).ToString();
        }
    }
}
