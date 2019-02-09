using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class division: Node
    {
        public division(Node leftChild, Node rightChild):base(leftChild,rightChild,"/")
        {

        }
        public override double Calculations(double x)
        {
            double result = leftChild.Calculations(x) / rightChild.Calculations(x);
            return result;
        }

        public override Node Derivative()
        {
            multi f1 = new multi(this.leftChild.Derivative(), this.rightChild);
            multi f2 = new multi(this.leftChild, this.rightChild.Derivative());
            minus m = new minus(f1, f2);
            power p = new power(this.rightChild, new digits("2"));
            division d = new division(m, p);
            return d;
        }
        public override Node Simplify()
        {
            this.leftChild = this.leftChild.Simplify();
            this.rightChild = this.rightChild.Simplify();
            if (this.leftChild is digits && this.leftChild.inside == "0")
            {
                return new digits("0");
            }
            else if (this.rightChild is digits && this.rightChild.inside == "1")
            {
                return this.leftChild;
            }
            else if(this.rightChild is digits && this.leftChild is digits)
            {
                return new digits((Convert.ToDouble(this.leftChild.inside)/ Convert.ToDouble(this.rightChild.inside)).ToString());
            }
            else if (this.rightChild.ToString() == this.leftChild.ToString())
            {
                return new digits("1");
            }
            else if(this.leftChild is e && this.rightChild is e)
            {
                minus m = new minus(this.leftChild.leftChild, this.rightChild.leftChild);
                return new e(m);
            }
            return this;
        }

        public override string ToString()
        {
            return "(" + leftChild.ToString() + "/" + rightChild.ToString() + ")";
        }
    }
}
