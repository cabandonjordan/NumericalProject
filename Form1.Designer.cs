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
            x0Txt = new TextBox();
            x1Txt = new TextBox();
            stoppingErrors = new TextBox();
            iterationsGrid = new DataGridView();
            calculate = new Button();
            decimalTxt = new TextBox();
            functions = new TextBox();
            roots = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
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
            panel1.Size = new Size(1041, 64);
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
            // x0Txt
            // 
            x0Txt.BackColor = Color.MistyRose;
            x0Txt.BorderStyle = BorderStyle.None;
            x0Txt.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            x0Txt.Location = new Point(14, 141);
            x0Txt.Margin = new Padding(3, 2, 3, 2);
            x0Txt.Name = "x0Txt";
            x0Txt.PlaceholderText = "Enter xo";
            x0Txt.Size = new Size(304, 23);
            x0Txt.TabIndex = 1;
            // 
            // x1Txt
            // 
            x1Txt.BackColor = Color.MistyRose;
            x1Txt.BorderStyle = BorderStyle.None;
            x1Txt.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            x1Txt.Location = new Point(14, 192);
            x1Txt.Margin = new Padding(3, 2, 3, 2);
            x1Txt.Name = "x1Txt";
            x1Txt.PlaceholderText = "Enter xi";
            x1Txt.Size = new Size(304, 23);
            x1Txt.TabIndex = 1;
            // 
            // stoppingErrors
            // 
            stoppingErrors.BackColor = Color.MistyRose;
            stoppingErrors.BorderStyle = BorderStyle.None;
            stoppingErrors.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stoppingErrors.Location = new Point(14, 246);
            stoppingErrors.Margin = new Padding(3, 2, 3, 2);
            stoppingErrors.Name = "stoppingErrors";
            stoppingErrors.PlaceholderText = "Enter Es";
            stoppingErrors.Size = new Size(304, 23);
            stoppingErrors.TabIndex = 1;
            stoppingErrors.Leave += stoppingErrors_Leave_1;
            // 
            // iterationsGrid
            // 
            iterationsGrid.AllowUserToAddRows = false;
            iterationsGrid.AllowUserToDeleteRows = false;
            iterationsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            iterationsGrid.BackgroundColor = Color.MistyRose;
            iterationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iterationsGrid.Location = new Point(341, 69);
            iterationsGrid.Margin = new Padding(3, 2, 3, 2);
            iterationsGrid.Name = "iterationsGrid";
            iterationsGrid.ReadOnly = true;
            iterationsGrid.RowHeadersWidth = 51;
            iterationsGrid.Size = new Size(664, 369);
            iterationsGrid.TabIndex = 1;
            // 
            // calculate
            // 
            calculate.BackColor = Color.Maroon;
            calculate.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculate.ForeColor = Color.Gold;
            calculate.Location = new Point(12, 517);
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
            decimalTxt.Location = new Point(14, 305);
            decimalTxt.Margin = new Padding(3, 2, 3, 2);
            decimalTxt.Name = "decimalTxt";
            decimalTxt.PlaceholderText = "Enter Decimal Point";
            decimalTxt.Size = new Size(304, 23);
            decimalTxt.TabIndex = 1;
            // 
            // functions
            // 
            functions.BackColor = Color.MistyRose;
            functions.BorderStyle = BorderStyle.None;
            functions.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            functions.Location = new Point(14, 90);
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
            roots.Location = new Point(11, 434);
            roots.Margin = new Padding(3, 2, 3, 2);
            roots.Name = "roots";
            roots.PlaceholderText = "Root";
            roots.Size = new Size(304, 23);
            roots.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 5;
            label2.Text = "Function";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 120);
            label3.Name = "label3";
            label3.Size = new Size(30, 19);
            label3.TabIndex = 6;
            label3.Text = "Xo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 171);
            label4.Name = "label4";
            label4.Size = new Size(24, 19);
            label4.TabIndex = 7;
            label4.Text = "Xi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 225);
            label5.Name = "label5";
            label5.Size = new Size(176, 19);
            label5.TabIndex = 8;
            label5.Text = "Es (Stopping Criterion)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 284);
            label6.Name = "label6";
            label6.Size = new Size(129, 19);
            label6.TabIndex = 9;
            label6.Text = "Decimal Places";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 413);
            label7.Name = "label7";
            label7.Size = new Size(42, 19);
            label7.TabIndex = 10;
            label7.Text = "Root";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1041, 593);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private TextBox x0Txt;
        private TextBox x1Txt;
        private TextBox stoppingErrors;
        private DataGridView iterationsGrid;
        private Button calculate;
        private TextBox decimalTxt;
        private TextBox functions;
        private Label resultLabel;
        private TextBox roots;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
