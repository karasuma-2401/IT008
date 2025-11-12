namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckInput (out double num1, out double num2)
        {
            num1 = 0;
            num2 = 0;
            if (!double.TryParse(txtNumber1.Text, out num1))
            {
                MessageBox.Show("Vui lòng nhập lại số thứ nhất!");
                txtNumber1.Clear();
                txtNumber1.Focus();
                return false;
            }

            if (!double.TryParse(txtNumber2.Text, out num2))
            {
                MessageBox.Show("Vui lòng nhập lại số thứ hai!");
                txtNumber2.Clear();
                txtNumber2.Focus();
                return false;
            }
            return true;
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (!CheckInput(out double num1, out double num2))
            {
                return;
            }
            sum = num1 + num2;
            txtAnswer.Text = sum.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double minus = 0;
            if (!CheckInput(out double num1, out double num2))
            {
                return;
            }
            minus = num1 - num2;
            txtAnswer.Text = minus.ToString();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            double times = 0;
            if (!CheckInput(out double num1, out double num2))
            {
                return;
            }
            times = num1 * num2;
            txtAnswer.Text = times.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double division = 0;
            if (!CheckInput(out double num1, out double num2))
            {
                return;
            }
            if (num2 == 0)
            {
                MessageBox.Show("Phép chia không hợp lệ. Vui lòng nhập lại!");
                txtNumber2.Clear();
                txtNumber2.Focus();
                return;
            }
            division = num1 / num2;
            txtAnswer.Text = division.ToString();
        }
    }
}
