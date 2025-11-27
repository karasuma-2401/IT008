namespace Bai05
{
    partial class FormQuanLySinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLySinhVien));
            menuStrip1 = new MenuStrip();
            mtsChucNang = new ToolStripMenuItem();
            mtsiAddNew = new ToolStripMenuItem();
            mtsiExit = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbtnAddNew = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            txbTimKiem = new ToolStripTextBox();
            dgvQLSV = new DataGridView();
            SoTT = new DataGridViewTextBoxColumn();
            MaSoSV = new DataGridViewTextBoxColumn();
            TenSinhVien = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            DiemTB = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLSV).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mtsChucNang });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(900, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mtsChucNang
            // 
            mtsChucNang.DropDownItems.AddRange(new ToolStripItem[] { mtsiAddNew, mtsiExit });
            mtsChucNang.Name = "mtsChucNang";
            mtsChucNang.Size = new Size(101, 25);
            mtsChucNang.Text = "Chức Năng";
            // 
            // mtsiAddNew
            // 
            mtsiAddNew.Name = "mtsiAddNew";
            mtsiAddNew.ShortcutKeys = Keys.Control | Keys.N;
            mtsiAddNew.Size = new Size(224, 26);
            mtsiAddNew.Text = "Thêm mới";
            mtsiAddNew.Click += mtsiAddNew_Click;
            // 
            // mtsiExit
            // 
            mtsiExit.Name = "mtsiExit";
            mtsiExit.Size = new Size(224, 26);
            mtsiExit.Text = "Thoát";
            mtsiExit.Click += mtsiExit_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnAddNew, toolStripLabel1, txbTimKiem });
            toolStrip1.Location = new Point(0, 29);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(900, 29);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAddNew
            // 
            tsbtnAddNew.AutoSize = false;
            tsbtnAddNew.Image = (Image)resources.GetObject("tsbtnAddNew.Image");
            tsbtnAddNew.ImageAlign = ContentAlignment.MiddleLeft;
            tsbtnAddNew.ImageTransparentColor = Color.Magenta;
            tsbtnAddNew.Name = "tsbtnAddNew";
            tsbtnAddNew.Size = new Size(400, 26);
            tsbtnAddNew.Text = " Thêm Mới";
            tsbtnAddNew.Click += tsbtnAddNew_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(147, 26);
            toolStripLabel1.Text = " Tìm Kiếm Theo Tên:";
            // 
            // txbTimKiem
            // 
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(310, 29);
            txbTimKiem.TextChanged += txbTimKiem_TextChanged;
            // 
            // dgvQLSV
            // 
            dgvQLSV.AllowUserToAddRows = false;
            dgvQLSV.AllowUserToDeleteRows = false;
            dgvQLSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLSV.Columns.AddRange(new DataGridViewColumn[] { SoTT, MaSoSV, TenSinhVien, Khoa, DiemTB });
            dgvQLSV.Dock = DockStyle.Fill;
            dgvQLSV.Location = new Point(0, 58);
            dgvQLSV.Name = "dgvQLSV";
            dgvQLSV.ReadOnly = true;
            dgvQLSV.RowHeadersWidth = 51;
            dgvQLSV.RowTemplate.Height = 29;
            dgvQLSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLSV.Size = new Size(900, 414);
            dgvQLSV.TabIndex = 2;
            dgvQLSV.CellClick += dataGridView1_CellClick;
            // 
            // SoTT
            // 
            SoTT.DataPropertyName = "SoTT";
            SoTT.HeaderText = "Số TT";
            SoTT.MinimumWidth = 6;
            SoTT.Name = "SoTT";
            SoTT.ReadOnly = true;
            SoTT.Width = 80;
            // 
            // MaSoSV
            // 
            MaSoSV.DataPropertyName = "MaSoSV";
            MaSoSV.HeaderText = "Mã Số SV";
            MaSoSV.MinimumWidth = 6;
            MaSoSV.Name = "MaSoSV";
            MaSoSV.ReadOnly = true;
            MaSoSV.Width = 125;
            // 
            // TenSinhVien
            // 
            TenSinhVien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenSinhVien.DataPropertyName = "TenSinhVien";
            TenSinhVien.HeaderText = "Tên Sinh Viên";
            TenSinhVien.MinimumWidth = 6;
            TenSinhVien.Name = "TenSinhVien";
            TenSinhVien.ReadOnly = true;
            // 
            // Khoa
            // 
            Khoa.DataPropertyName = "Khoa";
            Khoa.HeaderText = "Khoa";
            Khoa.MinimumWidth = 6;
            Khoa.Name = "Khoa";
            Khoa.ReadOnly = true;
            Khoa.Width = 150;
            // 
            // DiemTB
            // 
            DiemTB.DataPropertyName = "DiemTB";
            DiemTB.HeaderText = "Điểm TB";
            DiemTB.MinimumWidth = 6;
            DiemTB.Name = "DiemTB";
            DiemTB.ReadOnly = true;
            DiemTB.Width = 125;
            // 
            // FormQuanLySinhVien
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 472);
            Controls.Add(dgvQLSV);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormQuanLySinhVien";
            Text = "Quản Lý Sinh Viên";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mtsChucNang;
        private ToolStripMenuItem mtsiAddNew;
        private ToolStripMenuItem mtsiExit;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnAddNew;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txbTimKiem;
        private DataGridView dgvQLSV;
        private DataGridViewTextBoxColumn SoTT;
        private DataGridViewTextBoxColumn MaSoSV;
        private DataGridViewTextBoxColumn TenSinhVien;
        private DataGridViewTextBoxColumn Khoa;
        private DataGridViewTextBoxColumn DiemTB;
    }
}