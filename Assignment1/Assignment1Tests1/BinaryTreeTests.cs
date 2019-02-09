using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Tests
{
    [TestClass()]
    public class BinaryTreeTests
    {
        [TestMethod()]
        public void PrintTreeTest()
        {
            BinaryTree tree = new BinaryTree();
            tree.Create("/(s(*(p,x)),+(x,5))");
            tree.PrintTree(tree.root, 1, null, 1);
            List<string> expected = new List<string>();
            expected.Add("   node1 [ label = \"/\" ]");
            expected.Add("   node1 -- node2");
            expected.Add("   node2 [ label = \"sin\" ]");
            expected.Add("   node2 -- node4");
            expected.Add("   node4 [ label = \"*\" ]");
            expected.Add("   node4 -- node8");
            expected.Add("   node8 [ label = \"3.14\" ]");
            expected.Add("   node4 -- node9");
            expected.Add("   node9 [ label = \"x\" ]");
            expected.Add("   node1 -- node3");
            expected.Add("   node3 [ label = \"+\" ]");
            expected.Add("   node3 -- node6");
            expected.Add("   node6 [ label = \"x\" ]");
            expected.Add("   node3 -- node7");
            expected.Add("   node7 [ label = \"5\" ]");
            Assert.IsTrue(expected.SequenceEqual(tree.file));
        }

        [TestMethod()]
        public void CreateTree()
        {
            BinaryTree treeCheck = new BinaryTree();
            treeCheck.Create("/(s(*(p,x)),+(x,5))");
            Assert.AreEqual("(sin((3.14*x))/(x+5))", treeCheck.root.ToString());
        }
        [TestMethod()]
        public void Simplification()
        {
            BinaryTree treeCheck = new BinaryTree();
            treeCheck.Create("+(+(l(e(2)),l(1)),-(1,/(0,x)))");
            Assert.AreEqual("3", treeCheck.root.ToString());
            treeCheck.Create("+(-(n(r(-1)),!(0)),c(l(e(1))))");
            string answer = treeCheck.Read();
            Assert.AreEqual("(-2+cos(1))", answer);
            treeCheck.Create("+(+(*(0, s(x)), *(e(2), e(10))), +(*(2, 2), *(-s(x), -c(x))))");
            answer = treeCheck.Read();
            Assert.AreEqual("((e^12)+(4+(cos(x)*sin(x))))", answer);
            treeCheck.Create("+(+(/ (2, 1),/ (8, 2)), +(/ (s(x), s(x)), +(/ (e(5), e(3)), e(ln(5))))");
            answer = treeCheck.Read();
            Assert.AreEqual("(6+(1+((e^2)+5)))", answer);
            treeCheck.Create("+(-(l(x), s(x)), +(+(n(0.1), r(-1)),^ (x, 4)))");
            answer = treeCheck.Read();
            Assert.AreEqual("((ln(x)-sin(x))+(-0.9+(x^4)))", answer);
            treeCheck.Create("+(-(^ (5, 1),^ (3, 0)), +(^ (e(5), 4),^ (0, 5)))");
            answer = treeCheck.Read();
            Assert.AreEqual("(4+(e^20))", answer);
            treeCheck.Create("+(+(l(1), l(^ (x, 5))), +(+(l(5), l(5)), -(l(2), l(1))))");
            answer = treeCheck.Read();
            Assert.AreEqual("((5*ln(x))+ln(50))", answer);

        }
        [TestMethod]
        public void LnNotCorrect()
        {
            try
            {
                BinaryTree treeCheck = new BinaryTree();
                treeCheck.Create("+(-(ln(0),^ (3, 0)), +(^ (e(5), 4),^ (0, 5)))");
                Assert.Fail();
            }
            catch(Exception)
            {
                
            }
        }
        [TestMethod()]
        public void Derivative()
        {
            BinaryTree treeCheck = new BinaryTree();
            treeCheck.Create("+(*(c(x),s(x)),+(*(l(x),!(1)),^(1,e(0))))");
            string answer = treeCheck.ReadDerivative();
            Assert.AreEqual("((((-(sin(x)))*sin(x))+(cos(x)*cos(x)))+(1/x))", answer);
            treeCheck.Create("+(-(l(x), s(x)), +(+(n(0.1), r(-1)),^ (x, 4)))");
            answer = treeCheck.ReadDerivative();
            Assert.AreEqual("(((1/x)-cos(x))+((x^3)*4))", answer);
            treeCheck.Create("-(+(+(c(1), e(x)), r(1)), -(/ (x, 3), *(n(0.1), p))))");
            answer = treeCheck.ReadDerivative();
            Assert.AreEqual("((e^x)-0.33)", answer);
            treeCheck.Create("+(!(5), -(-s(x), s(1)))");
            answer = treeCheck.ReadDerivative();
            Assert.AreEqual("(-(cos(x)))", answer);
        }
        [TestMethod()]
        public void McLaurinAn()
        {
            BinaryTree treeCheck = new BinaryTree();
            treeCheck.CreateMcLaurinAn("s(x)", 4);
            string answer = treeCheck.ReadMc();
            Assert.AreEqual("((((((0/1)*(x^0))+((1/1)*(x^1)))+((0/2)*(x^2)))+((-1/6)*(x^3)))+((0/24)*(x^4)))", answer);
        }
        [TestMethod()]
        public void McLaurinNewton()
        {
            BinaryTree treeCheck = new BinaryTree();
            treeCheck.CreateMcLaurinPlotN("s(x)", 4);
            string answer = treeCheck.ReadMc();
            Assert.AreEqual("((((((0/1)*(x^0))+((1/1)*(x^1)))+((-0.1/2)*(x^2)))+((-0.99/6)*(x^3)))+((0.2/24)*(x^4)))", answer);
        }
        [TestMethod()]
        public void DerivativeNeuton()
        {
            BinaryTree treeCheck = new BinaryTree();
            treeCheck.Create("s(x)");
            double answer = treeCheck.DerivativeNeuton(0);
            Assert.AreEqual(1, Math.Round(answer));
        }
        [TestMethod()]
        public void Polonomial()
        {
            Polonomial pol = new Polonomial();
            pol.MakesRows(4, 3, 1);
            pol.MakesRows(4, 2, 2);
            pol.MakesRows(4, -2, 5);
            pol.MakesRows(4, 1, 7);
            BinaryTree treeCheck = pol.MakeBinaryTreePolonomial();
            string answer = treeCheck.Read();
            Assert.AreEqual("((((0.68*(x^3))+(-2.1*(x^2)))+(-3.48*x))+11.9)", answer);
        }
        [TestMethod()]
        public void CalculateDer()
        {
            BinaryTree treeCheck = new BinaryTree();
            treeCheck.Create("s(x)");
            double answer = treeCheck.CalculateDer(0);
            Assert.AreEqual(1, Math.Round(answer));
        }
        [TestMethod()]
        public void CalculateMc()
        {
            BinaryTree treeCheck = new BinaryTree();
            treeCheck.CreateMcLaurinAn("s(x)", 2);
            double answer = treeCheck.CreateMcLaurinPlot(1);
            Assert.AreEqual(1, answer);
        }
        [TestMethod()]
        public void Calculate()
        {
            BinaryTree treeCheck = new BinaryTree();
            treeCheck.Create("s(x)");
            double answer = treeCheck.Calculate(0);
            Assert.AreEqual(0, Math.Round(answer));
        }

        [TestMethod()]
        public void PolonomialLagra()
        {
            int[] points = new int[8];
            points[0] = 2;
            points[1] = 1;
            points[2] = 5;
            points[3] = 2;
            points[4] = 8;
            points[5] = -1;
            points[6] = 9;
            points[7] = -2;
            BinaryTree treeCheck = new BinaryTree();
            treeCheck = treeCheck.MakePolonomialFunctionLagrange(points);
            string answer = treeCheck.Read();
            Assert.AreEqual("(((((((x-5)*(x-8))*(x-9))*-0.01)+((((x-2)*(x-8))*(x-9))*0.06))+((((x-2)*(x-5))*(x-9))*0.06))+((((x-2)*(x-5))*(x-8))*-0.07))", answer);
        }
        
    }
}