namespace NumericalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            stoppingErrors = new TextBox();
            iterationsGrid = new DataGridView();
            calculate = new Button();
            decimalTxt = new TextBox();
            functions = new TextBox();
            roots = new TextBox();
            label2 = new Label();
            secantGraph = new OxyPlot.WindowsForms.PlotView();
            label8 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            panel7 = new Panel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel9 = new Panel();
            label13 = new Label();
            x0Txt = new TextBox();
            x1Txt = new TextBox();
            panel6 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            panel8 = new Panel();
            panel10 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iterationsGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 101);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(458, 41);
            label1.TabIndex = 0;
            label1.Text = "Secant Method Calculator";
            // 
            // stoppingErrors
            // 
            stoppingErrors.BackColor = Color.Ivory;
            stoppingErrors.BorderStyle = BorderStyle.None;
            stoppingErrors.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stoppingErrors.Location = new Point(17, 426);
            stoppingErrors.Margin = new Padding(3, 2, 3, 2);
            stoppingErrors.Name = "stoppingErrors";
            stoppingErrors.PlaceholderText = "Enter Es";
            stoppingErrors.Size = new Size(304, 23);
            stoppingErrors.TabIndex = 1;
            // 
            // iterationsGrid
            // 
            iterationsGrid.AllowUserToAddRows = false;
            iterationsGrid.AllowUserToDeleteRows = false;
            iterationsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iterationsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            iterationsGrid.BackgroundColor = Color.Ivory;
            iterationsGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Maroon;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = Color.Gold;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            iterationsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            iterationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iterationsGrid.GridColor = Color.Ivory;
            iterationsGrid.Location = new Point(341, 136);
            iterationsGrid.Margin = new Padding(3, 2, 3, 2);
            iterationsGrid.Name = "iterationsGrid";
            iterationsGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = Color.Gold;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            iterationsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            iterationsGrid.RowHeadersWidth = 51;
            iterationsGrid.RowTemplate.DefaultCellStyle.BackColor = Color.Ivory;
            iterationsGrid.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iterationsGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Maroon;
            iterationsGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Sienna;
            iterationsGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Gold;
            iterationsGrid.Size = new Size(590, 402);
            iterationsGrid.TabIndex = 1;
            // 
            // calculate
            // 
            calculate.BackColor = Color.Maroon;
            calculate.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculate.ForeColor = Color.Gold;
            calculate.Location = new Point(15, 896);
            calculate.Margin = new Padding(3, 2, 3, 2);
            calculate.Name = "calculate";
            calculate.Size = new Size(304, 65);
            calculate.TabIndex = 3;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = false;
            calculate.Click += calculate_Click;
            // 
            // decimalTxt
            // 
            decimalTxt.BackColor = Color.Ivory;
            decimalTxt.BorderStyle = BorderStyle.None;
            decimalTxt.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            decimalTxt.Location = new Point(17, 512);
            decimalTxt.Margin = new Padding(3, 2, 3, 2);
            decimalTxt.Name = "decimalTxt";
            decimalTxt.PlaceholderText = "Enter Decimal Point";
            decimalTxt.Size = new Size(304, 23);
            decimalTxt.TabIndex = 1;
            // 
            // functions
            // 
            functions.BackColor = Color.Ivory;
            functions.BorderStyle = BorderStyle.None;
            functions.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            functions.Location = new Point(14, 168);
            functions.Margin = new Padding(3, 2, 3, 2);
            functions.Name = "functions";
            functions.PlaceholderText = "Enter Function";
            functions.Size = new Size(304, 23);
            functions.TabIndex = 4;
            // 
            // roots
            // 
            roots.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roots.BackColor = Color.Ivory;
            roots.BorderStyle = BorderStyle.None;
            roots.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roots.Location = new Point(16, 801);
            roots.Margin = new Padding(3, 2, 3, 2);
            roots.Name = "roots";
            roots.ReadOnly = true;
            roots.Size = new Size(304, 23);
            roots.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(11, 133);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 5;
            label2.Text = "Function";
            // 
            // secantGraph
            // 
            secantGraph.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            secantGraph.BackColor = Color.Ivory;
            secantGraph.Location = new Point(341, 566);
            secantGraph.Name = "secantGraph";
            secantGraph.PanCursor = Cursors.Hand;
            secantGraph.Size = new Size(590, 402);
            secantGraph.TabIndex = 11;
            secantGraph.Text = "plotView1";
            secantGraph.ZoomHorizontalCursor = Cursors.SizeWE;
            secantGraph.ZoomRectangleCursor = Cursors.SizeNWSE;
            secantGraph.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gold;
            label8.Location = new Point(854, 114);
            label8.Name = "label8";
            label8.Size = new Size(77, 19);
            label8.TabIndex = 12;
            label8.Text = "Iterations";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gold;
            label9.Location = new Point(872, 543);
            label9.Name = "label9";
            label9.Size = new Size(59, 19);
            label9.TabIndex = 13;
            label9.Text = "Graph";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Location = new Point(16, 822);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 2);
            panel2.TabIndex = 14;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gold;
            panel7.Location = new Point(15, 189);
            panel7.Name = "panel7";
            panel7.Size = new Size(304, 2);
            panel7.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(12, 219);
            label10.Name = "label10";
            label10.Size = new Size(24, 25);
            label10.TabIndex = 18;
            label10.Text = "x";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(30, 228);
            label11.Name = "label11";
            label11.Size = new Size(14, 16);
            label11.TabIndex = 20;
            label11.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Maroon;
            label12.Location = new Point(31, 314);
            label12.Name = "label12";
            label12.Size = new Size(10, 16);
            label12.TabIndex = 24;
            label12.Text = "i";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Gold;
            panel9.Location = new Point(17, 361);
            panel9.Name = "panel9";
            panel9.Size = new Size(304, 2);
            panel9.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Maroon;
            label13.Location = new Point(13, 305);
            label13.Name = "label13";
            label13.Size = new Size(24, 25);
            label13.TabIndex = 22;
            label13.Text = "x";
            // 
            // x0Txt
            // 
            x0Txt.BackColor = Color.Ivory;
            x0Txt.BorderStyle = BorderStyle.None;
            x0Txt.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            x0Txt.Location = new Point(15, 254);
            x0Txt.Margin = new Padding(3, 2, 3, 2);
            x0Txt.Name = "x0Txt";
            x0Txt.PlaceholderText = "Enter xo";
            x0Txt.Size = new Size(304, 23);
            x0Txt.TabIndex = 1;
            // 
            // x1Txt
            // 
            x1Txt.BackColor = Color.Ivory;
            x1Txt.BorderStyle = BorderStyle.None;
            x1Txt.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            x1Txt.Location = new Point(16, 340);
            x1Txt.Margin = new Padding(3, 2, 3, 2);
            x1Txt.Name = "x1Txt";
            x1Txt.PlaceholderText = "Enter xi";
            x1Txt.Size = new Size(304, 23);
            x1Txt.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gold;
            panel6.Location = new Point(15, 275);
            panel6.Name = "panel6";
            panel6.Size = new Size(304, 2);
            panel6.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gold;
            panel5.Location = new Point(18, 447);
            panel5.Name = "panel5";
            panel5.Size = new Size(304, 2);
            panel5.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(14, 391);
            label3.Name = "label3";
            label3.Size = new Size(235, 25);
            label3.TabIndex = 26;
            label3.Text = "Es (Stopping Criterion)";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gold;
            panel4.Location = new Point(18, 533);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 2);
            panel4.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(14, 477);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 29;
            label4.Text = "Decimal Places";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(10, 754);
            label5.Name = "label5";
            label5.Size = new Size(72, 32);
            label5.TabIndex = 31;
            label5.Text = "Root";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Location = new Point(18, 784);
            panel3.Name = "panel3";
            panel3.Size = new Size(56, 2);
            panel3.TabIndex = 31;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel8.BackColor = Color.Maroon;
            panel8.Location = new Point(874, 563);
            panel8.Name = "panel8";
            panel8.Size = new Size(56, 2);
            panel8.TabIndex = 32;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel10.BackColor = Color.Maroon;
            panel10.Location = new Point(854, 133);
            panel10.Name = "panel10";
            panel10.Size = new Size(75, 2);
            panel10.TabIndex = 33;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(945, 982);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(label3);
            Controls.Add(label12);
            Controls.Add(panel9);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(secantGraph);
            Controls.Add(label2);
            Controls.Add(functions);
            Controls.Add(calculate);
            Controls.Add(iterationsGrid);
            Controls.Add(roots);
            Controls.Add(decimalTxt);
            Controls.Add(stoppingErrors);
            Controls.Add(x1Txt);
            Controls.Add(x0Txt);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secant Method Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iterationsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox stoppingErrors;
        private DataGridView iterationsGrid;
        private Button calculate;
        private TextBox decimalTxt;
        private TextBox functions;
        private Label resultLabel;
        private TextBox roots;
        private Label label2;
        private OxyPlot.WindowsForms.PlotView secantGraph;
        private Label label8;
        private Label label9;
        private Panel panel2;
        private Panel panel7;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel9;
        private Label label13;
        private TextBox x0Txt;
        private TextBox x1Txt;
        private Panel panel6;
        private Panel panel5;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private Panel panel8;
        private Panel panel10;
    }
}
