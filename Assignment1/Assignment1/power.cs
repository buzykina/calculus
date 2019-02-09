using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class power : Node
    {
        public power(Node leftChild, Node rightChild) : base(leftChild, rightChild, "^")
        {

        }
        public override double Calculations(double x)
        {
            double result = Math.Pow(leftChild.Calculations(x), rightChild.Calculations(x));
            return result;
        }
        public override Node Derivative()
        {
            power p = new power(this.leftChild, new digits((Convert.ToInt32(this.rightChild.inside) - 1).ToString()));
            multi m = new multi(p, new digits(this.rightChild.inside));
            multi m1 = new multi(m, this.leftChild.Derivative());
            return m1;
        }

        public override Node Simplify()
        {
            this.leftChild = this.leftChild.Simplify();
            this.rightChild = this.rightChild.Simplify();
            if (this.leftChild is digits && this.leftChild.inside == "1")
            {
                return new digits("1");
            }
            else if (this.rightChild is digits && this.rightChild.inside == "1")
            {
                return this.leftChild;
            }
            else if (this.rightChild is digits && this.rightChild.inside == "0")
            {
                return new digits("1");
            }
            else if (this.leftChild is digits && this.leftChild.inside == "0")
            {
                return new digits("0");
            }
            else if (this.rightChild is digits && this.leftChild is digits)
            {
                return new digits((Math.Pow(Convert.ToDouble(this.leftChild.inside), Convert.ToDouble(this.rightChild.inside))).ToString());
            }
            else if (this.leftChild is e)
            {
                multi m = new multi(this.leftChild.leftChild, this.rightChild);
                return new e(m);
            }
            return this;
        }

        public override string ToString()
        {
            return "(" + leftChild.ToString() + "^" + rightChild.ToString() + ")";
        }
    }
}
