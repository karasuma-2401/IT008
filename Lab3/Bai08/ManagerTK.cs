namespace Bai08
{
    public partial class ManagerTK : Form
    {
        public ManagerTK()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string STK = STK_box.Text;
            string TenKH = TKH_box.Text;
            string DiaChiKH = DiaChiKH_box.Text;
            string Money = Money_Box.Text;

            if (STK_box.Text == "" || TKH_box.Text == "" || DiaChiKH_box.Text == "" || Money_Box.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            ListViewItem isExistedItem = null;
            foreach (ListViewItem item in KHList.Items)
            {
                if (item.SubItems[1].Text == STK)
                {
                    isExistedItem = item;
                    break;
                }
            }

            if (isExistedItem != null)
            {
                isExistedItem.SubItems[2].Text = TenKH;
                isExistedItem.SubItems[3].Text = DiaChiKH;
                isExistedItem.SubItems[4].Text = Money;

                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                string stt = (KHList.Items.Count + 1).ToString();
                ListViewItem newItem = new ListViewItem(stt);
                newItem.SubItems.Add(STK);
                newItem.SubItems.Add(TenKH);
                newItem.SubItems.Add(DiaChiKH);
                newItem.SubItems.Add(Money);

                KHList.Items.Add(newItem);
                MessageBox.Show("Thêm mới dữ liệu thành công!");
            }
            calculateMoneySum();
            clearContent();
        }
        private void clearContent()
        {
            STK_box.Clear();
            TKH_box.Clear();
            DiaChiKH_box.Clear();
            Money_Box.Clear();
            STK_box.Focus();
        }
        private void UpdateSTT()
        {
            for (int index = 0; index < KHList.Items.Count; index++)
            {
                ListViewItem item = KHList.Items[index];
                item.SubItems[0].Text = (index + 1).ToString();
            }
        }
        private void calculateMoneySum()
        {
            double MoneySum = 0;
            foreach (ListViewItem item in KHList.Items)
            {
                double money = double.Parse(item.SubItems[4].Text);
                MoneySum += money;
            }
            MoneySum_box.Text = MoneySum.ToString();
        }
        private void deleteItem(ListViewItem item)
        {
            if (item != null)
            {
                DialogResult answer = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa tài khoản không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    KHList.Items.Remove(item);
                    MessageBox.Show("Xóa tài khoản thành công!");

                    UpdateSTT();
                    calculateMoneySum();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản cần xóa");
            }
            clearContent();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ListViewItem isDeleteItem = null;
            string STK = STK_box.Text;
            foreach (ListViewItem item in KHList.Items)
            {
                if (item.SubItems[1].Text == STK)
                {
                    isDeleteItem = item;
                    break;
                }
            }
            deleteItem(isDeleteItem);
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void KHList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KHList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = KHList.SelectedItems[0];
                STK_box.Text = selectedItem.SubItems[1].Text;
                TKH_box.Text = selectedItem.SubItems[2].Text;
                DiaChiKH_box.Text = selectedItem.SubItems[3].Text;
                Money_Box.Text = selectedItem.SubItems[4].Text;
            }
        }
    }
}
