using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class e : Node
    {
        public e(Node leftChild) : base(leftChild, null, "e")
        {

        }
        public override double Calculations(double x)
        {
            return Math.Pow(Math.E, leftChild.Calculations(x));
        }
        public override Node Derivative()
        {
            e e = new e(this.leftChild);
            multi m = new multi(e, this.leftChild.Derivative());
            return m.Simplify();
        }
        public override Node Simplify()
        {
            this.leftChild = this.leftChild.Simplify();
            if(this.leftChild is digits)
            {
                if(this.leftChild.inside == "0")
                {
                    return new digits("1");
                }
            }
            else if(this.leftChild is ln)
            {
                return this.leftChild.leftChild; 
            }
            return this;
        }
        public override string ToString()
        {
            return "(e^" + leftChild.ToString() + ")";
        }
    }
}
