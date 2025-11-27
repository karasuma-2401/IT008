namespace QuanLySinhVien
{
    partial class FormThemSinhVien
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
            lblTitle = new Label();
            lblMaSV = new Label();
            lblTenSV = new Label();
            lblKhoa = new Label();
            lblDiemTB = new Label();
            txtMaSV = new TextBox();
            txtTenSV = new TextBox();
            txtDiemTB = new TextBox();
            cbbKhoa = new ComboBox();
            btnAddNew = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(462, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÊM SINH VIÊN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(34, 79);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(124, 21);
            lblMaSV.TabIndex = 1;
            lblMaSV.Text = "Mã Số Sinh Viên";
            // 
            // lblTenSV
            // 
            lblTenSV.AutoSize = true;
            lblTenSV.Location = new Point(34, 131);
            lblTenSV.Name = "lblTenSV";
            lblTenSV.Size = new Size(103, 21);
            lblTenSV.TabIndex = 2;
            lblTenSV.Text = "Tên Sinh Viên";
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(34, 184);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(45, 21);
            lblKhoa.TabIndex = 3;
            lblKhoa.Text = "Khoa";
            // 
            // lblDiemTB
            // 
            lblDiemTB.AutoSize = true;
            lblDiemTB.Location = new Point(34, 236);
            lblDiemTB.Name = "lblDiemTB";
            lblDiemTB.Size = new Size(68, 21);
            lblDiemTB.TabIndex = 4;
            lblDiemTB.Text = "Điểm TB";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(169, 76);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(281, 29);
            txtMaSV.TabIndex = 5;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(169, 128);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(281, 29);
            txtTenSV.TabIndex = 6;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(169, 233);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(112, 29);
            txtDiemTB.TabIndex = 7;
            // 
            // cbbKhoa
            // 
            cbbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbKhoa.FormattingEnabled = true;
            cbbKhoa.Items.AddRange(new object[] { "Truyền thông Đa phương tiện", "Thương mại điện tử", "Khoa học dữ liệu", "Khoa học máy tính", "Mạng máy tính và truyền thông dữ liệu", "Kỹ thuật phần mềm", "Hệ thống thông tin", "Kỹ thuật máy tính", "Trí tuệ nhân tạo", "Công nghệ thông tin", "Công nghệ thông tin Việt Nhật", "An toàn thông tin", "Thiết kế Vi mạch " });
            cbbKhoa.Location = new Point(169, 181);
            cbbKhoa.Name = "cbbKhoa";
            cbbKhoa.Size = new Size(281, 29);
            cbbKhoa.TabIndex = 8;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.SeaGreen;
            btnAddNew.FlatAppearance.BorderColor = Color.Black;
            btnAddNew.FlatAppearance.MouseOverBackColor = Color.Red;
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddNew.ForeColor = Color.White;
            btnAddNew.Location = new Point(214, 294);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(124, 42);
            btnAddNew.TabIndex = 9;
            btnAddNew.Text = "Thêm Mới";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnThemMoi_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Coral;
            btnExit.FlatAppearance.BorderColor = Color.Black;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(349, 294);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 42);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnThoat_Click;
            // 
            // FormThemSinhVien
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 371);
            Controls.Add(btnExit);
            Controls.Add(btnAddNew);
            Controls.Add(cbbKhoa);
            Controls.Add(txtDiemTB);
            Controls.Add(txtTenSV);
            Controls.Add(txtMaSV);
            Controls.Add(lblDiemTB);
            Controls.Add(lblKhoa);
            Controls.Add(lblTenSV);
            Controls.Add(lblMaSV);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormThemSinhVien";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblMaSV;
        private Label lblTenSV;
        private Label lblKhoa;
        private Label lblDiemTB;
        private TextBox txtMaSV;
        private TextBox txtTenSV;
        private TextBox txtDiemTB;
        private ComboBox cbbKhoa;
        private Button btnAddNew;
        private Button btnExit;
    }
}