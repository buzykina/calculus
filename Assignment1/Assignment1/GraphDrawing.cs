using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public class GraphDrawing
    {
        private int coef;
        private PictureBox p1;
        Graphics g;
        BinaryTree tree;
        BinaryTree treeDerA;
        BinaryTree treeDerN;
        BinaryTree treeI;
        BinaryTree treeMclN;
        BinaryTree treeMclA;
        BinaryTree treePolMat;
        BinaryTree treePolLa;
        private double High;
        private double Low;
        private int X;
        public GraphDrawing(PictureBox p2, int c)
        {
            this.coef = c;
            p1 = p2;
            tree = new BinaryTree();
            treeDerA = new BinaryTree();
            treeDerN = new BinaryTree();
            treeMclA = new BinaryTree();
            treeMclN = new BinaryTree();
            treeI = new BinaryTree();
            treePolMat = new BinaryTree();
            treePolLa = new BinaryTree();
            p1.Paint += MakePlot;
            g = p1.CreateGraphics();
        }
        private void MakePlot(object sender,PaintEventArgs e)
        {
            Graphics g1 = e.Graphics;
            float xin = p1.Width / 2;
            float yin = p1.Height / 2;
            g1.TranslateTransform(xin, yin);
            for(float i = -xin;i<=xin;i+=this.coef)
            {
                g1.DrawLine(Pens.LightGray, i, -yin, i, yin);
                g1.DrawString((i/ this.coef).ToString(), SystemFonts.DefaultFont, Brushes.Black, i, 0);
            }
            for (float i = yin; i >= -yin; i -= this.coef)
            {
                g1.DrawLine(Pens.LightGray, xin, i, -xin, i);
                g1.DrawString((i / this.coef).ToString(), SystemFonts.DefaultFont, Brushes.Black, 0, -i);
            }
            g1.DrawLine(Pens.Black, 0, -yin, 0, yin);
            g1.DrawLine(Pens.Black, -xin, 0, xin, 0);
        }
        public void DrawFunction(BinaryTree tree)
        {
            this.tree = tree;
            Graphics g = p1.CreateGraphics();
            float xin = p1.Width / 2;
            float yin = p1.Height / 2;
            g.TranslateTransform(xin, yin);
            for (float i = -xin; i <= xin; i++)
            {
                try
                {
                    float x1 = i / this.coef;
                    float x2 = (i + 1) / this.coef;
                    float y1 = (float)tree.Calculate(x1);
                    float y2 = (float)tree.Calculate(x2);
                    g.DrawLine(Pens.Red, x1 * this.coef, -y1 * this.coef, x2 * this.coef, -y2 * this.coef);
                }
                catch(OverflowException)
                {
                    
                }
            }
        }
        public void DrawFunctionPolMat(BinaryTree tree)
        {
            this.treePolMat = tree;
            Graphics g = p1.CreateGraphics();
            float xin = p1.Width / 2;
            float yin = p1.Height / 2;
            g.TranslateTransform(xin, yin);
            for (float i = -xin; i <= xin; i++)
            {
                try
                {
                    float x1 = i / this.coef;
                    float x2 = (i + 1) / this.coef;
                    float y1 = (float)tree.Calculate(x1);
                    float y2 = (float)tree.Calculate(x2);
                    g.DrawLine(Pens.Chartreuse, x1 * this.coef, -y1 * this.coef, x2 * this.coef, -y2 * this.coef);
                }
                catch (OverflowException)
                {

                }
            }
        }
        public void DrawFunctionPolLa(BinaryTree tree)
        {
            this.treePolLa = tree;
            Graphics g = p1.CreateGraphics();
            float xin = p1.Width / 2;
            float yin = p1.Height / 2;
            g.TranslateTransform(xin, yin);
            for (float i = -xin; i <= xin; i++)
            {
                try
                {
                    float x1 = i / this.coef;
                    float x2 = (i + 1) / this.coef;
                    float y1 = (float)tree.Calculate(x1);
                    float y2 = (float)tree.Calculate(x2);
                    g.DrawLine(Pens.BlueViolet, x1 * this.coef, -y1 * this.coef, x2 * this.coef, -y2 * this.coef);
                }
                catch (OverflowException)
                {

                }
            }
        }
        public void DrawDer(BinaryTree tree)
        {
            this.treeDerA = tree;
            Graphics g = p1.CreateGraphics();
            float xin = p1.Width / 2;
            float yin = p1.Height / 2;
            g.TranslateTransform(xin, yin);
            for (float i = -xin; i <= xin; i++)
            {
                try
                {
                    float x1 = i / this.coef;
                    float x2 = (i + 1) / this.coef;
                    float y1 = (float)tree.CalculateDer(x1);
                    float y2 = (float)tree.CalculateDer(x2);
                    g.DrawLine(Pens.Orange, x1 * this.coef, -y1 * this.coef, x2 * this.coef, -y2 * this.coef);
                }
                catch (OverflowException)
                {

                }
            }
        }
        public void DrawDerNe(BinaryTree tree)
        {
            this.treeDerN = tree;
            float xin = p1.Width / 2;
            float yin = p1.Height / 2;
            Graphics g = p1.CreateGraphics();
            g.TranslateTransform(xin, yin);
            for (float i = -xin; i <= xin; i++)
            {
                try
                {
                    float x1 = i / this.coef;
                    float x2 = (i + 1) / this.coef;
                    float y1 = (float)tree.DerivativeNeuton(x1);
                    float y2 = (float)tree.DerivativeNeuton(x2);
                    g.DrawLine(Pens.Orange, x1 * this.coef, -y1 * this.coef, x2 * this.coef, -y2 * this.coef);
                }
                catch (OverflowException)
                {

                }
            }
        }
        public void DrawMcLaurin(BinaryTree tree)
        {
            this.treeMclA = tree;
            float xin = p1.Width / 2;
            float yin = p1.Height / 2;
            Graphics g = p1.CreateGraphics();
            g.TranslateTransform(xin, yin);
            for (float i = -xin; i <= xin; i++)
            {
                try
                {
                    float x1 = i / this.coef;
                    float x2 = (i + 1) / this.coef;
                    float y1 = (float)tree.CreateMcLaurinPlot(x1);
                    float y2 = (float)tree.CreateMcLaurinPlot(x2);
                    g.DrawLine(Pens.Pink, x1 * this.coef, -y1 * this.coef, x2 * this.coef, -y2 * this.coef);
                }
                catch (OverflowException)
                {

                }
            }
        }
        public void DrawMcLaurinNewton(BinaryTree tree)
        {
            this.treeMclA = tree;
            float xin = p1.Width / 2;
            float yin = p1.Height / 2;
            Graphics g = p1.CreateGraphics();
            g.TranslateTransform(xin, yin);
            for (float i = -xin; i <= xin; i++)
            {
                try
                {
                    float x1 = i / this.coef;
                    float x2 = (i + 1) / this.coef;
                    float y1 = (float)tree.CreateMcLaurinPlot(x1);
                    float y2 = (float)tree.CreateMcLaurinPlot(x2);
                    g.DrawLine(Pens.Aqua, x1 * this.coef, -y1 * this.coef, x2 * this.coef, -y2 * this.coef);
                }
                catch (OverflowException)
                {

                }
            }
        }

        public double Intergral (BinaryTree tree,double high, double low)
        {
            double integralsum = 0;
            double number = 0;
            this.treeI = tree;
            this.High = high;
            this.Low = low;
            float xin = p1.Width / 2;
            float yin = p1.Height / 2;
            Graphics g = p1.CreateGraphics();
            g.TranslateTransform(xin, yin);
            for (float i = (float)low*this.coef; i <= (float)high*this.coef; i++)
            {
                try
                {
                    float x1 = i / this.coef;
                    float y1 = (float)tree.Calculate(x1);
                    if(y1 * this.coef >= 0)
                    {
                        g.FillRectangle(Brushes.Green, x1 * this.coef, -y1 * this.coef, 1, y1 * this.coef);
                        integralsum += 1 * y1;
                        number++;
                    }
                   else
                    {
                        g.FillRectangle(Brushes.Green, x1 * this.coef, 0, 1, -y1 * this.coef);
                        integralsum -= 1 * (-y1);
                        number++;
                    }
                   
                }
                catch (OverflowException)
                {

                }
            }
            return integralsum*((high - low)/number);
        }
        public void ClearGraph()
        {
            tree = new BinaryTree();
            treeDerA = new BinaryTree();
            treeDerN = new BinaryTree();
            treeI = new BinaryTree();
            p1.Refresh();
        }
        public void ZoomIn()
        {
            if (this.coef <= 75)
            {
                this.coef += 25;
            }
            p1.Refresh();
            this.Refresh();
        }
        public void ZoomOut()
        {
            if(this.coef >= 50)
            {
                this.coef -= 25;
            }
            p1.Refresh();
            this.Refresh();
        }
        public void Refresh()
        {
            p1.Refresh();
            if (tree != null && tree.root != null)
            {
                this.DrawFunction(tree);
            }
            if (treeDerA != null && treeDerA.root != null)
            {
                this.DrawDer(treeDerA);
            }
            if (treeDerN != null && treeDerN.root != null)
            {
                this.DrawDerNe(treeDerN);
            }
            if (treeI != null && treeI.root != null)
            {
                this.Intergral(treeI, this.High, this.Low);
            }
            if (treeMclA != null && treeMclA.root != null)
            {
                this.DrawMcLaurin(treeMclA);
            }
            if (treeMclN != null && treeMclN.root != null)
            {
                this.DrawMcLaurinNewton(treeMclN);
            }
            if (treePolLa != null && treePolLa.root != null)
            {
                this.DrawMcLaurinNewton(treeMclN);
            }
            if (treePolMat != null && treePolMat.root != null)
            {
                this.DrawFunctionPolMat(treePolMat);
            }
            if (treePolLa != null && treePolLa.root != null)
            {
                this.DrawFunctionPolLa(treePolLa);
            }
        }
    }
}
