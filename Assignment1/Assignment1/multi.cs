using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class multi : Node
    {
        public multi(Node leftChild, Node rightChild) : base(leftChild, rightChild, "*")
        {
            
        }
        public override double Calculations(double x)
        {
            return leftChild.Calculations(x) * rightChild.Calculations(x);
        }
        public override Node Derivative()
        {
            multi f1 = new multi(this.leftChild.Derivative(), this.rightChild);
            multi f2 = new multi(this.leftChild, this.rightChild.Derivative());
            plus p = new plus(f1, f2);
            return p;
        }

        public override Node Simplify()
        {
            this.leftChild = this.leftChild.Simplify();
            this.rightChild = this.rightChild.Simplify();
            if (this.leftChild is digits && this.leftChild.inside == "1")
            {
                return this.rightChild;
            }
            else if (this.rightChild is digits && this.rightChild.inside == "1")
            {
                return this.leftChild;
            }
            else if ((this.rightChild is digits && this.rightChild.inside == "0") || (this.leftChild is digits && this.leftChild.inside == "0"))
            {
                return new digits("0");
            }
            else if (this.rightChild is digits && this.leftChild is digits)
            {
                return new digits((Convert.ToInt32(this.leftChild.inside) * Convert.ToInt32(this.rightChild.inside)).ToString());
            }
            else if (this.rightChild is e && this.leftChild is e)
            {
                plus p = new plus(this.leftChild.leftChild, this.rightChild.leftChild);
                return new e(p);
            }
            else if(this.rightChild is minus && this.leftChild is minus && this.rightChild.rightChild is null && this.leftChild.rightChild is null)
            {
                multi m = new multi(this.rightChild.leftChild, this.leftChild.leftChild);
                return m;
            }
            return this;
        }
        public override string ToString()
        {    
            return "(" + leftChild.ToString() + "*" + rightChild.ToString() + ")";
        }
    }
}
