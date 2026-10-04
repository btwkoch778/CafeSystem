namespace AdvancedCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label expressionLabel;
        private System.Windows.Forms.TextBox display;

        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnBackspace;

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSqrt;

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSquare;

        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnInverse;

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEquals;

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPi;

        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnCtg;
        private System.Windows.Forms.Button btnLn;

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnE;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.expressionLabel = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.TextBox();

            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();

            this.btnClear = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();

            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();

            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();

            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();

            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();

            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCtg = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();

            this.btnLog = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.expressionLabel.AutoSize = false;
            this.expressionLabel.Location = new System.Drawing.Point(20, 15);
            this.expressionLabel.Name = "expressionLabel";
            this.expressionLabel.Size = new System.Drawing.Size(720, 25);
            this.expressionLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;
            this.expressionLabel.ForeColor =
                System.Drawing.Color.Gray;
            this.expressionLabel.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.display.Location = new System.Drawing.Point(20, 42);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(720, 65);
            this.display.BackColor =
                System.Drawing.Color.FromArgb(35, 35, 38);
            this.display.ForeColor =
                System.Drawing.Color.White;
            this.display.Font =
                new System.Drawing.Font("Segoe UI", 28F);
            this.display.ReadOnly = true;
            this.display.Text = "0";
            this.display.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Right;

            int x1 = 20;
            int x2 = 165;
            int x3 = 310;
            int x4 = 455;
            int x5 = 600;

            int w = 125;
            int h = 55;

            SetButton(this.btnMC, x1, 120, w, h, "MC");
            SetButton(this.btnMR, x2, 120, w, h, "MR");
            SetButton(this.btnMS, x3, 120, w, h, "MS");
            SetButton(this.btnMPlus, x4, 120, w, h, "M+");
            SetButton(this.btnBackspace, x5, 120, w, h, "⌫");

            SetButton(this.btnClear, x1, 185, w, h, "C");
            SetButton(this.btnPlusMinus, x2, 185, w, h, "±");
            SetButton(this.btnPercent, x3, 185, w, h, "%");
            SetButton(this.btnDivide, x4, 185, w, h, "÷");
            SetButton(this.btnSqrt, x5, 185, w, h, "√");

            SetButton(this.btn7, x1, 250, w, h, "7");
            SetButton(this.btn8, x2, 250, w, h, "8");
            SetButton(this.btn9, x3, 250, w, h, "9");
            SetButton(this.btnMultiply, x4, 250, w, h, "×");
            SetButton(this.btnSquare, x5, 250, w, h, "x²");

            SetButton(this.btn4, x1, 315, w, h, "4");
            SetButton(this.btn5, x2, 315, w, h, "5");
            SetButton(this.btn6, x3, 315, w, h, "6");
            SetButton(this.btnMinus, x4, 315, w, h, "−");
            SetButton(this.btnInverse, x5, 315, w, h, "1/x");

            SetButton(this.btn1, x1, 380, w, h, "1");
            SetButton(this.btn2, x2, 380, w, h, "2");
            SetButton(this.btn3, x3, 380, w, h, "3");
            SetButton(this.btnPlus, x4, 380, w, h, "+");
            SetButton(this.btnEquals, x5, 380, w, h, "=");

            SetButton(this.btn0, x1, 445, w, h, "0");
            SetButton(this.btnDot, x2, 445, w, h, ".");
            SetButton(this.btnOpen, x3, 445, w, h, "(");
            SetButton(this.btnClose, x4, 445, w, h, ")");
            SetButton(this.btnPi, x5, 445, w, h, "π");

            SetButton(this.btnSin, x1, 510, w, h, "sin");
            SetButton(this.btnCos, x2, 510, w, h, "cos");
            SetButton(this.btnTan, x3, 510, w, h, "tan");
            SetButton(this.btnCtg, x4, 510, w, h, "ctg");
            SetButton(this.btnLn, x5, 510, w, h, "ln");

            SetButton(this.btnLog, 20, 575, 350, h, "log");
            SetButton(this.btnE, 390, 575, 350, h, "e");

            this.btnClear.BackColor =
                System.Drawing.Color.FromArgb(90, 45, 45);

            this.btnEquals.BackColor =
                System.Drawing.Color.FromArgb(55, 85, 115);

            this.btnMC.ForeColor =
                System.Drawing.Color.LightGray;
            this.btnMR.ForeColor =
                System.Drawing.Color.LightGray;
            this.btnMS.ForeColor =
                System.Drawing.Color.LightGray;
            this.btnMPlus.ForeColor =
                System.Drawing.Color.LightGray;

            this.btnMC.Click +=
                new System.EventHandler(this.btnMC_Click);

            this.btnMR.Click +=
                new System.EventHandler(this.btnMR_Click);

            this.btnMS.Click +=
                new System.EventHandler(this.btnMS_Click);

            this.btnMPlus.Click +=
                new System.EventHandler(this.btnMPlus_Click);

            this.btnBackspace.Click +=
                new System.EventHandler(this.btnBackspace_Click);

            this.btnClear.Click +=
                new System.EventHandler(this.btnClear_Click);

            this.btnPlusMinus.Click +=
                new System.EventHandler(this.btnPlusMinus_Click);

            this.btnPercent.Click +=
                new System.EventHandler(this.btnPercent_Click);

            this.btnDivide.Click +=
                new System.EventHandler(this.Operator_Click);

            this.btnMultiply.Click +=
                new System.EventHandler(this.Operator_Click);

            this.btnMinus.Click +=
                new System.EventHandler(this.Operator_Click);

            this.btnPlus.Click +=
                new System.EventHandler(this.Operator_Click);

            this.btn7.Click +=
                new System.EventHandler(this.Number_Click);

            this.btn8.Click +=
                new System.EventHandler(this.Number_Click);

            this.btn9.Click +=
                new System.EventHandler(this.Number_Click);

            this.btn4.Click +=
                new System.EventHandler(this.Number_Click);

            this.btn5.Click +=
                new System.EventHandler(this.Number_Click);

            this.btn6.Click +=
                new System.EventHandler(this.Number_Click);

            this.btn1.Click +=
                new System.EventHandler(this.Number_Click);

            this.btn2.Click +=
                new System.EventHandler(this.Number_Click);

            this.btn3.Click +=
                new System.EventHandler(this.Number_Click);

            this.btn0.Click +=
                new System.EventHandler(this.Number_Click);

            this.btnDot.Click +=
                new System.EventHandler(this.Dot_Click);

            this.btnEquals.Click +=
                new System.EventHandler(this.btnEquals_Click);

            this.btnSqrt.Click +=
                new System.EventHandler(this.btnSqrt_Click);

            this.btnSquare.Click +=
                new System.EventHandler(this.btnSquare_Click);

            this.btnInverse.Click +=
                new System.EventHandler(this.btnInverse_Click);

            this.btnSin.Click +=
                new System.EventHandler(this.btnSin_Click);

            this.btnCos.Click +=
                new System.EventHandler(this.btnCos_Click);

            this.btnTan.Click +=
                new System.EventHandler(this.btnTan_Click);

            this.btnCtg.Click +=
                new System.EventHandler(this.btnCtg_Click);

            this.btnLog.Click +=
                new System.EventHandler(this.btnLog_Click);

            this.btnLn.Click +=
                new System.EventHandler(this.btnLn_Click);

            this.btnPi.Click +=
                new System.EventHandler(this.Constant_Click);

            this.btnE.Click +=
                new System.EventHandler(this.Constant_Click);

            this.btnOpen.Click +=
                new System.EventHandler(this.Parenthesis_Click);

            this.btnClose.Click +=
                new System.EventHandler(this.Parenthesis_Click);

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(20, 20, 22);

            this.ClientSize =
                new System.Drawing.Size(760, 655);

            this.Controls.Add(this.expressionLabel);
            this.Controls.Add(this.display);

            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnBackspace);

            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSqrt);

            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSquare);

            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnInverse);

            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEquals);

            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPi);

            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCtg);
            this.Controls.Add(this.btnLn);

            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnE);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name = "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Advanced Calculator";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetButton(
            System.Windows.Forms.Button button,
            int x,
            int y,
            int width,
            int height,
            string text)
        {
            button.Location =
                new System.Drawing.Point(x, y);

            button.Size =
                new System.Drawing.Size(width, height);

            button.Text = text;

            button.Font =
                new System.Drawing.Font("Segoe UI", 14F);

            button.BackColor =
                System.Drawing.Color.FromArgb(48, 48, 52);

            button.ForeColor =
                System.Drawing.Color.White;

            button.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            button.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(70, 70, 75);

            button.FlatAppearance.BorderSize = 1;

            button.UseVisualStyleBackColor = false;
        }
    }
}