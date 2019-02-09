using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class realnumb : Node
    {
        public realnumb(Node left) : base(left, null, "r")
        {

        }
        public override double Calculations(double x)
        {
            return leftChild.Calculations(x);
        }
        public override Node Derivative()
        {
            digits d = new digits("0");
            return d;
        }
        public override Node Simplify()
        {
            return this.leftChild;
        }
        public override string ToString()
        {
            return this.leftChild.ToString();
        }
    }
}
