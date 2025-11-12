namespace Bai08
{
    partial class ManagerTK
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
            lbHeader = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            KHList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            AddBtn = new Button();
            DeleteBtn = new Button();
            ExitBtn = new Button();
            label7 = new Label();
            STK_box = new TextBox();
            TKH_box = new TextBox();
            DiaChiKH_box = new TextBox();
            Money_Box = new TextBox();
            MoneySum_box = new TextBox();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.BackColor = Color.White;
            lbHeader.BorderStyle = BorderStyle.FixedSingle;
            lbHeader.FlatStyle = FlatStyle.Popup;
            lbHeader.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.Cyan;
            lbHeader.Location = new Point(14, 22);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(968, 70);
            lbHeader.TabIndex = 0;
            lbHeader.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(229, 116);
            label2.Name = "label2";
            label2.Size = new Size(107, 22);
            label2.TabIndex = 1;
            label2.Text = "Số tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(208, 171);
            label3.Name = "label3";
            label3.Size = new Size(131, 22);
            label3.TabIndex = 2;
            label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(184, 227);
            label4.Name = "label4";
            label4.Size = new Size(159, 22);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(161, 279);
            label5.Name = "label5";
            label5.Size = new Size(186, 22);
            label5.TabIndex = 4;
            label5.Text = "Số tiền trong tài khoản";
            // 
            // KHList
            // 
            KHList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            KHList.FullRowSelect = true;
            KHList.Location = new Point(14, 361);
            KHList.Name = "KHList";
            KHList.Size = new Size(966, 153);
            KHList.TabIndex = 9;
            KHList.UseCompatibleStateImageBehavior = false;
            KHList.View = View.Details;
            KHList.SelectedIndexChanged += KHList_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã tài khoản";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên khách hàng";
            columnHeader3.Width = 220;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Địa chỉ";
            columnHeader4.Width = 350;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Số tiền";
            columnHeader5.Width = 250;
            // 
            // AddBtn
            // 
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.ForeColor = Color.Black;
            AddBtn.Location = new Point(423, 319);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(128, 34);
            AddBtn.TabIndex = 10;
            AddBtn.Text = "Thêm/Cập nhật";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = Color.Black;
            DeleteBtn.Location = new Point(573, 319);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(123, 34);
            DeleteBtn.TabIndex = 11;
            DeleteBtn.Text = "Xóa";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += deleteBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.ForeColor = Color.Black;
            ExitBtn.Location = new Point(725, 319);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(123, 34);
            ExitBtn.TabIndex = 12;
            ExitBtn.Text = "Thoát";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(629, 534);
            label7.Name = "label7";
            label7.Size = new Size(90, 22);
            label7.TabIndex = 14;
            label7.Text = "Tổng tiền:";
            // 
            // STK_box
            // 
            STK_box.Location = new Point(375, 109);
            STK_box.Name = "STK_box";
            STK_box.Size = new Size(409, 29);
            STK_box.TabIndex = 16;
            // 
            // TKH_box
            // 
            TKH_box.Location = new Point(375, 164);
            TKH_box.Name = "TKH_box";
            TKH_box.Size = new Size(409, 29);
            TKH_box.TabIndex = 17;
            // 
            // DiaChiKH_box
            // 
            DiaChiKH_box.Location = new Point(375, 220);
            DiaChiKH_box.Name = "DiaChiKH_box";
            DiaChiKH_box.Size = new Size(409, 29);
            DiaChiKH_box.TabIndex = 18;
            // 
            // Money_Box
            // 
            Money_Box.Location = new Point(375, 272);
            Money_Box.Name = "Money_Box";
            Money_Box.Size = new Size(409, 29);
            Money_Box.TabIndex = 19;
            // 
            // MoneySum_box
            // 
            MoneySum_box.Location = new Point(725, 527);
            MoneySum_box.Name = "MoneySum_box";
            MoneySum_box.Size = new Size(255, 29);
            MoneySum_box.TabIndex = 20;
            MoneySum_box.TextAlign = HorizontalAlignment.Right;
            // 
            // ManagerTK
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(999, 561);
            Controls.Add(MoneySum_box);
            Controls.Add(Money_Box);
            Controls.Add(DiaChiKH_box);
            Controls.Add(TKH_box);
            Controls.Add(STK_box);
            Controls.Add(label7);
            Controls.Add(ExitBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(KHList);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbHeader);
            ForeColor = Color.Cyan;
            Name = "ManagerTK";
            Text = "Quản Lý Tài Khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeader;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListView KHList;
        private Button AddBtn;
        private Button DeleteBtn;
        private Button ExitBtn;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label7;
        private TextBox STK_box;
        private TextBox TKH_box;
        private TextBox DiaChiKH_box;
        private TextBox Money_Box;
        private TextBox MoneySum_box;
    }
}
