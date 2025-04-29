using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NCalc;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using Flee;
using Flee.PublicTypes;

namespace NumericalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializePlot();
        }

        private void InitializePlot()
        {
            secantGraph.Model = new PlotModel { Title = "Secant Method Visualization" };
        }

        private void PlotFunctionAndPoints(string expression, double x0, double x1, double root, int maxIterations)
        {
            var plotModel = new PlotModel { Title = $"Function: {expression}" };

            var functionSeries = new FunctionSeries();
            double xMin = Math.Min(x0, x1) - 1;
            double xMax = Math.Max(x0, x1) + 1;

            for (double x = xMin; x <= xMax; x += (xMax - xMin) / 100)
            {
                try
                {
                    double y = EvaluateExpression(expression, x);
                    functionSeries.Points.Add(new DataPoint(x, y));
                }
                catch { }
            }
            plotModel.Series.Add(functionSeries);

            var pointsSeries = new ScatterSeries
            {
                Title = "Approximate Roots",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerFill = OxyColors.Red
            };

            var linesSeries = new LineSeries
            {
                Title = "Approximation Path",
                Color = OxyColors.Gray,
                LineStyle = LineStyle.Dash
            };

            double xi_minus1 = x0;
            double xi = x1;

            pointsSeries.Points.Add(new ScatterPoint(xi_minus1, EvaluateExpression(expression, xi_minus1)));
            pointsSeries.Points.Add(new ScatterPoint(xi, EvaluateExpression(expression, xi)));
            linesSeries.Points.Add(new DataPoint(xi_minus1, EvaluateExpression(expression, xi_minus1)));
            linesSeries.Points.Add(new DataPoint(xi, EvaluateExpression(expression, xi)));

            for (int i = 0; i < maxIterations; i++)
            {
                double f_xi_minus1 = EvaluateExpression(expression, xi_minus1);
                double f_xi = EvaluateExpression(expression, xi);
                double xi_plus1 = xi - f_xi * (xi_minus1 - xi) / (f_xi_minus1 - f_xi);

                double yi_plus1 = EvaluateExpression(expression, xi_plus1);

                pointsSeries.Points.Add(new ScatterPoint(xi_plus1, yi_plus1));
                linesSeries.Points.Add(new DataPoint(xi_plus1, yi_plus1));

                if (Math.Abs(xi_plus1 - xi) < 1e-6)
                    break;

                xi_minus1 = xi;
                xi = xi_plus1;
            }

            plotModel.Series.Add(linesSeries);
            plotModel.Series.Add(pointsSeries);

            var rootPoint = new ScatterSeries
            {
                Title = "Actual Root",
                MarkerType = MarkerType.Star,
                MarkerSize = 8,
                MarkerFill = OxyColors.Green
            };
            rootPoint.Points.Add(new ScatterPoint(root, EvaluateExpression(expression, root)));
            plotModel.Series.Add(rootPoint);

            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "x" });
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "f(x)" });

            plotModel.IsLegendVisible = true;

            secantGraph.Model = plotModel;
            secantGraph.InvalidatePlot(true);
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(functions.Text) || string.IsNullOrWhiteSpace(x0Txt.Text) || string.IsNullOrWhiteSpace(x1Txt.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
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
                dt.Columns.Add("xᵢ₋₁", typeof(string));
                dt.Columns.Add("xᵢ", typeof(string));
                dt.Columns.Add("xᵢ₊₁", typeof(string));
                dt.Columns.Add("f(xᵢ₋₁)", typeof(string));
                dt.Columns.Add("f(xᵢ)", typeof(string));
                dt.Columns.Add("Absolute Error", typeof(string));
                dt.Columns.Add("Relative Error (%)", typeof(string));

                int iteration = 0;
                double absoluteError = double.MaxValue;
                double relativeError = double.MaxValue;
                double root = 0;
                double previousRoot = x1;

                if (x0 == x1)
                {
                    x1 = x0 + 1e-6;
                }

                while (true)
                {
                    double f_x0 = EvaluateExpression(expression, x0);
                    double f_x1 = EvaluateExpression(expression, x1);

                    if (Math.Abs(f_x1 - f_x0) < 1e-14)
                    {
                        MessageBox.Show("Division by zero (f(x₁) ≈ f(x₀)). Try different initial guesses.");
                        return;
                    }

                    root = (x0 * f_x1 - x1 * f_x0) / (f_x1 - f_x0);
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
                        f_x0.ToString("E6"),
                        f_x1.ToString("E6"),
                        absoluteError.ToString("E6"),
                        relativeError.ToString("F6") + "%"
                    );

                    if (relativeError <= stoppingError)
                        break;

                    x0 = x1;
                    x1 = root;
                    previousRoot = root;
                    iteration++;

                    if (iteration > 100)
                    {
                        MessageBox.Show("Max iterations (100) reached.");
                        break;
                    }
                }

                iterationsGrid.DataSource = dt;
                roots.Text = root.ToString(decimalFormat);

                PlotFunctionAndPoints(expression, double.Parse(x0Txt.Text), double.Parse(x1Txt.Text), root, iteration);

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
                var context = new ExpressionContext();
                context.Variables["x"] = x;
                context.Variables["e"] = Math.E;
                context.Variables["pi"] = Math.PI;

                context.Imports.AddType(typeof(Math));

                context.Options.ParseCulture = CultureInfo.InvariantCulture;
                context.Options.RealLiteralDataType = RealLiteralDataType.Double;

                string preparedExpr = PrepareExpression(expression);
                IDynamicExpression e = context.CompileDynamic(preparedExpr);

                object result = e.Evaluate();
                return Convert.ToDouble(result, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                throw new Exception($"Expression Evaluation Error: {ex.Message}");
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

            string[] funcs = { "sin", "cos", "tan", "log", "ln", "exp", "sqrt", "abs", "pow" };
            foreach (string func in funcs)
            {
                expr = Regex.Replace(expr, $@"{func}([^()a-zA-Z]*[a-zA-Z0-9.+\-*/^]+)", $"{func}($1)", RegexOptions.IgnoreCase);
            }

            expr = Regex.Replace(expr, @"ln\(", "log(", RegexOptions.IgnoreCase);
            expr = Regex.Replace(expr, @"([a-zA-Z0-9().]+)\^([a-zA-Z0-9().]+)", "Pow($1,$2)");

            return expr;
        }
    }
}