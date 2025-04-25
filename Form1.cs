using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NCalc;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NumericalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x0 = double.Parse(x0Txt.Text, CultureInfo.InvariantCulture);
                double x1 = double.Parse(x1Txt.Text, CultureInfo.InvariantCulture);

                string cleanStopping = stoppingErrors.Text.Replace("%", "").Trim();
                double stoppingError = double.Parse(cleanStopping, CultureInfo.InvariantCulture);

                string expression = functions.Text.Trim();

                if (!int.TryParse(decimalTxt.Text, out int decimalPlaces) || decimalPlaces < 0 || decimalPlaces > 15)
                {
                    MessageBox.Show("Enter decimal places (0-15).");
                    return;
                }

                string decimalFormat = $"F{decimalPlaces}";

                DataTable dt = new DataTable();
                dt.Columns.Add("Iteration", typeof(int));
                dt.Columns.Add("x0", typeof(string));
                dt.Columns.Add("x1", typeof(string));
                dt.Columns.Add("Root", typeof(string));
                dt.Columns.Add("Absolute Error", typeof(string));
                dt.Columns.Add("Relative Error (%)", typeof(string));

                int iteration = 0;
                double absoluteError = double.MaxValue;
                double relativeError = double.MaxValue;
                double root = 0;
                double previousRoot = x1;

                while (relativeError > stoppingError)
                {
                    double f_x0 = EvaluateExpression(expression, x0);
                    double f_x1 = EvaluateExpression(expression, x1);

                    if (Math.Abs(f_x1 - f_x0) < 1e-14)
                    {
                        MessageBox.Show("Division by zero (f(x1) ≈ f(x0)). Try different x0, x1.");
                        return;
                    }

                    root = x1 - f_x1 * (x1 - x0) / (f_x1 - f_x0);
                    absoluteError = Math.Abs(root - x1);

                    if (Math.Abs(root) > 1e-14)
                    {
                        relativeError = Math.Abs((root - previousRoot) / root) * 100;
                    }
                    else
                    {
                        relativeError = double.PositiveInfinity;
                    }

                    dt.Rows.Add(
                        iteration,
                        x0.ToString(decimalFormat),
                        x1.ToString(decimalFormat),
                        root.ToString(decimalFormat),
                        absoluteError.ToString("E4"),
                        relativeError.ToString("F6") + "%"
                    );

                    x0 = x1;
                    x1 = root;
                    previousRoot = root;
                    iteration++;

                    if (iteration > 1000)
                    {
                        MessageBox.Show("Max iterations (1000) reached.");
                        break;
                    }
                }

                iterationsGrid.DataSource = dt;
                roots.Text = (relativeError <= stoppingError) ?
                    root.ToString(decimalFormat) : "No root found within stopping criterion.";

                if (iterationsGrid.Rows.Count > 0)
                    iterationsGrid.CurrentCell = iterationsGrid.Rows[iterationsGrid.Rows.Count - 1].Cells[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private double EvaluateExpression(string expression, double x)
        {
            try
            {
                string fixedExpression = PrepareExpression(expression);
                Expression exp = new Expression(fixedExpression, EvaluateOptions.IgnoreCase);

                exp.Parameters["x"] = x;
                exp.Parameters["e"] = Math.E;
                exp.Parameters["pi"] = Math.PI;

                exp.EvaluateFunction += (name, args) =>
                {
                    if (args.Parameters.Length == 0) return;

                    double num = Convert.ToDouble(args.Parameters[0].Evaluate());
                    switch (name.ToLower())
                    {
                        case "sin": args.Result = Math.Sin(num); break;
                        case "cos": args.Result = Math.Cos(num); break;
                        case "tan": args.Result = Math.Tan(num); break;
                        case "log": args.Result = Math.Log(num); break;
                        case "log10": args.Result = Math.Log10(num); break;
                        case "exp": args.Result = Math.Exp(num); break;
                        case "sqrt": args.Result = Math.Sqrt(num); break;
                        case "abs": args.Result = Math.Abs(num); break;
                    }
                };

                object result = exp.Evaluate();
                return Convert.ToDouble(result, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                throw new Exception($"Invalid expression: {expression}. Error: {ex.Message}");
            }
        }

        private string PrepareExpression(string expr)
        {
            expr = Regex.Replace(expr, @"\s+", "");
            expr = Regex.Replace(expr, @"(\d+)([a-zA-Z])", "$1*$2");
            expr = Regex.Replace(expr, @"([a-zA-Z])(\d+)", "$1*$2");
            expr = Regex.Replace(expr, @"([a-zA-Z])\(", "$1*(");
            expr = Regex.Replace(expr, @"\)([a-zA-Z])", ")*$1");
            expr = Regex.Replace(expr, @"\)(\d+)", ")*$1");

            string[] funcs = { "sin", "cos", "tan", "log", "ln", "exp", "sqrt", "abs" };
            foreach (string func in funcs)
            {
                expr = Regex.Replace(expr, $@"{func}([^()a-zA-Z]*[a-zA-Z0-9.]+)", $"{func}($1)", RegexOptions.IgnoreCase);
            }

            expr = Regex.Replace(expr, @"ln\(", "log(", RegexOptions.IgnoreCase);
            expr = Regex.Replace(expr, @"([a-zA-Z0-9.]+)\^([a-zA-Z0-9.]+)", "Pow($1,$2)");

            return expr;
        }

        private void stoppingErrors_Leave_1(object sender, EventArgs e)
        {
            if (double.TryParse(stoppingErrors.Text.Replace("%", ""), out double value))
            {
                stoppingErrors.Text = value.ToString() + " %";
            }
        }
    }
}
