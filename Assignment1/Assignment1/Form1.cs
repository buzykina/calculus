using OxyPlot;
using OxyPlot.Series;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        BinaryTree tree;
        BinaryTree treeDerA;
        BinaryTree treeDerN;
        BinaryTree treeI;
        BinaryTree treeLaurAn;
        BinaryTree treeLaurN;
        BinaryTree treePolonomial;
        BinaryTree treePolonomialL;
        Process dot;
        public PictureBox p { get { return p; } set { p = pictureBox1; } }
        GraphDrawing draw;
        int[] points;
        int coef;
        public Form1()
        {
            InitializeComponent();
            tree = new BinaryTree();
            treeDerA = new BinaryTree();
            treeDerN = new BinaryTree();
            treeI = new BinaryTree();
            treePolonomial = null;
            treeLaurAn = new BinaryTree();
            treeLaurN = new BinaryTree();
            treePolonomialL = new BinaryTree();
            dot = new Process();
            pbxPlot.Height = 700;
            pbxPlot.Width = 700;
            coef = 25;
            draw = new GraphDrawing(pbxPlot, this.coef);
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                string v = tbxFormula.Text;
                if (rbtnPrefix.Checked)
                {
                    if (v != "")
                    {
                        tree = tree.Create(v);
                        lblFunction.Text = tree.Read();
                    }
                    else
                    {
                        MessageBox.Show("Please, write a valid formula!");
                    }
                }
                else
                {
                    MessageBox.Show("Please, select the radio button!");
                }
            }
            catch (MyException m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void btnBinaryTree_Click(object sender, EventArgs e)
        {
            string v = tbxFormula.Text;
            if (rbtnPrefix.Checked)
            {
                if (v != "")
                {
                    tree = tree.Create(v);
                    tree.DrawBinaryTree();
                    dot.StartInfo.FileName = "dot.exe";
                    dot.StartInfo.Arguments = "dot -Tpng -oabc.png abc.dot";
                    dot.Start();
                    dot.WaitForExit();
                    pictureBox1.ImageLocation = "abc.png";
                    tabControl1.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("Please, write a valid formula!");
                }
            }
            else
            {
                MessageBox.Show("Please, select the radio button!");
            }
        }

        private void btn_Function_Click(object sender, EventArgs e)
        {
            try
            {
                string v = tbxFormula.Text;
                if (rbtnPrefix.Checked)
                {
                    if (v != "")
                    {
                        tabControl1.SelectedIndex = 0;
                        tree = tree.Create(v);
                        draw.DrawFunction(tree);
                    }
                    else
                    {
                        MessageBox.Show("Please, write a valid formula!");
                    }
                }
                else
                {
                    MessageBox.Show("Please, select the radio button!");
                }
            }
            catch (MyException m)
            {
                MessageBox.Show(m.Message);
            }
            catch(StackOverflowException)
            {

            }
        }

        private void btnParseDerivative_Click(object sender, EventArgs e)
        {
            try
            {
                string v = tbxFormula.Text;
                if (rbtnPrefix.Checked)
                {
                    if (v != "")
                    {
                        treeDerA = treeDerA.Create(v);
                        lblFunction.Text = treeDerA.ReadDerivative();
                    }
                    else
                    {
                        MessageBox.Show("Please, write a valid formula!");
                    }
                }
                else
                {
                    MessageBox.Show("Please, select the radio button!");
                }
            }
            catch(StackOverflowException)
            {

            }
            catch(MyException m)
            {
                MessageBox.Show(m.Message);
            }
            
        }

        private void btnBinaryDerivative_Click(object sender, EventArgs e)
        {
            string v = tbxFormula.Text;
            if (rbtnPrefix.Checked)
            {
                if (v != "")
                {
                    treeDerN = treeDerN.Create(v);
                    treeDerN.DrawBinaryTreeDerivative();
                    dot.StartInfo.FileName = "dot.exe";
                    dot.StartInfo.Arguments = "dot -Tpng -oabc.png abc.dot";
                    dot.Start();
                    dot.WaitForExit();
                    pictureBox1.ImageLocation = "abc.png";
                    tabControl1.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("Please, write a valid formula!");
                }
            }
            else
            {
                MessageBox.Show("Please, select the radio button!");
            }
        }

        private void btnDrawDerAn_Click(object sender, EventArgs e)
        {
            try
            { 
                    string v = tbxFormula.Text;
                    if (rbtnPrefix.Checked)
                    {
                        if (v != "")
                        {
                            tabControl1.SelectedIndex = 0;
                            treeDerA = treeDerA.Create(v);
                            treeDerA.DrawBinaryTreeDerivative();
                            this.draw.DrawDer(treeDerA);
                        }
                        else
                        {
                            MessageBox.Show("Please, write a valid formula!");
                        }
                    }
                else
                {
                    MessageBox.Show("Please, select the radio button!");
                }
            }
            catch (MyException m)
            {
                MessageBox.Show(m.Message);
            }
}

        private void btnDrawDerNew_Click(object sender, EventArgs e)
        {
            try
            {
                string v = tbxFormula.Text;
                if (rbtnPrefix.Checked)
                {
                    if (v != "")
                    {
                        tabControl1.SelectedIndex = 0;
                        treeDerN = treeDerN.Create(v);
                        treeDerN.DrawBinaryTreeDerivative();
                        this.draw.DrawDerNe(treeDerN);
                    }
                    else
                    {
                        MessageBox.Show("Please, write a valid formula!");
                    }
                }
                else
                {
                    MessageBox.Show("Please, select the radio button!");
                }
            }
            catch (MyException m)
            {
                MessageBox.Show(m.Message);
            }
        }
        private void DrawDerivativeNeuton()
        {
            var myModel = new PlotModel { Title = tree.ReadDerivative() };
            FunctionSeries series = new FunctionSeries();
            for (double i = -100; i < 100; i++)
            {
                double y = tree.DerivativeNeuton(i);
                series.Points.Add(new DataPoint(i, y));
            }

            myModel.Series.Add(series);
            this.plot1.Model = myModel;
        }
        private void DrawPrimitive()
        {
            var myModel = new PlotModel { Title = tree.Read() };
            FunctionSeries series = new FunctionSeries();
            for (double i = -10; i < 10; i++)
            {
                double y = tree.Calculate(i);
                series.Points.Add(new DataPoint(i, y));
            }
            myModel.Series.Add(series);
            this.plot1.Model = myModel;
        }
        private void DrawDerivativeAna()
        {
            var myModel = new PlotModel { Title = tree.ReadDerivative() };
            FunctionSeries series = new FunctionSeries();
            for (double i = -10; i < 10; i++)
            {
                double y = tree.CalculateDer(i);
                series.Points.Add(new DataPoint(i, y));
            }
            myModel.Series.Add(series);
            this.plot1.Model = myModel;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            draw.ZoomIn();
            pictureBox1.Invalidate();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            draw.ZoomOut();
            pictureBox1.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            draw.ClearGraph();
        }

        private void btnIntegral_Click(object sender, EventArgs e)
        {
            string v = tbxFormula.Text;
            string lower = tbxLowerBoundary.Text;
            string higher = tbxHigherBoundary.Text;
            if (rbtnPrefix.Checked)
            {
                if (v != "" && lower != "" && higher != "")
                {
                    if(tree.root != null)
                    {
                        tabControl1.SelectedIndex = 0;
                        draw.DrawFunction(tree);
                        treeI = treeI.Create(v);
                        try
                        {
                            double low = Convert.ToDouble(lower);
                            double high = Convert.ToDouble(higher);
                            if (high > low)
                            {
                                lblIntegral.Text = "";
                                lblIntegral.Text = "Riemann's Integral is " + Math.Round(draw.Intergral(tree, high, low), 4).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Please, write low and high boundaries correctly!");
                            }
                        }
                        catch (InvalidCastException)
                        {
                            MessageBox.Show("Please, write a number!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please, draw a function first!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please, write a valid formula!");
                }
            }
            else
            {
                MessageBox.Show("Please, select the radio button!");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            draw.Refresh();
        }

        private void btnMcLaurinAna_Click(object sender, EventArgs e)
        {
            try
            {
                string v = tbxFormula.Text;
                if (rbtnPrefix.Checked)
                {
                    if (v != "")
                    {
                        tabControl1.SelectedIndex = 0;
                        treeLaurAn = treeLaurAn.CreateMcLaurinAn(v, (int)nudSeriesNumber.Value);
                        lblFunction.Text = treeLaurAn.ReadMc();
                        this.draw.DrawMcLaurin(treeLaurAn);
                    }
                    else
                    {
                        MessageBox.Show("Please, write a valid formula!");
                    }
                }
                else
                {
                    MessageBox.Show("Please, select the radio button!");
                }
            }
            catch (MyException m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void btnMcLaurinTree_Click(object sender, EventArgs e)
        {
            string v = tbxFormula.Text;
            if (rbtnPrefix.Checked)
            {
                if (v != "")
                {

                    treeLaurAn = treeLaurAn.CreateMcLaurinAn(v, (int)nudSeriesNumber.Value);
                    lblFunction.Text = treeLaurAn.Read();
                    treeLaurAn.DrawBinaryTree();
                    dot.StartInfo.FileName = "dot.exe";
                    dot.StartInfo.Arguments = "dot -Tpng -oabc.png abc.dot";
                    dot.Start();
                    dot.WaitForExit();
                    pictureBox1.ImageLocation = "abc.png";
                    tabControl1.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("Please, write a valid formula!");
                }
            }
            else
            {
                MessageBox.Show("Please, select the radio button!");
            }
        }

        private void btnMcLaurinNew_Click(object sender, EventArgs e)
        {
            try
            {
                string v = tbxFormula.Text;
                if (rbtnPrefix.Checked)
                {
                    if (v != "")
                    {
                        tabControl1.SelectedIndex = 0;
                        treeLaurN = treeLaurN.CreateMcLaurinPlotN(v, (int)nudSeriesNumber.Value);
                        lblFunction.Text = treeLaurN.ReadMc();
                        this.draw.DrawMcLaurinNewton(treeLaurN);
                        //lblMcLaurin.Text = treeLaurAn.Read();
                        //this.draw.DrawMcLaurinNew(treeLaurAn, (int)nudSeriesNumber.Value);
                        //MessageBox.Show(s);
                    }
                    else
                    {
                        MessageBox.Show("Please, write a valid formula!");
                    }
                }
                else
                {
                    MessageBox.Show("Please, select the radio button!");
                }
            }
            catch (MyException m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            decimal x = npdXValue.Value;
            decimal y = npdYValue.Value;
            lbxPoints.Items.Add($"({x},{y})");
        }

        private void btnRemovePoint_Click(object sender, EventArgs e)
        {
            if (lbxPoints.Items.Count == 0)
            {
                MessageBox.Show("Nothing to remove!");
            }
            else if (lbxPoints.SelectedItem == null)
            {
                MessageBox.Show("Please select a point you want to remove!");
            }
            else
            {
                lbxPoints.Items.Remove(lbxPoints.SelectedItem);
            }
        }

        private void btnPolonomial_Click(object sender, EventArgs e)
        {
            if (lbxPoints.Items.Count < 2)
            {
                MessageBox.Show("Please, add some points to get a polonomial!");
            }
            else
            {
                Polonomial polonomial = new Polonomial();
                points = new int[lbxPoints.Items.Count * 2];
                int index = 0;
                for (int i = 0; i < lbxPoints.Items.Count; i++)
                {
                    string point = lbxPoints.Items[i].ToString();
                    string s = point.Substring(0, 1);
                    while (s != ")")
                    {
                        if (s == "(")
                        {
                            point = point.Substring(1);
                            s = point.Substring(0, 1);
                        }
                        else if (s == ",")
                        {
                            point = point.Substring(1);
                            s = point.Substring(0, 1);
                        }
                        else
                        {
                            string number = "";
                            while (s != "," && s != ")")
                            {
                                number = number + s;
                                point = point.Substring(1);
                                s = point.Substring(0, 1);
                            }
                            points[index] = Convert.ToInt32(number);
                            index++;
                        }
                    }
                }
                if (points[0] == 0)
                {
                    int x = points[0];
                    int y = points[1];
                    points[0] = points[2];
                    points[1] = points[3];
                    points[2] = x;
                    points[3] = y;
                }
                for (int i = 0; i < points.Length; i += 2)
                {
                    polonomial.MakesRows(lbxPoints.Items.Count, points[i], points[i + 1]);
                }
                treePolonomial = polonomial.MakeBinaryTreePolonomial();
                draw.DrawFunctionPolMat(treePolonomial);
                lblFunction.Text = treePolonomial.Read();
            }
        }

        private void btnLagrangePolonomial_Click(object sender, EventArgs e)
        {
            if (lbxPoints.Items.Count < 2)
            {
                MessageBox.Show("Please, add some points to get a polonomial!");
            }
            else
            {
                points = new int[lbxPoints.Items.Count * 2];
                int index = 0;
                for (int i = 0; i < lbxPoints.Items.Count; i++)
                {
                    string point = lbxPoints.Items[i].ToString();
                    string s = point.Substring(0, 1);
                    while (s != ")")
                    {
                        if (s == "(")
                        {
                            point = point.Substring(1);
                            s = point.Substring(0, 1);
                        }
                        else if (s == ",")
                        {
                            point = point.Substring(1);
                            s = point.Substring(0, 1);
                        }
                        else
                        {
                            string number = "";
                            while (s != "," && s != ")")
                            {
                                number = number + s;
                                point = point.Substring(1);
                                s = point.Substring(0, 1);
                            }
                            points[index] = Convert.ToInt32(number);
                            index++;
                        }
                    }
                }
                treePolonomialL = treePolonomialL.MakePolonomialFunctionLagrange(points);
                draw.DrawFunctionPolLa(treePolonomialL);
                lblFunction.Text = treePolonomialL.Read();

            }
            }

        private void btnBinaryPolonomial_Click(object sender, EventArgs e)
        {
            if (lbxPoints.Items.Count < 2)
            {
                MessageBox.Show("Please, add some points to get a polonomial!");
            }
            else
            {
                Polonomial polonomial = new Polonomial();
                points = new int[lbxPoints.Items.Count * 2];
                int index = 0;
                for (int i = 0; i < lbxPoints.Items.Count; i++)
                {
                    string point = lbxPoints.Items[i].ToString();
                    string s = point.Substring(0, 1);
                    while (s != ")")
                    {
                        if (s == "(")
                        {
                            point = point.Substring(1);
                            s = point.Substring(0, 1);
                        }
                        else if (s == ",")
                        {
                            point = point.Substring(1);
                            s = point.Substring(0, 1);
                        }
                        else
                        {
                            string number = "";
                            while (s != "," && s != ")")
                            {
                                number = number + s;
                                point = point.Substring(1);
                                s = point.Substring(0, 1);
                            }
                            points[index] = Convert.ToInt32(number);
                            index++;
                        }
                    }
                }
                for (int i = 0; i < points.Length; i += 2)
                {
                    polonomial.MakesRows(lbxPoints.Items.Count, points[i], points[i + 1]);
                }
                treePolonomial = polonomial.MakeBinaryTreePolonomial();
                treePolonomial.DrawBinaryTreeDerivative();
                dot.StartInfo.FileName = "dot.exe";
                dot.StartInfo.Arguments = "dot -Tpng -oabc.png abc.dot";
                dot.Start();
                dot.WaitForExit();
                pictureBox1.ImageLocation = "abc.png";
                tabControl1.SelectedIndex = 1;
            }
        }
    }
}
