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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            x0Txt = new TextBox();
            panel3 = new Panel();
            x1Txt = new TextBox();
            panel4 = new Panel();
            stoppingErrors = new TextBox();
            panel5 = new Panel();
            iterationsGrid = new DataGridView();
            calculate = new Button();
            decimalTxt = new TextBox();
            panel6 = new Panel();
            functions = new TextBox();
            roots = new TextBox();
            panel7 = new Panel();
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
            panel1.Size = new Size(1022, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(423, 38);
            label1.TabIndex = 0;
            label1.Text = "Secant Method Calculator";
            // 
            // panel2
            // 
            panel2.ForeColor = Color.LightGray;
            panel2.Location = new Point(11, 111);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 2);
            panel2.TabIndex = 2;
            // 
            // x0Txt
            // 
            x0Txt.BackColor = Color.MistyRose;
            x0Txt.BorderStyle = BorderStyle.None;
            x0Txt.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            x0Txt.Location = new Point(10, 117);
            x0Txt.Margin = new Padding(3, 2, 3, 2);
            x0Txt.Name = "x0Txt";
            x0Txt.PlaceholderText = "Enter xo";
            x0Txt.Size = new Size(304, 23);
            x0Txt.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.ForeColor = Color.LightGray;
            panel3.Location = new Point(11, 140);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(304, 2);
            panel3.TabIndex = 2;
            // 
            // x1Txt
            // 
            x1Txt.BackColor = Color.MistyRose;
            x1Txt.BorderStyle = BorderStyle.None;
            x1Txt.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            x1Txt.Location = new Point(11, 146);
            x1Txt.Margin = new Padding(3, 2, 3, 2);
            x1Txt.Name = "x1Txt";
            x1Txt.PlaceholderText = "Enter xi";
            x1Txt.Size = new Size(304, 23);
            x1Txt.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.ForeColor = Color.LightGray;
            panel4.Location = new Point(12, 168);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 2);
            panel4.TabIndex = 2;
            // 
            // stoppingErrors
            // 
            stoppingErrors.BackColor = Color.MistyRose;
            stoppingErrors.BorderStyle = BorderStyle.None;
            stoppingErrors.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stoppingErrors.Location = new Point(12, 174);
            stoppingErrors.Margin = new Padding(3, 2, 3, 2);
            stoppingErrors.Name = "stoppingErrors";
            stoppingErrors.PlaceholderText = "Enter Es";
            stoppingErrors.Size = new Size(304, 23);
            stoppingErrors.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.ForeColor = Color.LightGray;
            panel5.Location = new Point(13, 196);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(304, 2);
            panel5.TabIndex = 2;
            // 
            // iterationsGrid
            // 
            iterationsGrid.AllowUserToAddRows = false;
            iterationsGrid.AllowUserToDeleteRows = false;
            iterationsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            iterationsGrid.BackgroundColor = Color.MistyRose;
            iterationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iterationsGrid.Location = new Point(347, 88);
            iterationsGrid.Margin = new Padding(3, 2, 3, 2);
            iterationsGrid.Name = "iterationsGrid";
            iterationsGrid.ReadOnly = true;
            iterationsGrid.RowHeadersWidth = 51;
            iterationsGrid.Size = new Size(664, 220);
            iterationsGrid.TabIndex = 1;
            // 
            // calculate
            // 
            calculate.BackColor = Color.Maroon;
            calculate.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculate.ForeColor = Color.Gold;
            calculate.Location = new Point(10, 392);
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
            decimalTxt.BackColor = Color.MistyRose;
            decimalTxt.BorderStyle = BorderStyle.None;
            decimalTxt.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            decimalTxt.Location = new Point(13, 202);
            decimalTxt.Margin = new Padding(3, 2, 3, 2);
            decimalTxt.Name = "decimalTxt";
            decimalTxt.PlaceholderText = "Enter Decimal Point";
            decimalTxt.Size = new Size(304, 23);
            decimalTxt.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.ForeColor = Color.LightGray;
            panel6.Location = new Point(14, 225);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(304, 2);
            panel6.TabIndex = 2;
            // 
            // functions
            // 
            functions.BackColor = Color.MistyRose;
            functions.BorderStyle = BorderStyle.None;
            functions.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            functions.Location = new Point(11, 89);
            functions.Margin = new Padding(3, 2, 3, 2);
            functions.Name = "functions";
            functions.PlaceholderText = "Enter Function";
            functions.Size = new Size(304, 23);
            functions.TabIndex = 4;
            // 
            // roots
            // 
            roots.BackColor = Color.MistyRose;
            roots.BorderStyle = BorderStyle.None;
            roots.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roots.Location = new Point(10, 320);
            roots.Margin = new Padding(3, 2, 3, 2);
            roots.Name = "roots";
            roots.PlaceholderText = "Root";
            roots.Size = new Size(304, 23);
            roots.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.ForeColor = Color.LightGray;
            panel7.Location = new Point(11, 343);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(304, 2);
            panel7.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1022, 466);
            Controls.Add(functions);
            Controls.Add(calculate);
            Controls.Add(iterationsGrid);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(roots);
            Controls.Add(decimalTxt);
            Controls.Add(stoppingErrors);
            Controls.Add(x1Txt);
            Controls.Add(x0Txt);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iterationsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox x0Txt;
        private Panel panel3;
        private TextBox x1Txt;
        private Panel panel4;
        private TextBox stoppingErrors;
        private Panel panel5;
        private DataGridView iterationsGrid;
        private Button calculate;
        private TextBox decimalTxt;
        private Panel panel6;
        private TextBox functions;
        private Label resultLabel;
        private TextBox roots;
        private Panel panel7;
    }
}
