namespace QuanLySinhVien
{
    public partial class FormThemSinhVien : Form
    {
        public int STT;
        public string MSSV;
        public string TenSV;
        public string Khoa;
        public float DiemTB;
        public FormThemSinhVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

            if (txtMaSV.Text == "" || txtTenSV.Text == "" || cbbKhoa.Text == "" || txtDiemTB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!float.TryParse(txtDiemTB.Text, out float diemTB) || diemTB < 0 || diemTB > 10)
            {
                MessageBox.Show("Điểm trung bình không hợp lệ", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MSSV = txtMaSV.Text;
            TenSV = txtTenSV.Text;
            Khoa = cbbKhoa.SelectedItem.ToString();
            DiemTB = float.Parse(txtDiemTB.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}