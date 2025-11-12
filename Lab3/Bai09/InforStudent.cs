using System.Windows.Forms;

namespace Bai09
{
    public partial class InforStudent : Form
    {
        public InforStudent()
        {
            InitializeComponent();
        }
        private void btnSelected_Click(object sender, EventArgs e)
        {
            if (lsbSubject.SelectedItems.Count > 0)
            {
                bool isExisted = false;
                foreach (string item in lsbSelectedSubject.Items)
                {
                    if (item == lsbSubject.SelectedItem)
                    {
                        isExisted = true;
                        break;
                    }
                }
                if (!isExisted)
                {
                    lsbSelectedSubject.Items.Add(lsbSubject.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Môn học này đã được chọn! Vui lòng chọn lại");
                }  
            }
        }
        private void btnUnSelected_Click(object sender, EventArgs e)
        {
            if (lsbSelectedSubject.SelectedItems.Count > 0)
            {
                lsbSelectedSubject.Items.Remove(lsbSelectedSubject.SelectedItem);
            }
        }
        private void chkNam_Click(object sender, EventArgs e)
        {
            if (chkNu.Checked)
                chkNu.Checked = false;
            chkNu.Checked = false;
        }
        private void chkNu_Click(object sender, EventArgs e)
        {
            if (chkNam.Checked)
                chkNam.Checked = false;
            chkNam.Checked = false;
        }
        private void ClearContent()
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            chkNam.Checked = false;
            chkNu.Checked = false;
            cboChuyenNganh.SelectedIndex = -1;
            lsbSelectedSubject.Items.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string MSSV = txtMSSV.Text;
            string HoTen = txtHoTen.Text;
            string ChuyenNganh = cboChuyenNganh.Text;
            string GioiTinh;
            if (MSSV == "" || HoTen == "" || ChuyenNganh == "" || (chkNam.Checked == false && chkNu.Checked == false))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if (chkNam.Checked == true)
            {
                chkNu.Checked = false;
                GioiTinh = "Nam";
            }
            else
            {
                chkNam.Checked = false;
                GioiTinh = "Nữ";
            }
            int SoMH = lsbSelectedSubject.Items.Count;
            DataGridViewRow IsExisted = null;
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[0].Value.ToString() == MSSV)
                {
                    IsExisted = row;
                    break;
                }
            }
            if (IsExisted != null)
            {
                MessageBox.Show("MSSV đã tồn tại! Vui Lòng nhập lại MSSV");
                txtMSSV.Clear();
                txtMSSV.Focus();

            }
            else
            {
                int index = dgvSinhVien.Rows.Add();
                dgvSinhVien.Rows[index].Cells[0].Value = MSSV;
                dgvSinhVien.Rows[index].Cells[1].Value = HoTen;
                dgvSinhVien.Rows[index].Cells[2].Value = ChuyenNganh;
                dgvSinhVien.Rows[index].Cells[3].Value = GioiTinh;
                dgvSinhVien.Rows[index].Cells[4].Value = SoMH;
                MessageBox.Show("Lưu thông tin thành công !");
                ClearContent();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                DialogResult answer = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa tài khoản không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    dgvSinhVien.Rows.RemoveAt(dgvSinhVien.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Xóa thông tin thành công!");
                }
                ClearContent();
            }
        }
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSinhVien.RowCount -1)
            {
                ClearContent();
                DataGridViewRow row = dgvSinhVien.CurrentRow;
                txtMSSV.Text = (row.Cells[0].Value).ToString();
                txtHoTen.Text = (row.Cells[1].Value).ToString();
                cboChuyenNganh.Text = (row.Cells[2].Value).ToString();
                if ((row.Cells[3].Value).ToString() == "Nam")
                {
                    chkNam.Checked = true;
                }
                else
                {
                    chkNu.Checked = true;
                }
            }
        }
    }
}
