namespace Bai09
{
    partial class InforStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMSSV = new TextBox();
            txtHoTen = new TextBox();
            cboChuyenNganh = new ComboBox();
            chkNam = new CheckBox();
            chkNu = new CheckBox();
            lsbSubject = new ListBox();
            lsbSelectedSubject = new ListBox();
            btnSelected = new Button();
            btnUnSelected = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            dgvSinhVien = new DataGridView();
            dgvMSSV = new DataGridViewTextBoxColumn();
            dgvHoTen = new DataGridViewTextBoxColumn();
            dgvChuyenNganh = new DataGridViewTextBoxColumn();
            dgvGioiTinh = new DataGridViewTextBoxColumn();
            dgvSoMon = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 25);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 76);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 123);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 2;
            label3.Text = "Chuyên Ngành";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 174);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 3;
            label4.Text = "Giới Tính";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(320, 25);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(151, 29);
            txtMSSV.TabIndex = 4;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(320, 68);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(286, 29);
            txtHoTen.TabIndex = 5;
            // 
            // cboChuyenNganh
            // 
            cboChuyenNganh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChuyenNganh.FlatStyle = FlatStyle.System;
            cboChuyenNganh.FormattingEnabled = true;
            cboChuyenNganh.Items.AddRange(new object[] { "Truyền thông Đa phương tiện", "Thương mại điện tử", "Khoa học dữ liệu", "Khoa học máy tính", "Mạng máy tính và truyền thông dữ liệu", "Kỹ thuật phần mềm\t", "Hệ thống thông tin", "Kỹ thuật máy tính", "Trí tuệ nhân tạo", "Công nghệ thông tin", "Công nghệ thông tin Việt Nhật", "An toàn thông tin", "Thiết kế Vi mạch" });
            cboChuyenNganh.Location = new Point(320, 115);
            cboChuyenNganh.Name = "cboChuyenNganh";
            cboChuyenNganh.Size = new Size(286, 29);
            cboChuyenNganh.TabIndex = 6;
            // 
            // chkNam
            // 
            chkNam.AutoSize = true;
            chkNam.Location = new Point(336, 170);
            chkNam.Name = "chkNam";
            chkNam.Size = new Size(66, 25);
            chkNam.TabIndex = 7;
            chkNam.Text = "Nam";
            chkNam.UseVisualStyleBackColor = true;
            chkNam.Click += chkNam_Click;
            // 
            // chkNu
            // 
            chkNu.AutoSize = true;
            chkNu.Location = new Point(429, 170);
            chkNu.Name = "chkNu";
            chkNu.Size = new Size(53, 25);
            chkNu.TabIndex = 8;
            chkNu.Text = "Nữ";
            chkNu.UseVisualStyleBackColor = true;
            chkNu.Click += chkNu_Click;
            // 
            // lsbSubject
            // 
            lsbSubject.FormattingEnabled = true;
            lsbSubject.Items.AddRange(new object[] { "Nhập Môn Lập Trình", "Giải Tích", "Đại Số Tuyến Tính", "Cấu Trúc Dữ Liệu Và Giải Thuật", "Lập Trình hướng Đối Tượng", "Cấu Trúc Rời Rạc", "Nhập Môn Mạng Máy Tính", "Hệ Điều Hành", "Triết Học", "Pháp Luật Đại Cương" });
            lsbSubject.Location = new Point(165, 257);
            lsbSubject.Name = "lsbSubject";
            lsbSubject.Size = new Size(244, 88);
            lsbSubject.TabIndex = 9;
            // 
            // lsbSelectedSubject
            // 
            lsbSelectedSubject.FormattingEnabled = true;
            lsbSelectedSubject.Location = new Point(536, 257);
            lsbSelectedSubject.Name = "lsbSelectedSubject";
            lsbSelectedSubject.Size = new Size(256, 88);
            lsbSelectedSubject.TabIndex = 10;
            // 
            // btnSelected
            // 
            btnSelected.FlatStyle = FlatStyle.Flat;
            btnSelected.Font = new Font("Segoe UI", 10.8F);
            btnSelected.Location = new Point(446, 257);
            btnSelected.Name = "btnSelected";
            btnSelected.Size = new Size(59, 37);
            btnSelected.TabIndex = 11;
            btnSelected.Text = ">";
            btnSelected.UseVisualStyleBackColor = true;
            btnSelected.Click += btnSelected_Click;
            // 
            // btnUnSelected
            // 
            btnUnSelected.FlatStyle = FlatStyle.Flat;
            btnUnSelected.Font = new Font("Segoe UI", 10.8F);
            btnUnSelected.Location = new Point(446, 308);
            btnUnSelected.Name = "btnUnSelected";
            btnUnSelected.Size = new Size(59, 37);
            btnUnSelected.TabIndex = 12;
            btnUnSelected.Text = "<";
            btnUnSelected.UseVisualStyleBackColor = true;
            btnUnSelected.Click += btnUnSelected_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(320, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 33);
            btnSave.TabIndex = 13;
            btnSave.Text = "Lưu Thông Tin";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(497, 358);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 37);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Xóa Chọn";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnUnSelected);
            groupBox1.Controls.Add(btnSelected);
            groupBox1.Controls.Add(lsbSelectedSubject);
            groupBox1.Controls.Add(lsbSubject);
            groupBox1.Controls.Add(chkNu);
            groupBox1.Controls.Add(chkNam);
            groupBox1.Controls.Add(cboChuyenNganh);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMSSV);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(52, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(865, 418);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 222);
            label5.Name = "label5";
            label5.Size = new Size(213, 21);
            label5.TabIndex = 15;
            label5.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { dgvMSSV, dgvHoTen, dgvChuyenNganh, dgvGioiTinh, dgvSoMon });
            dgvSinhVien.Location = new Point(52, 466);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(865, 196);
            dgvSinhVien.TabIndex = 15;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // dgvMSSV
            // 
            dgvMSSV.HeaderText = "MSSV";
            dgvMSSV.MinimumWidth = 6;
            dgvMSSV.Name = "dgvMSSV";
            dgvMSSV.Width = 120;
            // 
            // dgvHoTen
            // 
            dgvHoTen.HeaderText = "Họ Tên";
            dgvHoTen.MinimumWidth = 6;
            dgvHoTen.Name = "dgvHoTen";
            dgvHoTen.Width = 250;
            // 
            // dgvChuyenNganh
            // 
            dgvChuyenNganh.HeaderText = "Chuyên Ngành";
            dgvChuyenNganh.MinimumWidth = 6;
            dgvChuyenNganh.Name = "dgvChuyenNganh";
            dgvChuyenNganh.Width = 250;
            // 
            // dgvGioiTinh
            // 
            dgvGioiTinh.HeaderText = "Giới Tính";
            dgvGioiTinh.MinimumWidth = 6;
            dgvGioiTinh.Name = "dgvGioiTinh";
            dgvGioiTinh.Width = 120;
            // 
            // dgvSoMon
            // 
            dgvSoMon.HeaderText = "Số Môn";
            dgvSoMon.MinimumWidth = 6;
            dgvSoMon.Name = "dgvSoMon";
            dgvSoMon.Width = 120;
            // 
            // InforStudent
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 696);
            Controls.Add(dgvSinhVien);
            Controls.Add(groupBox1);
            Name = "InforStudent";
            Text = "Nhập Liệu Sinh Viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMSSV;
        private TextBox txtHoTen;
        private ComboBox cboChuyenNganh;
        private CheckBox chkNam;
        private CheckBox chkNu;
        private ListBox lsbSubject;
        private ListBox lsbSelectedSubject;
        private Button btnSelected;
        private Button btnUnSelected;
        private Button btnSave;
        private Button btnDelete;
        private GroupBox groupBox1;
        private DataGridView dgvSinhVien;
        private DataGridViewTextBoxColumn dgvMSSV;
        private DataGridViewTextBoxColumn dgvHoTen;
        private DataGridViewTextBoxColumn dgvChuyenNganh;
        private DataGridViewTextBoxColumn dgvGioiTinh;
        private DataGridViewTextBoxColumn dgvSoMon;
        private Label label5;
    }
}
