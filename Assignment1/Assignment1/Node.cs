using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public abstract class Node
    {
        public Node leftChild { set; get; }
        public Node rightChild { set; get; }
        public string inside { private set; get; }
        public Node(Node leftChild, Node rightChild, string inside)
        {
            this.leftChild = leftChild;
            this.rightChild = rightChild;
            this.inside = inside;
        }
        public abstract double Calculations(double x);
        public abstract Node Derivative();
        public abstract Node Simplify();
        public abstract override string ToString();
    }
}
