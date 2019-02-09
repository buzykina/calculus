using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class sin : Node
    {
        public sin(Node left) : base(left, null, "sin")
        {

        }
        public override double Calculations(double x)
        {
            return Math.Sin(leftChild.Calculations(x));
        }

        public override Node Derivative()
        {
            if (this.leftChild is digits)
            {
                digits d = new digits("0");
                return d;
            }
            multi f1 = new multi(new cos(this.leftChild), this.leftChild.Derivative());
            return f1;
        }
        public override Node Simplify()
        {
            this.leftChild = this.leftChild.Simplify();
            return this;
        }
        public override string ToString()
        {
            return "sin(" + this.leftChild.ToString() + ")";
        }
    }
}
