using System.Windows.Forms;

namespace Bai01
{
    public partial class FormCha : Form
    {
        public FormCha()
        {
            InitializeComponent();
            LogEvent("1. Constructor: Hàm dựng được gọi");
        }
        private void LogEvent(string EventName)
        {
            string thoiGian = DateTime.Now.ToString("HH:mm:ss.fff");
            lbProcessChildForm.Items.Add($"{thoiGian} - {EventName}");
            lbProcessChildForm.TopIndex = lbProcessChildForm.Items.Count - 1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LogEvent("2. Load: Form được tải lên");
        }
        // * thể hiện event lặp lại
        private void Form1_Activated(object sender, EventArgs e)
        {
            LogEvent("*. Activated: Form được kích hoạt");
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            LogEvent("3. Shown: Form đã được hiển thị");
        }
        private void Form1_Deactivated(object sender, EventArgs e)
        {
            LogEvent("*. Deactivated: Form bị bất hoạt");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEvent("4. FormClosing: Form đang chuẩn bị đóng");
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?",
                                        "Xác nhận",
                                        MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; 
                LogEvent("-> Việc đóng Form đã bị hủy.");
            }
        }
        private void Form1_FormClosed(object sender, EventArgs e)
        {
            LogEvent("5. FormCLosed: Form đã đóng hoàn toàn");
        }

        private void CreateChildFormBtn_Click(object sender, EventArgs e)
        {
            LogEvent(" Nhấn nút 'Tạo form con'");
            Form childForm = new Form();

            childForm.Text = "Đây là form con";
            childForm.Size = new System.Drawing.Size(400, 150);
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.ShowInTaskbar = false;

            childForm.Show(this);
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
