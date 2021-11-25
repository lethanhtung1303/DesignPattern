
namespace quanlyxekhach
{
    partial class ManageCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLTTCDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFind = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCustomerPhoneNum = new quanlyxekhach.StrateryPattern.MyTextBox();
            this.txtCustomerName = new quanlyxekhach.StrateryPattern.MyTextBox();
            this.txtMaKh = new quanlyxekhach.StrateryPattern.MyTextBox();
            this.txtStt = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.Label();
            this.btnDeleteTextBox = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.radFemaleCus = new System.Windows.Forms.RadioButton();
            this.radMaleCus = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFind = new quanlyxekhach.StrateryPattern.MyTextBox();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKháchHàngToolStripMenuItem,
            this.QLTTCDToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng ";
            // 
            // QLTTCDToolStripMenuItem
            // 
            this.QLTTCDToolStripMenuItem.Name = "QLTTCDToolStripMenuItem";
            this.QLTTCDToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.QLTTCDToolStripMenuItem.Text = "Quản lý thông tin chuyến đi";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNgườiDùngToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinNgườiDùngToolStripMenuItem
            // 
            this.thôngTinNgườiDùngToolStripMenuItem.Name = "thôngTinNgườiDùngToolStripMenuItem";
            this.thôngTinNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.thôngTinNgườiDùngToolStripMenuItem.Text = "Thông tin người dùng";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(395, 58);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 28);
            this.btnFind.TabIndex = 17;
            this.btnFind.Text = "tìm kiếm ";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "nhập thông tin  khách hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCustomerPhoneNum);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.txtMaKh);
            this.panel2.Controls.Add(this.txtStt);
            this.panel2.Controls.Add(this.txtTenTK);
            this.panel2.Controls.Add(this.btnDeleteTextBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnChange);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.radFemaleCus);
            this.panel2.Controls.Add(this.radMaleCus);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(557, 97);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 379);
            this.panel2.TabIndex = 14;
            // 
            // txtCustomerPhoneNum
            // 
            this.txtCustomerPhoneNum.Location = new System.Drawing.Point(145, 129);
            this.txtCustomerPhoneNum.Name = "txtCustomerPhoneNum";
            this.txtCustomerPhoneNum.Size = new System.Drawing.Size(262, 22);
            this.txtCustomerPhoneNum.TabIndex = 21;
            this.txtCustomerPhoneNum.validType = quanlyxekhach.StrateryPattern.ValidationType.INTERGER;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(143, 81);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(264, 22);
            this.txtCustomerName.TabIndex = 20;
            this.txtCustomerName.validType = quanlyxekhach.StrateryPattern.ValidationType.STRING;
            // 
            // txtMaKh
            // 
            this.txtMaKh.Location = new System.Drawing.Point(141, 40);
            this.txtMaKh.Name = "txtMaKh";
            this.txtMaKh.ReadOnly = true;
            this.txtMaKh.Size = new System.Drawing.Size(264, 22);
            this.txtMaKh.TabIndex = 19;
            this.txtMaKh.validType = quanlyxekhach.StrateryPattern.ValidationType.STRING;
            // 
            // txtStt
            // 
            this.txtStt.AutoSize = true;
            this.txtStt.ForeColor = System.Drawing.SystemColors.Control;
            this.txtStt.Location = new System.Drawing.Point(427, 34);
            this.txtStt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtStt.Name = "txtStt";
            this.txtStt.Size = new System.Drawing.Size(38, 17);
            this.txtStt.TabIndex = 18;
            this.txtStt.Text = "label";
            // 
            // txtTenTK
            // 
            this.txtTenTK.AutoSize = true;
            this.txtTenTK.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTenTK.Location = new System.Drawing.Point(48, 17);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(0, 17);
            this.txtTenTK.TabIndex = 17;
            // 
            // btnDeleteTextBox
            // 
            this.btnDeleteTextBox.Location = new System.Drawing.Point(184, 300);
            this.btnDeleteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTextBox.Name = "btnDeleteTextBox";
            this.btnDeleteTextBox.Size = new System.Drawing.Size(137, 28);
            this.btnDeleteTextBox.TabIndex = 10;
            this.btnDeleteTextBox.Text = "xóa dữ liệu textbox";
            this.btnDeleteTextBox.UseVisualStyleBackColor = true;
            this.btnDeleteTextBox.Click += new System.EventHandler(this.btnDeleteTextBox_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 43);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Mã khách hàng";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(83, 238);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 28);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(307, 238);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // radFemaleCus
            // 
            this.radFemaleCus.AutoSize = true;
            this.radFemaleCus.Location = new System.Drawing.Point(293, 174);
            this.radFemaleCus.Margin = new System.Windows.Forms.Padding(4);
            this.radFemaleCus.Name = "radFemaleCus";
            this.radFemaleCus.Size = new System.Drawing.Size(47, 21);
            this.radFemaleCus.TabIndex = 5;
            this.radFemaleCus.TabStop = true;
            this.radFemaleCus.Text = "Nữ";
            this.radFemaleCus.UseVisualStyleBackColor = true;
            // 
            // radMaleCus
            // 
            this.radMaleCus.AutoSize = true;
            this.radMaleCus.Location = new System.Drawing.Point(140, 176);
            this.radMaleCus.Margin = new System.Windows.Forms.Padding(4);
            this.radMaleCus.Name = "radMaleCus";
            this.radMaleCus.Size = new System.Drawing.Size(62, 21);
            this.radMaleCus.TabIndex = 4;
            this.radMaleCus.TabStop = true;
            this.radMaleCus.Text = "Nam ";
            this.radMaleCus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ và tên ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin  khách hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(16, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 446);
            this.panel1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.MaKH,
            this.TenKH,
            this.Sdt,
            this.GioiTinh});
            this.dataGridView1.Location = new System.Drawing.Point(24, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(481, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(224, 61);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(163, 22);
            this.txtFind.TabIndex = 19;
            this.txtFind.validType = quanlyxekhach.StrateryPattern.ValidationType.STRING;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // stt
            // 
            this.stt.DataPropertyName = "stt";
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 125;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "MaKH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 125;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "TenKH";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 125;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Sdt";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GioiTinh";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageCustomer";
            this.Text = "ManageCustomer";
            this.Load += new System.EventHandler(this.ManageCustomer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLTTCDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteTextBox;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton radFemaleCus;
        private System.Windows.Forms.RadioButton radMaleCus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtTenTK;
        private System.Windows.Forms.Label txtStt;
        private StrateryPattern.MyTextBox txtCustomerPhoneNum;
        private StrateryPattern.MyTextBox txtCustomerName;
        private StrateryPattern.MyTextBox txtMaKh;
        private StrateryPattern.MyTextBox txtFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
    }
}