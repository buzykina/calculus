using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Assignment1
{
    public class BinaryTree
    {
        public Node root { get; set; }
        private List<char> possibleExp;
        public TextFileHelper helper;
        public string TestString;
        private double almostzero;
        public List<string> file;
        public BinaryTree()
        {
            this.root = null;
            possibleExp = new List<char>();
            helper = new TextFileHelper();
            TestString = "";
            almostzero = 0.1;
            file = new List<string>();
        }

        private Node CreateBinaryTree(Node root,ref string value)
        {
            try
            {
                file.Clear();
                if (root == null)
                {
                    string s = value.Substring(0, 1);
                    this.CheckIfValid(s);
                    if (IsNumeric(s) || (s == "-" && value.Substring(1, 1) != "(" && IsNumeric(value.Substring(1, 1))))
                    {
                        value = value.Substring(1);
                        foreach (char c in value)
                        {
                            if (IsNumeric(c.ToString()) || c == '.' || c == '-')
                            {
                                s = s + c.ToString();
                                value = value.Substring(1);
                            }
                            if (c == ',' || c == ')')
                            {
                                break;
                            }
                        }
                        return new digits(s);
                    }
                    else if (s == "(")
                    {
                        value = value.Substring(1);
                        return this.CreateBinaryTree(root, ref value);
                    }
                    else if (s == " ")
                    {
                        value = value.Substring(1);
                        return this.CreateBinaryTree(root, ref value);
                    }
                    else if (s == ",")
                    {
                        value = value.Substring(1);
                        return CreateBinaryTree(root, ref value);
                    }
                    else if (s == ")")
                    {
                        value = value.Substring(1);
                        return CreateBinaryTree(root, ref value);
                    }
                    else if (s == "+")
                    {
                        value = value.Substring(1);
                        root = new plus(null, null);
                    }
                    else if (s == "-" && value.Substring(1, 1) == "(")
                    {
                        value = value.Substring(1);
                        root = new minus(null, null);
                        ((minus)root).negative = false;
                    }
                    else if (s == "-" && value.Substring(1, 1) != "(")
                    {
                        value = value.Substring(1);
                        root = new minus(null);
                        ((minus)root).negative = true;
                    }
                    else if (s == "*")
                    {
                        value = value.Substring(1);
                        root = new multi(null, null);
                    }
                    else if (s == "/")
                    {
                        value = value.Substring(1);
                        root = new division(null, null);
                    }
                    else if (s == "^")
                    {
                        value = value.Substring(1);
                        root = new power(null, null);
                    }
                    else if (s == "s")
                    {
                        value = value.Substring(1);
                        root = new sin(null);
                    }
                    else if (s == "c")
                    {
                        value = value.Substring(1);
                        root = new cos(null);
                    }
                    else if (s == "l")
                    {
                        value = value.Substring(1);
                        root = new ln(null);
                    }
                    else if (s == "r")
                    {
                        value = value.Substring(1);
                        root = new realnumb(null);
                    }
                    else if (s == "n")
                    {
                        value = value.Substring(1);
                        root = new natural(null);
                    }
                    else if (s == "e")
                    {
                        value = value.Substring(1);
                        root = new e(null);
                    }
                    else if (s == "x")
                    {
                        value = value.Substring(1);
                        return new variables(s);
                    }
                    else if (s == "p")
                    {
                        value = value.Substring(1);
                        return new pi("3.14");
                    }
                    else if (s == "!")
                    {
                        value = value.Substring(1);
                        root = new _(null);
                    }
                    root.leftChild = CreateBinaryTree(root.leftChild, ref value);
                    if (s != "e" && s != "!" && s != "n" && s != "r" && s != "l" && s != "c" && s != "s")
                    {
                        if (root is minus)
                        {
                            if (((minus)root).negative == false)
                            {
                                root.rightChild = CreateBinaryTree(root.rightChild, ref value);
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            root.rightChild = CreateBinaryTree(root.rightChild, ref value);
                        }
                    }
                    return root;
                }
                else
                {
                    return root;
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                throw new MyException("Formula is not written correctly!");
            }          
        }
        private bool IsNumeric(string s)
        {
            if(s == "0" || s == "1" || s == "2" || s == "3" || s == "4" || s == "5" || s == "6" || s == "7" || s == "8" || s == "9")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public BinaryTree Create(string value)
        {
            root = null;
            root = this.CreateBinaryTree(root, ref value);
            root = root.Simplify();
            return this;
        }
        public BinaryTree CreateMcLaurinAn(string value,int n)
        {
            root = null;
            Node root1 = this.CreateBinaryTree(root, ref value);
            digits d = new digits(root1.Calculations(0).ToString());
            _ fac = new _(new digits("0"));
            digits d1 = new digits(fac.Calculations(0).ToString());
            division div = new division(d, d1);
            power pow = new power(new variables("x"), new digits("0"));
            multi m = new multi(div, pow);
            root = m;
            for (int i = 1;i <= n;i++)
            {
                root1 = root1.Derivative();
                digits dd = new digits(root1.Calculations(0).ToString());
                _ fac1 = new _(new digits($"{i}"));
                digits dd1 = new digits(fac1.Calculations(0).ToString());
                division div1 = new division(dd, dd1);
                power pow1 = new power(new variables("x"), new digits($"{i}"));
                multi m1 = new multi(div1, pow1);
                plus p = new plus(root, m1);
                root = p;
            }
            return this;
        }
        public BinaryTree MakePolonomialFunction(double[] coef)
        {
            root = null;
            int p = coef.Length - 1;
            for (int i = 0; i < coef.Length; i++)
            {
                if(i == 0)
                {
                    digits d = new digits(coef[i].ToString());
                    power power = new power(new variables("x"), new digits(p.ToString()));
                    multi m = new multi(d, power);
                    root = m;
                    p--;
                }
                else
                {
                    digits d = new digits(coef[i].ToString());
                    power power = new power(new variables("x"), new digits(p.ToString()));
                    multi m = new multi(d, power);
                    plus plus = new plus(root, m);
                    root = plus;
                    p--;
                }
            }
            root = root.Simplify();
            return this;
        }
        public BinaryTree MakePolonomialFunctionLagrange(int[] points)
        {
            root = null;
            int[] x = new int[points.Length / 2];
            int[] y = new int[points.Length / 2];
            int xat = 0;
            int yat = 0;
            for(int i = 0;i<points.Length;i++)
            {
                if(i%2==0)
                {
                    x[xat] = points[i];
                    xat++;
                }
                else
                {
                    y[yat] = points[i];
                    yat++;
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                int count = 0;
                int time = 0;
                double total = 1;
                Node temp = null;
                while(count < x.Length)
                {
                    if( i != count)
                    {
                        total = total * (x[i]-x[count]);
                        time++;
                        if(time == 1)
                        {
                            variables var = new variables("x");
                            digits d = new digits(x[count].ToString());
                            minus m = new minus(var, d);
                            temp = m;
                        }
                        else
                        {
                            variables var = new variables("x");
                            digits d = new digits(x[count].ToString());
                            minus m = new minus(var, d);
                            temp = new multi(temp,m);
                        }
                    }
                    count++;
                }
                total = y[i] / total;
                digits d1 = new digits(total.ToString());
                multi m1 = new multi(temp, d1);
                temp = m1;
                if (i == 0)
                {
                    root = temp;
                }
                else
                {
                    plus p = new plus(root, temp);
                    root = p;
                }
            }
            root = root.Simplify();
            return this;
        }
        public double CreateMcLaurinPlot(double x)
        {
            return this.root.Calculations(x);
        }
        public string Read()
        {
            if(root != null)
            {
                root = root.Simplify();
                return root.ToString();
            }
            return "";
        }
        public string ReadMc()
        {
            return root.ToString();
        }
        public string ReadDerivative()
        {
            root = this.root.Derivative();
            root = root.Simplify();
            return root.ToString();
        }
        public void DrawBinaryTreeDerivative()
        {
            this.Read();
            this.PrintTree(root.Derivative().Simplify(), 1, null, 1);
            helper.savingFile(file); 
        }
        public void DrawBinaryTree()
        {
            this.Read();
            this.PrintTree(root, 1, null, 1);
            helper.savingFile(file);
        }
        public BinaryTree CreateMcLaurinPlotN(string v,int n)
        {
            double[] functions = new double[n+1];
            int power = 0;
            root = null;
            Node root1 = this.CreateBinaryTree(root, ref v);
            while (power <= n)
            {
                double result = 0;
                int[] coef = this.coef(power);
                int powerindex = power;
                for (int i = 0; i <= power; i++)
                { 
                    result = result + coef[i]*root1.Calculations(powerindex * this.almostzero);
                    powerindex--;
                }
                if (power == 0)
                {
                    functions[power] = result;
                    digits d = new digits(result.ToString());
                    _ fac = new _(new digits("0"));
                    digits d1 = new digits(fac.Calculations(0).ToString());
                    division div = new division(d, d1);
                    power pow = new power(new variables("x"), new digits("0"));
                    multi m = new multi(div, pow);
                    root = m;
                }
                else
                {
                    functions[power] = result / Math.Pow(this.almostzero, power);
                    digits dd = new digits(Math.Round(functions[power],2).ToString());
                    _ fac1 = new _(new digits($"{power}"));
                    digits dd1 = new digits(fac1.Calculations(0).ToString());
                    division div1 = new division(dd, dd1);
                    power pow1 = new power(new variables("x"), new digits($"{power}"));
                    multi m1 = new multi(div1, pow1);
                    plus p = new plus(root, m1);
                    root = p;
                }
                power++;
            }
            //double d = root.Calculations(x + this.almostzero);
            //double d1 = root.Calculations(x);
            //double d2 = (d - d1);
            //double d3 = d2 / this.almostzero;
            return this;
        }
        private int[] coef(int n)
        {
            int[] newarr = new int[n + 1];
            int[] oldarray = new int[n];
            if (n == 0)
            {
                newarr[0] = 1;
            }
            else if(n == 1)
            {
                newarr[0] = 1;
                newarr[1] = 1;
            }
            else
            {
                oldarray[0] = 1;
                oldarray[1] = 1;
                for(int i = 0; i <= n - 2;i++)
                {
                    newarr = new int[n + 1];
                    newarr[0] = 1;
                    newarr[oldarray.Length - 1] = 1;
                    for (int j = 1; j < oldarray.Length; j++)
                    {
                        newarr[j] = oldarray[j - 1] + oldarray[j];
                    }
                    oldarray = new int[newarr.Length];
                    oldarray = newarr;
                }
            }
            for(int i = 0; i < newarr.Length;i++)
            {
                if(i % 2 != 0)
                {
                    int num = newarr[i];
                    newarr[i] = -1 * num;
                }
            }
            return newarr;
        }
        public double DerivativeNeuton(double x)
        {
            double d = root.Calculations(x + this.almostzero);
            double d1 = root.Calculations(x);
            double d2 = (d - d1);
            double d3 = d2/this.almostzero;
            return d3;
        }
        public double CalculateDer(double x)
        {
            double d = root.Derivative().Calculations(x);
            return d;
        }

        public double Calculate(double x)
        {
            double d = root.Calculations(x);
            return d;
        }
        private void CheckIfValid(string s)
        {
            char[] ch = s.ToCharArray();
            this.AddExpressionToList();
            if(!possibleExp.Contains(ch[0]))
            {
                throw new MyException("Incorrect symbol!Please type your formula in correct format again.");
            }
        }

        public void PrintTree(Node CurrentNode, int id, Node Parent, int idParent)
        {
            if (CurrentNode == null)
            {
                return;
            }
            if (Parent != null)
            {
                TestString = "   node" + idParent.ToString() + " -- " + "node" + id.ToString();
                file.Add(TestString);
            }
            TestString = "   node" + id.ToString() + " [ label = " + '\u0022' + CurrentNode.inside + '\u0022' + " ]";
            file.Add(TestString);
            PrintTree(CurrentNode.leftChild, id * 2, CurrentNode, id);
            PrintTree(CurrentNode.rightChild, id * 2 + 1, CurrentNode, id);
        }
        //private char 
        private void AddExpressionToList()
        {
            possibleExp.Add('n');
            possibleExp.Add('r');
            possibleExp.Add('+');
            possibleExp.Add('*');
            possibleExp.Add('-');
            possibleExp.Add(' ');
            possibleExp.Add('/');
            possibleExp.Add('^');
            possibleExp.Add('s');
            possibleExp.Add('c');
            possibleExp.Add('e');
            possibleExp.Add('l');
            possibleExp.Add('!');
            possibleExp.Add('p');
            possibleExp.Add('x');
            possibleExp.Add('1');
            possibleExp.Add('2');
            possibleExp.Add('3');
            possibleExp.Add('4');
            possibleExp.Add('5');
            possibleExp.Add('6');
            possibleExp.Add('7');
            possibleExp.Add('8');
            possibleExp.Add('9');
            possibleExp.Add('0');
            possibleExp.Add(',');
            possibleExp.Add('(');
            possibleExp.Add(')');
        }
    }
}

