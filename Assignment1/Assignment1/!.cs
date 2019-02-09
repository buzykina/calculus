using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class _ : Node
    {
        public _(Node left) : base(left, null, "!")
        {

        }
        public override double Calculations(double x)
        {
            if(this.leftChild.inside == "0")
            {
                return 1;
            }
            double factorial = 1;
            for (int i = 1; i <= Convert.ToInt32(leftChild.Calculations(x)); i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public override Node Simplify()
        {
            return new digits(this.Calculations(0).ToString());
        }

        public override Node Derivative()
        {
            return new digits("0");
        }

        public override string ToString()
        {
            return "!(" + this.leftChild.ToString() + ")";
        }
    }
}
