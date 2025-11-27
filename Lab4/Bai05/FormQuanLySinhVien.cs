namespace Bai05
{
    public partial class FormQuanLySinhVien : Form
    {
        private int currentSTT = 1;
        public FormQuanLySinhVien()
        {
            InitializeComponent();
        }
        private void mtsiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnAddNew_Click(object sender, EventArgs e)
        {
            addNewSV();
        }

        private void mtsiAddNew_Click(object sender, EventArgs e)
        {
            addNewSV();
        }
        private void addNewSV()
        {
            FormThemSinhVien addForm = new FormThemSinhVien();
            int STT = currentSTT;
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                string MSSV = addForm.MSSV;
                string TenSV = addForm.TenSV;
                string Khoa = addForm.Khoa;
                float DiemTB = addForm.DiemTB;
                DataGridViewRow IsExisted = null;
                foreach (DataGridViewRow row in dgvQLSV.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells[1].Value.ToString() == addForm.MSSV)
                    {
                        IsExisted = row;
                        break;
                    }
                }
                if (IsExisted != null)
                {
                    MessageBox.Show("MSSV đã tồn tại! Vui Lòng nhập lại MSSV");
                }
                else
                {
                    int index = dgvQLSV.Rows.Add();
                    dgvQLSV.Rows[index].Cells[0].Value = currentSTT++;
                    dgvQLSV.Rows[index].Cells[1].Value = MSSV;
                    dgvQLSV.Rows[index].Cells[2].Value = TenSV;
                    dgvQLSV.Rows[index].Cells[3].Value = Khoa;
                    dgvQLSV.Rows[index].Cells[4].Value = DiemTB;
                    MessageBox.Show("Lưu thông tin thành công !");
                }
            }
        }
        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txbTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow row in dgvQLSV.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells[2].Value != null && row.Cells[2].Value.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }

                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= 0 && e.RowIndex < dgvQLSV.Rows.Count)
            {
                DataGridViewRow row = dgvQLSV.Rows[e.RowIndex];
                if (row.Cells["TenSinhVien"].Value != null)
                {
                    txbTimKiem.Text = row.Cells[2].Value.ToString();
                }
            }
        }
    }
}