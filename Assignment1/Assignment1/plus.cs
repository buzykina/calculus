using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class plus : Node
    {
        public plus(Node leftChild, Node rightChild) : base(leftChild, rightChild, "+")
        {

        }
        public override double Calculations(double x)
        {
            return leftChild.Calculations(x) + rightChild.Calculations(x);
        }
        public override Node Derivative()
        {
            plus p = new plus(leftChild.Derivative(), rightChild.Derivative());
            return p;
        }

        public override Node Simplify()
        {
            this.leftChild = this.leftChild.Simplify();
            this.rightChild = this.rightChild.Simplify();
            if (this.rightChild is digits && this.rightChild.inside == "0")
            {
                return this.leftChild;
            }
            else if (this.leftChild is digits && this.leftChild.inside == "0")
            {
                return this.rightChild;
            }
            else if (this.rightChild is digits && this.leftChild is digits)
            {
                return new digits((Convert.ToDouble(this.leftChild.inside) + Convert.ToDouble(this.rightChild.inside)).ToString());
            }
            else if (this.rightChild is ln && this.leftChild is ln)
            {
                multi m = new multi(this.leftChild.leftChild, this.rightChild.leftChild);
                return new ln(m);
            }
            return this;
        }
        public override string ToString()
        {
            return "(" + leftChild.ToString() + "+" + rightChild.ToString() + ")";
        }
    }
}
