using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class minus : Node
    {
        public bool negative { set; get; }
        public minus(Node leftChild, Node rightChild) : base(leftChild, rightChild, "-")
        {

        }
        public minus(Node leftChild) : base(leftChild, null, "-")
        {

        }
        public override double Calculations(double x)
        {
            if(rightChild is null)
            {
                return 0 - leftChild.Calculations(x);
            }
            return leftChild.Calculations(x) - rightChild.Calculations(x);
        }
        public override Node Derivative()
        {
            minus m;
            if (rightChild is null)
            {
                m = new minus(new digits("0"), leftChild.Derivative());
                return m;
            }
            m = new minus(leftChild.Derivative(), rightChild.Derivative());
            return m;
        }

        public override Node Simplify()
        {
            this.leftChild = this.leftChild.Simplify();
            if(this.rightChild != null)
            {
                this.rightChild = this.rightChild.Simplify();
            }
            if (this.rightChild is digits && this.rightChild.inside == "0")
            {
                return this.leftChild;
            }
            else if(this.rightChild is null && this.leftChild is minus)
            {
                if(this.leftChild.rightChild is null)
                {
                    return this.leftChild.leftChild;
                }
            }
            else if (this.leftChild is digits && this.leftChild.inside == "0")
            {
                if(rightChild is null)
                {
                    return new digits("0");
                }
                return new minus(this.rightChild);
            }
            else if (this.rightChild is digits && this.leftChild is digits)
            {
                return new digits((Convert.ToInt32(this.leftChild.inside) - Convert.ToInt32(this.rightChild.inside)).ToString());
            }
            else if (this.rightChild == this.leftChild)
            {
                return new digits("0");
            }
            else if (this.rightChild is ln && this.leftChild is ln)
            {
                division m = new division(this.leftChild, this.rightChild);
                return new ln(m);
            }
            return this;
        }
        public override string ToString()
        {
            if(rightChild is null)
            {
                return "(-(" + leftChild.ToString() + "))";
            }
            return "(" + leftChild.ToString() + "-" + rightChild.ToString() + ")";
        }
    }
}
