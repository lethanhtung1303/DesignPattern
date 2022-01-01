
namespace quanlyxekhach
{
    partial class ManageInfoTrip
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
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbIdTG = new System.Windows.Forms.ComboBox();
            this.cbIdDriver = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbNameLocation = new System.Windows.Forms.ComboBox();
            this.btnShowData = new System.Windows.Forms.Button();
            this.cbNameTG = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNameDriver = new System.Windows.Forms.ComboBox();
            this.cbIdVeh = new System.Windows.Forms.ComboBox();
            this.dtstar = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStt = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(969, 48);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 28);
            this.btnFind.TabIndex = 25;
            this.btnFind.Text = "tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(804, 52);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(132, 22);
            this.txtFind.TabIndex = 24;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nhập thông tin ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(660, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(436, 385);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbIdTG);
            this.panel1.Controls.Add(this.cbIdDriver);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbNameLocation);
            this.panel1.Controls.Add(this.btnShowData);
            this.panel1.Controls.Add(this.cbNameTG);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbNameDriver);
            this.panel1.Controls.Add(this.cbIdVeh);
            this.panel1.Controls.Add(this.dtstar);
            this.panel1.Controls.Add(this.dtEnd);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtStt);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 507);
            this.panel1.TabIndex = 21;
            // 
            // cbIdTG
            // 
            this.cbIdTG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdTG.FormattingEnabled = true;
            this.cbIdTG.Location = new System.Drawing.Point(356, 97);
            this.cbIdTG.Margin = new System.Windows.Forms.Padding(4);
            this.cbIdTG.Name = "cbIdTG";
            this.cbIdTG.Size = new System.Drawing.Size(95, 24);
            this.cbIdTG.TabIndex = 27;
            this.cbIdTG.TextChanged += new System.EventHandler(this.cbNameDriver_TextChanged);
            // 
            // cbIdDriver
            // 
            this.cbIdDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdDriver.FormattingEnabled = true;
            this.cbIdDriver.Location = new System.Drawing.Point(356, 50);
            this.cbIdDriver.Margin = new System.Windows.Forms.Padding(4);
            this.cbIdDriver.Name = "cbIdDriver";
            this.cbIdDriver.Size = new System.Drawing.Size(95, 24);
            this.cbIdDriver.TabIndex = 26;
            this.cbIdDriver.TextChanged += new System.EventHandler(this.cbNameDriver_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 201);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tên địa điểm";
            // 
            // cbNameLocation
            // 
            this.cbNameLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameLocation.FormattingEnabled = true;
            this.cbNameLocation.Location = new System.Drawing.Point(113, 191);
            this.cbNameLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cbNameLocation.Name = "cbNameLocation";
            this.cbNameLocation.Size = new System.Drawing.Size(213, 24);
            this.cbNameLocation.TabIndex = 24;
            this.cbNameLocation.TextChanged += new System.EventHandler(this.cbNameDriver_TextChanged);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(477, 97);
            this.btnShowData.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(132, 28);
            this.btnShowData.TabIndex = 21;
            this.btnShowData.Text = "hiển thị dữ liệu";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // cbNameTG
            // 
            this.cbNameTG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameTG.FormattingEnabled = true;
            this.cbNameTG.Location = new System.Drawing.Point(113, 100);
            this.cbNameTG.Margin = new System.Windows.Forms.Padding(4);
            this.cbNameTG.Name = "cbNameTG";
            this.cbNameTG.Size = new System.Drawing.Size(213, 24);
            this.cbNameTG.TabIndex = 20;
            this.cbNameTG.TextChanged += new System.EventHandler(this.cbNameDriver_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tên HDV";
            // 
            // cbNameDriver
            // 
            this.cbNameDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameDriver.FormattingEnabled = true;
            this.cbNameDriver.Location = new System.Drawing.Point(113, 50);
            this.cbNameDriver.Margin = new System.Windows.Forms.Padding(4);
            this.cbNameDriver.Name = "cbNameDriver";
            this.cbNameDriver.Size = new System.Drawing.Size(213, 24);
            this.cbNameDriver.TabIndex = 18;
            this.cbNameDriver.TextChanged += new System.EventHandler(this.cbNameDriver_TextChanged);
            // 
            // cbIdVeh
            // 
            this.cbIdVeh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdVeh.FormattingEnabled = true;
            this.cbIdVeh.Location = new System.Drawing.Point(113, 145);
            this.cbIdVeh.Margin = new System.Windows.Forms.Padding(4);
            this.cbIdVeh.Name = "cbIdVeh";
            this.cbIdVeh.Size = new System.Drawing.Size(213, 24);
            this.cbIdVeh.TabIndex = 17;
            this.cbIdVeh.TextChanged += new System.EventHandler(this.cbNameDriver_TextChanged);
            // 
            // dtstar
            // 
            this.dtstar.Location = new System.Drawing.Point(165, 224);
            this.dtstar.Margin = new System.Windows.Forms.Padding(4);
            this.dtstar.Name = "dtstar";
            this.dtstar.Size = new System.Drawing.Size(265, 22);
            this.dtstar.TabIndex = 16;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(165, 265);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(265, 22);
            this.dtEnd.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 389);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtStt
            // 
            this.txtStt.AutoSize = true;
            this.txtStt.BackColor = System.Drawing.SystemColors.Control;
            this.txtStt.ForeColor = System.Drawing.SystemColors.Control;
            this.txtStt.Location = new System.Drawing.Point(44, 41);
            this.txtStt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtStt.Name = "txtStt";
            this.txtStt.Size = new System.Drawing.Size(0, 17);
            this.txtStt.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(159, 442);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 28);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(284, 334);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 28);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(73, 334);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "THÔNG TIN ĐIỀU HÀNH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên tài xế";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chuyến xe";
            // 
            // ManageInfoTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 609);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageInfoTrip";
            this.Text = "ManageInfoTrip";
            this.Load += new System.EventHandler(this.ManageInfoTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbNameDriver;
        private System.Windows.Forms.ComboBox cbIdVeh;
        private System.Windows.Forms.DateTimePicker dtstar;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label txtStt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.ComboBox cbNameTG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbNameLocation;
        private System.Windows.Forms.ComboBox cbIdTG;
        private System.Windows.Forms.ComboBox cbIdDriver;
    }
}