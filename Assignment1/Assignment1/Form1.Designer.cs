namespace Assignment1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnParse = new System.Windows.Forms.Button();
            this.btnBinaryTree = new System.Windows.Forms.Button();
            this.lblFunction = new System.Windows.Forms.Label();
            this.btn_Function = new System.Windows.Forms.Button();
            this.rbtnPrefix = new System.Windows.Forms.RadioButton();
            this.rbtnInfix = new System.Windows.Forms.RadioButton();
            this.tbxFormula = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.pbxPlot = new System.Windows.Forms.PictureBox();
            this.BinaryTree = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Function = new System.Windows.Forms.TabPage();
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDrawDerNew = new System.Windows.Forms.Button();
            this.btnParseDerivative = new System.Windows.Forms.Button();
            this.btnDrawDerAn = new System.Windows.Forms.Button();
            this.btnBinaryDerivative = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIntegral = new System.Windows.Forms.Label();
            this.tbxHigherBoundary = new System.Windows.Forms.TextBox();
            this.tbxLowerBoundary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIntegral = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMcLaurinTree = new System.Windows.Forms.Button();
            this.btnMcLaurinNew = new System.Windows.Forms.Button();
            this.nudSeriesNumber = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMcLaurinAna = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBinaryPolonomial = new System.Windows.Forms.Button();
            this.btnLagrangePolonomial = new System.Windows.Forms.Button();
            this.npdXValue = new System.Windows.Forms.NumericUpDown();
            this.npdYValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPolonomial = new System.Windows.Forms.Button();
            this.btnRemovePoint = new System.Windows.Forms.Button();
            this.lbxPoints = new System.Windows.Forms.ListBox();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlot)).BeginInit();
            this.BinaryTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Function.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeriesNumber)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdXValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdYValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(266, 190);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(135, 39);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnBinaryTree
            // 
            this.btnBinaryTree.Location = new System.Drawing.Point(266, 91);
            this.btnBinaryTree.Name = "btnBinaryTree";
            this.btnBinaryTree.Size = new System.Drawing.Size(135, 39);
            this.btnBinaryTree.TabIndex = 3;
            this.btnBinaryTree.Text = "Draw Binary Tree";
            this.btnBinaryTree.UseVisualStyleBackColor = true;
            this.btnBinaryTree.Click += new System.EventHandler(this.btnBinaryTree_Click);
            // 
            // lblFunction
            // 
            this.lblFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunction.Location = new System.Drawing.Point(0, 0);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(1760, 33);
            this.lblFunction.TabIndex = 5;
            this.lblFunction.Text = "Here is going to be a formula of your function";
            this.lblFunction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Function
            // 
            this.btn_Function.Location = new System.Drawing.Point(266, 140);
            this.btn_Function.Name = "btn_Function";
            this.btn_Function.Size = new System.Drawing.Size(135, 39);
            this.btn_Function.TabIndex = 8;
            this.btn_Function.Text = "Draw Function";
            this.btn_Function.UseVisualStyleBackColor = true;
            this.btn_Function.Click += new System.EventHandler(this.btn_Function_Click);
            // 
            // rbtnPrefix
            // 
            this.rbtnPrefix.AutoSize = true;
            this.rbtnPrefix.Location = new System.Drawing.Point(3, 3);
            this.rbtnPrefix.Name = "rbtnPrefix";
            this.rbtnPrefix.Size = new System.Drawing.Size(63, 21);
            this.rbtnPrefix.TabIndex = 13;
            this.rbtnPrefix.TabStop = true;
            this.rbtnPrefix.Text = "prefix";
            this.rbtnPrefix.UseVisualStyleBackColor = true;
            // 
            // rbtnInfix
            // 
            this.rbtnInfix.AutoSize = true;
            this.rbtnInfix.Location = new System.Drawing.Point(72, 3);
            this.rbtnInfix.Name = "rbtnInfix";
            this.rbtnInfix.Size = new System.Drawing.Size(53, 21);
            this.rbtnInfix.TabIndex = 14;
            this.rbtnInfix.TabStop = true;
            this.rbtnInfix.Text = "infix";
            this.rbtnInfix.UseVisualStyleBackColor = true;
            // 
            // tbxFormula
            // 
            this.tbxFormula.Location = new System.Drawing.Point(30, 85);
            this.tbxFormula.Multiline = true;
            this.tbxFormula.Name = "tbxFormula";
            this.tbxFormula.Size = new System.Drawing.Size(218, 154);
            this.tbxFormula.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnInfix);
            this.panel1.Controls.Add(this.rbtnPrefix);
            this.panel1.Location = new System.Drawing.Point(30, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 29);
            this.panel1.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.BinaryTree);
            this.tabControl1.Controls.Add(this.Function);
            this.tabControl1.Location = new System.Drawing.Point(407, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 835);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnZoomIn);
            this.tabPage1.Controls.Add(this.btnZoomOut);
            this.tabPage1.Controls.Add(this.pbxPlot);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(953, 806);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Plot";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(777, 731);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 41);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear graph ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(802, 28);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(43, 36);
            this.btnZoomIn.TabIndex = 3;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(868, 28);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(43, 36);
            this.btnZoomOut.TabIndex = 2;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // pbxPlot
            // 
            this.pbxPlot.Location = new System.Drawing.Point(3, 3);
            this.pbxPlot.Name = "pbxPlot";
            this.pbxPlot.Size = new System.Drawing.Size(912, 775);
            this.pbxPlot.TabIndex = 0;
            this.pbxPlot.TabStop = false;
            // 
            // BinaryTree
            // 
            this.BinaryTree.Controls.Add(this.pictureBox1);
            this.BinaryTree.Location = new System.Drawing.Point(4, 25);
            this.BinaryTree.Name = "BinaryTree";
            this.BinaryTree.Padding = new System.Windows.Forms.Padding(3);
            this.BinaryTree.Size = new System.Drawing.Size(953, 806);
            this.BinaryTree.TabIndex = 1;
            this.BinaryTree.Text = "Binary tree";
            this.BinaryTree.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 794);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Function
            // 
            this.Function.Controls.Add(this.plot1);
            this.Function.Location = new System.Drawing.Point(4, 25);
            this.Function.Name = "Function";
            this.Function.Padding = new System.Windows.Forms.Padding(3);
            this.Function.Size = new System.Drawing.Size(953, 806);
            this.Function.TabIndex = 0;
            this.Function.Text = "Function";
            this.Function.UseVisualStyleBackColor = true;
            // 
            // plot1
            // 
            this.plot1.Location = new System.Drawing.Point(0, 0);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot1.Size = new System.Drawing.Size(935, 796);
            this.plot1.TabIndex = 17;
            this.plot1.Text = "plotView1";
            this.plot1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDrawDerNew);
            this.groupBox1.Controls.Add(this.btnParseDerivative);
            this.groupBox1.Controls.Add(this.btnDrawDerAn);
            this.groupBox1.Controls.Add(this.btnBinaryDerivative);
            this.groupBox1.Location = new System.Drawing.Point(30, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Derivative";
            // 
            // btnDrawDerNew
            // 
            this.btnDrawDerNew.Location = new System.Drawing.Point(22, 145);
            this.btnDrawDerNew.Name = "btnDrawDerNew";
            this.btnDrawDerNew.Size = new System.Drawing.Size(206, 35);
            this.btnDrawDerNew.TabIndex = 3;
            this.btnDrawDerNew.Text = "Draw function(Newton)";
            this.btnDrawDerNew.UseVisualStyleBackColor = true;
            this.btnDrawDerNew.Click += new System.EventHandler(this.btnDrawDerNew_Click);
            // 
            // btnParseDerivative
            // 
            this.btnParseDerivative.Location = new System.Drawing.Point(22, 22);
            this.btnParseDerivative.Name = "btnParseDerivative";
            this.btnParseDerivative.Size = new System.Drawing.Size(206, 35);
            this.btnParseDerivative.TabIndex = 2;
            this.btnParseDerivative.Text = "Parse";
            this.btnParseDerivative.UseVisualStyleBackColor = true;
            this.btnParseDerivative.Click += new System.EventHandler(this.btnParseDerivative_Click);
            // 
            // btnDrawDerAn
            // 
            this.btnDrawDerAn.Location = new System.Drawing.Point(22, 104);
            this.btnDrawDerAn.Name = "btnDrawDerAn";
            this.btnDrawDerAn.Size = new System.Drawing.Size(206, 35);
            this.btnDrawDerAn.TabIndex = 1;
            this.btnDrawDerAn.Text = "Draw Function(analytically)";
            this.btnDrawDerAn.UseVisualStyleBackColor = true;
            this.btnDrawDerAn.Click += new System.EventHandler(this.btnDrawDerAn_Click);
            // 
            // btnBinaryDerivative
            // 
            this.btnBinaryDerivative.Location = new System.Drawing.Point(22, 63);
            this.btnBinaryDerivative.Name = "btnBinaryDerivative";
            this.btnBinaryDerivative.Size = new System.Drawing.Size(206, 35);
            this.btnBinaryDerivative.TabIndex = 0;
            this.btnBinaryDerivative.Text = "Draw Binary Tree";
            this.btnBinaryDerivative.UseVisualStyleBackColor = true;
            this.btnBinaryDerivative.Click += new System.EventHandler(this.btnBinaryDerivative_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIntegral);
            this.groupBox2.Controls.Add(this.tbxHigherBoundary);
            this.groupBox2.Controls.Add(this.tbxLowerBoundary);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnIntegral);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 168);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Integral";
            // 
            // lblIntegral
            // 
            this.lblIntegral.AutoSize = true;
            this.lblIntegral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegral.Location = new System.Drawing.Point(26, 25);
            this.lblIntegral.Name = "lblIntegral";
            this.lblIntegral.Size = new System.Drawing.Size(166, 20);
            this.lblIntegral.TabIndex = 17;
            this.lblIntegral.Text = "Riemann\'s Integral is";
            // 
            // tbxHigherBoundary
            // 
            this.tbxHigherBoundary.Location = new System.Drawing.Point(203, 83);
            this.tbxHigherBoundary.Name = "tbxHigherBoundary";
            this.tbxHigherBoundary.Size = new System.Drawing.Size(34, 22);
            this.tbxHigherBoundary.TabIndex = 20;
            // 
            // tbxLowerBoundary
            // 
            this.tbxLowerBoundary.Location = new System.Drawing.Point(203, 52);
            this.tbxLowerBoundary.Name = "tbxLowerBoundary";
            this.tbxLowerBoundary.Size = new System.Drawing.Size(34, 22);
            this.tbxLowerBoundary.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Higher boundary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lower boundary";
            // 
            // btnIntegral
            // 
            this.btnIntegral.Location = new System.Drawing.Point(45, 119);
            this.btnIntegral.Name = "btnIntegral";
            this.btnIntegral.Size = new System.Drawing.Size(206, 35);
            this.btnIntegral.TabIndex = 3;
            this.btnIntegral.Text = "Integrate";
            this.btnIntegral.UseVisualStyleBackColor = true;
            this.btnIntegral.Click += new System.EventHandler(this.btnIntegral_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMcLaurinTree);
            this.groupBox3.Controls.Add(this.btnMcLaurinNew);
            this.groupBox3.Controls.Add(this.nudSeriesNumber);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnMcLaurinAna);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1387, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 208);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "McLaurin series ";
            // 
            // btnMcLaurinTree
            // 
            this.btnMcLaurinTree.Location = new System.Drawing.Point(42, 160);
            this.btnMcLaurinTree.Name = "btnMcLaurinTree";
            this.btnMcLaurinTree.Size = new System.Drawing.Size(206, 35);
            this.btnMcLaurinTree.TabIndex = 22;
            this.btnMcLaurinTree.Text = "Draw tree";
            this.btnMcLaurinTree.UseVisualStyleBackColor = true;
            this.btnMcLaurinTree.Click += new System.EventHandler(this.btnMcLaurinTree_Click);
            // 
            // btnMcLaurinNew
            // 
            this.btnMcLaurinNew.Location = new System.Drawing.Point(42, 116);
            this.btnMcLaurinNew.Name = "btnMcLaurinNew";
            this.btnMcLaurinNew.Size = new System.Drawing.Size(206, 35);
            this.btnMcLaurinNew.TabIndex = 21;
            this.btnMcLaurinNew.Text = "Calculate Newton";
            this.btnMcLaurinNew.UseVisualStyleBackColor = true;
            this.btnMcLaurinNew.Click += new System.EventHandler(this.btnMcLaurinNew_Click);
            // 
            // nudSeriesNumber
            // 
            this.nudSeriesNumber.Location = new System.Drawing.Point(209, 36);
            this.nudSeriesNumber.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudSeriesNumber.Name = "nudSeriesNumber";
            this.nudSeriesNumber.Size = new System.Drawing.Size(51, 22);
            this.nudSeriesNumber.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Degree of the series";
            // 
            // btnMcLaurinAna
            // 
            this.btnMcLaurinAna.Location = new System.Drawing.Point(42, 75);
            this.btnMcLaurinAna.Name = "btnMcLaurinAna";
            this.btnMcLaurinAna.Size = new System.Drawing.Size(206, 35);
            this.btnMcLaurinAna.TabIndex = 3;
            this.btnMcLaurinAna.Text = "Calculate Analytically";
            this.btnMcLaurinAna.UseVisualStyleBackColor = true;
            this.btnMcLaurinAna.Click += new System.EventHandler(this.btnMcLaurinAna_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBinaryPolonomial);
            this.groupBox4.Controls.Add(this.btnLagrangePolonomial);
            this.groupBox4.Controls.Add(this.npdXValue);
            this.groupBox4.Controls.Add(this.npdYValue);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnPolonomial);
            this.groupBox4.Controls.Add(this.btnRemovePoint);
            this.groupBox4.Controls.Add(this.lbxPoints);
            this.groupBox4.Controls.Add(this.btnAddPoint);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1371, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 307);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "n - polonomial";
            // 
            // btnBinaryPolonomial
            // 
            this.btnBinaryPolonomial.Location = new System.Drawing.Point(10, 262);
            this.btnBinaryPolonomial.Name = "btnBinaryPolonomial";
            this.btnBinaryPolonomial.Size = new System.Drawing.Size(206, 35);
            this.btnBinaryPolonomial.TabIndex = 29;
            this.btnBinaryPolonomial.Text = "Draw binary tree";
            this.btnBinaryPolonomial.UseVisualStyleBackColor = true;
            this.btnBinaryPolonomial.Click += new System.EventHandler(this.btnBinaryPolonomial_Click);
            // 
            // btnLagrangePolonomial
            // 
            this.btnLagrangePolonomial.Location = new System.Drawing.Point(9, 223);
            this.btnLagrangePolonomial.Name = "btnLagrangePolonomial";
            this.btnLagrangePolonomial.Size = new System.Drawing.Size(206, 35);
            this.btnLagrangePolonomial.TabIndex = 28;
            this.btnLagrangePolonomial.Text = "Draw polonomial Lagrange ";
            this.btnLagrangePolonomial.UseVisualStyleBackColor = true;
            this.btnLagrangePolonomial.Click += new System.EventHandler(this.btnLagrangePolonomial_Click);
            // 
            // npdXValue
            // 
            this.npdXValue.Location = new System.Drawing.Point(137, 34);
            this.npdXValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.npdXValue.Name = "npdXValue";
            this.npdXValue.Size = new System.Drawing.Size(65, 22);
            this.npdXValue.TabIndex = 27;
            // 
            // npdYValue
            // 
            this.npdYValue.Location = new System.Drawing.Point(137, 68);
            this.npdYValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.npdYValue.Name = "npdYValue";
            this.npdYValue.Size = new System.Drawing.Size(65, 22);
            this.npdYValue.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Y value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "X value";
            // 
            // btnPolonomial
            // 
            this.btnPolonomial.Location = new System.Drawing.Point(9, 185);
            this.btnPolonomial.Name = "btnPolonomial";
            this.btnPolonomial.Size = new System.Drawing.Size(206, 35);
            this.btnPolonomial.TabIndex = 22;
            this.btnPolonomial.Text = "Draw polonomial matrix ";
            this.btnPolonomial.UseVisualStyleBackColor = true;
            this.btnPolonomial.Click += new System.EventHandler(this.btnPolonomial_Click);
            // 
            // btnRemovePoint
            // 
            this.btnRemovePoint.Location = new System.Drawing.Point(9, 148);
            this.btnRemovePoint.Name = "btnRemovePoint";
            this.btnRemovePoint.Size = new System.Drawing.Size(206, 34);
            this.btnRemovePoint.TabIndex = 21;
            this.btnRemovePoint.Text = "Remove point";
            this.btnRemovePoint.UseVisualStyleBackColor = true;
            this.btnRemovePoint.Click += new System.EventHandler(this.btnRemovePoint_Click);
            // 
            // lbxPoints
            // 
            this.lbxPoints.FormattingEnabled = true;
            this.lbxPoints.ItemHeight = 16;
            this.lbxPoints.Location = new System.Drawing.Point(233, 12);
            this.lbxPoints.Name = "lbxPoints";
            this.lbxPoints.Size = new System.Drawing.Size(148, 244);
            this.lbxPoints.TabIndex = 24;
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(9, 110);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(206, 35);
            this.btnAddPoint.TabIndex = 3;
            this.btnAddPoint.Text = "Add point";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 981);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbxFormula);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.btn_Function);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBinaryTree);
            this.MinimumSize = new System.Drawing.Size(1778, 1028);
            this.Name = "Form1";
            this.Text = "PlottingApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlot)).EndInit();
            this.BinaryTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Function.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeriesNumber)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdXValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdYValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnBinaryTree;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Button btn_Function;
        private System.Windows.Forms.RadioButton rbtnPrefix;
        private System.Windows.Forms.RadioButton rbtnInfix;
        private System.Windows.Forms.TextBox tbxFormula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Function;
        private System.Windows.Forms.TabPage BinaryTree;
        private OxyPlot.WindowsForms.PlotView plot1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDrawDerNew;
        private System.Windows.Forms.Button btnParseDerivative;
        private System.Windows.Forms.Button btnDrawDerAn;
        private System.Windows.Forms.Button btnBinaryDerivative;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pbxPlot;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxHigherBoundary;
        private System.Windows.Forms.TextBox tbxLowerBoundary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIntegral;
        private System.Windows.Forms.Label lblIntegral;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudSeriesNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMcLaurinAna;
        private System.Windows.Forms.Button btnMcLaurinTree;
        private System.Windows.Forms.Button btnMcLaurinNew;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPolonomial;
        private System.Windows.Forms.Button btnRemovePoint;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.ListBox lbxPoints;
        private System.Windows.Forms.NumericUpDown npdXValue;
        private System.Windows.Forms.NumericUpDown npdYValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLagrangePolonomial;
        private System.Windows.Forms.Button btnBinaryPolonomial;
    }
}

