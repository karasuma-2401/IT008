using System;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Calculator : Form
    {
        double memoryStorage = 0;
        double currentResult = 0;
        double repeatingOperand = 0;
        string pendingOperator = "";
        bool isNewEntry = true;
        bool isOperatorPending = false;

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutText =
                    "Tên phần mềm: SUPERCALCULATOR\n" +
                    "Phiên bản: 24.01.00\n\n" +
                    "Tác giả: 9979\n" +
                    "Bản quyền: © 2025. All rights reserved.\n\n" +
                    "Mô tả: Ứng dụng máy tính cầm tay đơn giản " +
                    "được phát triển bằng C# WinForms.";
            string title = "Về phần mềm";
            MessageBox.Show(
                  aboutText,
                  title,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
            );
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không? ",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes) Application.Exit();
        }
        public Calculator()
        {
            InitializeComponent();
            InitializeTags();
            SetUpEvents();
            txtResult.Text = "0";
        }
        private void InitializeTags()
        {
            btnPlus.Tag = "+";
            btnMinus.Tag = "-";
            btnTimes.Tag = "*";
            btnDivision.Tag = "/";
        }

        private void SetUpEvents()
        {
            Button[] numberButtons = {
                btn0, btn1, btn2, btn3, btn4,
                btn5, btn6, btn7, btn8, btn9, btnPoint
            };
            foreach (Button btn in numberButtons)
            {
                btn.Click += OnDigitClick;
            }

            Button[] operatorButtons = { btnPlus, btnMinus, btnTimes, btnDivision };
            foreach (Button btn in operatorButtons)
            {
                btn.Click += OnOperatorClick;
            }

            btnEqual.Click += OnEqualsClick;
            btnC.Click += (s, e) => ResetCalculator();
            btnCE.Click += (s, e) => ClearCurrentEntry();
            btnBackSpace.Click += (s, e) => OnBackspace();
            btnInversion.Click += (s, e) => OnToggleSign();
            btnSquare.Click += (s, e) => OnSqrt();
            btnPercentage.Click += (s, e) => OnPercent();
            btnReciprocal.Click += (s, e) => OnReciprocal();

            btnMC.Click += OnMemoryClear;
            btnMR.Click += OnMemoryRecall;
            btnMS.Click += OnMemoryStore;
            btnMPlus.Click += OnMemoryAdd;
        }
        private void OnDigitClick(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            string input = bt.Text;

            if (input == ".")
            {
                if (isNewEntry)
                {
                    txtResult.Text = "0.";
                    isNewEntry = false;
                }
                else if (!txtResult.Text.Contains("."))
                {
                    txtResult.Text += ".";
                }
                return;
            }

            if (isNewEntry || txtResult.Text == "0")
            {
                txtResult.Text = input;
                isNewEntry = false;
            }
            else
            {
                txtResult.Text += input;
            }
        }

        private void OnOperatorClick(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            string op = bt.Tag.ToString();

            double current = GetDisplayValue();

            if (isOperatorPending)
            {
                Calculate(pendingOperator, currentResult, current);
            }
            else
            {
                currentResult = current;
            }

            pendingOperator = op;
            isNewEntry = true;
            isOperatorPending = true;
        }
        private void OnEqualsClick(object sender, EventArgs e)
        {
            double current = GetDisplayValue();

            if (isOperatorPending)
            {
                repeatingOperand = current;
                Calculate(pendingOperator, currentResult, current);
                isOperatorPending = false;
            }
            else if (pendingOperator != "")
            {
                Calculate(pendingOperator, currentResult, repeatingOperand);
            }
        }
        private void Calculate(string op, double left, double right)
        {
            double result = left;
            try
            {
                switch (op)
                {
                    case "+": result = left + right; break;
                    case "-": result = left - right; break;
                    case "*": result = left * right; break;
                    case "/":
                        if (right == 0)
                        {
                            throw new DivideByZeroException("Không thể thực hiện phép chia cho 0!");
                        }
                        result = left / right;
                        break;
                }

                txtResult.Text = result.ToString();
                currentResult = result;
                isNewEntry = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResetCalculator();
            }
        }
        private double GetDisplayValue()
        {
            double.TryParse(txtResult.Text, out double val);
            return val;
        }

        private void ResetCalculator()
        {
            txtResult.Text = "0";
            currentResult = 0;
            repeatingOperand = 0;
            pendingOperator = "";
            isOperatorPending = false;
            isNewEntry = true;
        }
        private void ClearCurrentEntry()
        {
            txtResult.Text = "0";
            isNewEntry = true;
        }
        private void OnBackspace()
        {
            if (isNewEntry) return;

            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
                if (txtResult.Text == "" || txtResult.Text == "-")
                {
                    txtResult.Text = "0";
                }
            }
        }
        private void OnToggleSign()
        {
            double val = GetDisplayValue();
            val = -val;
            txtResult.Text = val.ToString();
        }
        private void OnSqrt()
        {
            double value = GetDisplayValue();
            if (value < 0)
            {
                MessageBox.Show("Không thể lấy căn bậc hai của môt số âm!");
                ResetCalculator();
                return;
            }
            txtResult.Text = Math.Sqrt(value).ToString();
            isNewEntry = true;
        }
        private void OnPercent()
        {
            double current = GetDisplayValue();
            double result = current / 100.0;

            if (isOperatorPending)
            {
                result = (current / 100.0) * currentResult;
            }
            txtResult.Text = result.ToString();
            if (!isOperatorPending)
            {
                isNewEntry = true;
            }
        }
        private void OnReciprocal()
        {
            double value = GetDisplayValue();
            if (value == 0)
            {
                MessageBox.Show("Không thể thực hiện phép chia cho 0!");
                ResetCalculator();
                return;
            }
            txtResult.Text = (1.0 / value).ToString();
            isNewEntry = true;
        }
        private void OnMemoryClear(object sender, EventArgs e)
        {
            memoryStorage = 0;
        }
        private void OnMemoryRecall(object sender, EventArgs e)
        {
            txtResult.Text = memoryStorage.ToString();
            isNewEntry = true;
        }
        private void OnMemoryStore(object sender, EventArgs e)
        {
            memoryStorage = GetDisplayValue();
            isNewEntry = true;
        }
        private void OnMemoryAdd(object sender, EventArgs e)
        {
            memoryStorage += GetDisplayValue();
            isNewEntry = true;
        }
    }
}