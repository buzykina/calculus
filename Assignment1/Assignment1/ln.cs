using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class ln : Node
    {
        public ln(Node leftChild) : base(leftChild, null, "ln")
        {

        }
        public override double Calculations(double x)
        {
            return Math.Log(leftChild.Calculations(x));
        }
        public override Node Derivative()
        {
            if (this.leftChild is digits)
            {
                digits d = new digits("0");
                return d;
            }
            division d1 = new division(new digits("1"), this.leftChild);
            multi m = new multi(d1, this.leftChild.Derivative());
            return m;
        }
        public override Node Simplify()
        {
            this.leftChild = leftChild.Simplify();
            if (this.leftChild is digits)
            {
                if(this.leftChild.inside == "1")
                {
                    return new digits("0");
                }
                if(Convert.ToDouble(this.leftChild.inside) < 1)
                {
                    throw new MyException("Ln can be less than 1!");
                }
            }
            else if(this.leftChild is e)
            {
                return new digits(this.leftChild.leftChild.inside);
            }
            else if (this.leftChild is power)
            {
                ln l = new ln(this.leftChild.leftChild);
                multi m = new multi(this.leftChild.rightChild, l);
                return m;
            }
            return this;
        }
        public override string ToString()
        {
            return "ln(" + leftChild.ToString() + ")";
        }
    }
}
