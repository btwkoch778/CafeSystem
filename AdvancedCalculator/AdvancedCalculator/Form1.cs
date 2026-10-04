using System;
using System.Globalization;
using System.Windows.Forms;

namespace AdvancedCalculator
{
    public partial class Form1 : Form
    {
        private double memory = 0;
        private string operation = "";
        private double firstNumber = 0;
        private bool newNumber = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (newNumber || display.Text == "0")
            {
                display.Text = button.Text;
                newNumber = false;
            }
            else
            {
                display.Text += button.Text;
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                display.Text = "0.";
                newNumber = false;
            }
            else if (!display.Text.Contains("."))
            {
                display.Text += ".";
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out firstNumber))
            {
                display.Text = "Error";
                return;
            }

            operation = button.Text;
            expressionLabel.Text = display.Text + " " + operation;
            newNumber = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (operation == "")
                return;

            double secondNumber;

            if (!double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out secondNumber))
            {
                display.Text = "Error";
                return;
            }

            double result = 0;

            if (operation == "+")
                result = firstNumber + secondNumber;
            else if (operation == "−")
                result = firstNumber - secondNumber;
            else if (operation == "×")
                result = firstNumber * secondNumber;
            else if (operation == "÷")
            {
                if (secondNumber == 0)
                {
                    display.Text = "Error";
                    operation = "";
                    return;
                }

                result = firstNumber / secondNumber;
            }

            expressionLabel.Text =
                firstNumber + " " +
                operation + " " +
                secondNumber + " =";

            display.Text =
                result.ToString(CultureInfo.InvariantCulture);

            operation = "";
            newNumber = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            expressionLabel.Text = "";
            firstNumber = 0;
            operation = "";
            newNumber = true;
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
                return;

            value = -value;

            display.Text =
                value.ToString(CultureInfo.InvariantCulture);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
                return;

            value /= 100;

            display.Text =
                value.ToString(CultureInfo.InvariantCulture);

            newNumber = true;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (display.Text == "Error" || display.Text.Length <= 1)
            {
                display.Text = "0";
                newNumber = true;
                return;
            }

            display.Text =
                display.Text.Substring(
                    0,
                    display.Text.Length - 1);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
                return;

            if (value < 0)
            {
                display.Text = "Error";
                return;
            }

            display.Text =
                Math.Sqrt(value).ToString(
                    CultureInfo.InvariantCulture);

            expressionLabel.Text = "√(" + value + ")";
            newNumber = true;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
                return;

            display.Text =
                (value * value).ToString(
                    CultureInfo.InvariantCulture);

            expressionLabel.Text = value + "²";
            newNumber = true;
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
                return;

            if (value == 0)
            {
                display.Text = "Error";
                return;
            }

            display.Text =
                (1 / value).ToString(
                    CultureInfo.InvariantCulture);

            expressionLabel.Text = "1/" + value;
            newNumber = true;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
                return;

            double result =
                Math.Sin(value * Math.PI / 180);

            display.Text =
                result.ToString(
                    CultureInfo.InvariantCulture);

            expressionLabel.Text = "sin(" + value + "°)";
            newNumber = true;
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
                return;

            double result =
                Math.Cos(value * Math.PI / 180);

            display.Text =
                result.ToString(
                    CultureInfo.InvariantCulture);

            expressionLabel.Text = "cos(" + value + "°)";
            newNumber = true;
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
                return;

            double radians = value * Math.PI / 180;
            double cos = Math.Cos(radians);

            if (Math.Abs(cos) < 1e-12)
            {
                display.Text = "Error";
                return;
            }

            double result = Math.Tan(radians);

            display.Text =
                result.ToString(
                    CultureInfo.InvariantCulture);

            expressionLabel.Text = "tan(" + value + "°)";
            newNumber = true;
        }

        private void btnCtg_Click(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
                return;

            double radians = value * Math.PI / 180;
            double sin = Math.Sin(radians);

            if (Math.Abs(sin) < 1e-12)
            {
                display.Text = "Error";
                return;
            }

            double result = 1 / Math.Tan(radians);

            display.Text =
                result.ToString(
                    CultureInfo.InvariantCulture);

            expressionLabel.Text = "ctg(" + value + "°)";
            newNumber = true;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
                return;

            if (value <= 0)
            {
                display.Text = "Error";
                return;
            }

            display.Text =
                Math.Log10(value).ToString(
                    CultureInfo.InvariantCulture);

            expressionLabel.Text = "log(" + value + ")";
            newNumber = true;
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
                return;

            if (value <= 0)
            {
                display.Text = "Error";
                return;
            }

            display.Text =
                Math.Log(value).ToString(
                    CultureInfo.InvariantCulture);

            expressionLabel.Text = "ln(" + value + ")";
            newNumber = true;
        }

        private void Constant_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "π")
            {
                display.Text =
                    Math.PI.ToString(
                        CultureInfo.InvariantCulture);
            }
            else if (button.Text == "e")
            {
                display.Text =
                    Math.E.ToString(
                        CultureInfo.InvariantCulture);
            }

            newNumber = true;
        }

        private void Parenthesis_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (newNumber || display.Text == "0")
            {
                display.Text = button.Text;
                newNumber = false;
            }
            else
            {
                display.Text += button.Text;
            }
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            display.Text =
                memory.ToString(
                    CultureInfo.InvariantCulture);

            newNumber = true;
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
            {
                memory = value;
            }
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(
                display.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
            {
                memory += value;
            }
        }
    }
}