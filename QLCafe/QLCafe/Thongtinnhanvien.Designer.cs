namespace QLCafe
{
    partial class frmTTNV
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
            this.lbl_thongTin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmPHAI = new System.Windows.Forms.ComboBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDIACHINHA = new System.Windows.Forms.TextBox();
            this.dtNGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btnTTableNV = new System.Windows.Forms.Button();
            this.btnAddTTNV = new System.Windows.Forms.Button();
            this.btnDelTTNV = new System.Windows.Forms.Button();
            this.btnUpTTNV = new System.Windows.Forms.Button();
            this.dtgvTTNV = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHINHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTTNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_thongTin
            // 
            this.lbl_thongTin.AutoSize = true;
            this.lbl_thongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongTin.Location = new System.Drawing.Point(256, 9);
            this.lbl_thongTin.Name = "lbl_thongTin";
            this.lbl_thongTin.Size = new System.Drawing.Size(282, 32);
            this.lbl_thongTin.TabIndex = 2;
            this.lbl_thongTin.Text = "Thông Tin Nhân Viên";
            this.lbl_thongTin.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbmPHAI);
            this.groupBox1.Controls.Add(this.txtMANV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDIACHINHA);
            this.groupBox1.Controls.Add(this.dtNGAYSINH);
            this.groupBox1.Controls.Add(this.txtHOTEN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cbmPHAI
            // 
            this.cbmPHAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmPHAI.FormattingEnabled = true;
            this.cbmPHAI.Location = new System.Drawing.Point(520, 103);
            this.cbmPHAI.Name = "cbmPHAI";
            this.cbmPHAI.Size = new System.Drawing.Size(211, 28);
            this.cbmPHAI.TabIndex = 11;
            this.cbmPHAI.SelectedIndexChanged += new System.EventHandler(this.cbmPHAI_SelectedIndexChanged);
            // 
            // txtMANV
            // 
            this.txtMANV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMANV.Location = new System.Drawing.Point(180, 35);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(193, 27);
            this.txtMANV.TabIndex = 10;
            this.txtMANV.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã Nhân Viên:";
            // 
            // txtSDT
            // 
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Location = new System.Drawing.Point(520, 68);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(211, 27);
            this.txtSDT.TabIndex = 8;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtDIACHINHA
            // 
            this.txtDIACHINHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDIACHINHA.Location = new System.Drawing.Point(521, 31);
            this.txtDIACHINHA.Name = "txtDIACHINHA";
            this.txtDIACHINHA.Size = new System.Drawing.Size(211, 27);
            this.txtDIACHINHA.TabIndex = 7;
            // 
            // dtNGAYSINH
            // 
            this.dtNGAYSINH.Location = new System.Drawing.Point(180, 107);
            this.dtNGAYSINH.Name = "dtNGAYSINH";
            this.dtNGAYSINH.Size = new System.Drawing.Size(193, 27);
            this.dtNGAYSINH.TabIndex = 6;
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHOTEN.Location = new System.Drawing.Point(180, 72);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(193, 27);
            this.txtHOTEN.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Sinh:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(8, 76);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(68, 18);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Họ Tên:";
            // 
            // btnTTableNV
            // 
            this.btnTTableNV.Location = new System.Drawing.Point(654, 406);
            this.btnTTableNV.Name = "btnTTableNV";
            this.btnTTableNV.Size = new System.Drawing.Size(128, 44);
            this.btnTTableNV.TabIndex = 4;
            this.btnTTableNV.Text = "Thoát";
            this.btnTTableNV.UseVisualStyleBackColor = true;
            this.btnTTableNV.Click += new System.EventHandler(this.btnTTableNV_Click);
            // 
            // btnAddTTNV
            // 
            this.btnAddTTNV.Location = new System.Drawing.Point(363, 207);
            this.btnAddTTNV.Name = "btnAddTTNV";
            this.btnAddTTNV.Size = new System.Drawing.Size(75, 23);
            this.btnAddTTNV.TabIndex = 5;
            this.btnAddTTNV.Text = "Thêm ";
            this.btnAddTTNV.UseVisualStyleBackColor = true;
            this.btnAddTTNV.Click += new System.EventHandler(this.btnAddTTNV_Click);
            // 
            // btnDelTTNV
            // 
            this.btnDelTTNV.Location = new System.Drawing.Point(463, 207);
            this.btnDelTTNV.Name = "btnDelTTNV";
            this.btnDelTTNV.Size = new System.Drawing.Size(75, 23);
            this.btnDelTTNV.TabIndex = 6;
            this.btnDelTTNV.Text = "Xóa";
            this.btnDelTTNV.UseVisualStyleBackColor = true;
            // 
            // btnUpTTNV
            // 
            this.btnUpTTNV.Location = new System.Drawing.Point(558, 207);
            this.btnUpTTNV.Name = "btnUpTTNV";
            this.btnUpTTNV.Size = new System.Drawing.Size(75, 23);
            this.btnUpTTNV.TabIndex = 7;
            this.btnUpTTNV.Text = "Sửa";
            this.btnUpTTNV.UseVisualStyleBackColor = true;
            // 
            // dtgvTTNV
            // 
            this.dtgvTTNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTTNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.NGAYSINH,
            this.DIACHINHA,
            this.SDT,
            this.PHAI});
            this.dtgvTTNV.Location = new System.Drawing.Point(12, 236);
            this.dtgvTTNV.Name = "dtgvTTNV";
            this.dtgvTTNV.RowHeadersWidth = 51;
            this.dtgvTTNV.RowTemplate.Height = 24;
            this.dtgvTTNV.Size = new System.Drawing.Size(775, 164);
            this.dtgvTTNV.TabIndex = 8;
            this.dtgvTTNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTTNV_CellContentClick_1);
            // 
            // MANV
            // 
            this.MANV.HeaderText = "MANV";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            this.MANV.Width = 125;
            // 
            // HOTEN
            // 
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            this.HOTEN.Width = 125;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.MinimumWidth = 6;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            this.NGAYSINH.Width = 125;
            // 
            // DIACHINHA
            // 
            this.DIACHINHA.HeaderText = "Địa Chỉ ";
            this.DIACHINHA.MinimumWidth = 6;
            this.DIACHINHA.Name = "DIACHINHA";
            this.DIACHINHA.ReadOnly = true;
            this.DIACHINHA.Width = 125;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 125;
            // 
            // PHAI
            // 
            this.PHAI.HeaderText = "Phái";
            this.PHAI.MinimumWidth = 6;
            this.PHAI.Name = "PHAI";
            this.PHAI.ReadOnly = true;
            this.PHAI.Width = 125;
            // 
            // frmTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 471);
            this.Controls.Add(this.dtgvTTNV);
            this.Controls.Add(this.btnUpTTNV);
            this.Controls.Add(this.btnDelTTNV);
            this.Controls.Add(this.btnAddTTNV);
            this.Controls.Add(this.btnTTableNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_thongTin);
            this.Name = "frmTTNV";
            this.Text = "Thongtinnhanvien";
            this.Load += new System.EventHandler(this.Thongtinnhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTTNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_thongTin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDIACHINHA;
        private System.Windows.Forms.DateTimePicker dtNGAYSINH;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTTableNV;
        private System.Windows.Forms.Button btnAddTTNV;
        private System.Windows.Forms.Button btnDelTTNV;
        private System.Windows.Forms.Button btnUpTTNV;
        private System.Windows.Forms.ComboBox cbmPHAI;
        private System.Windows.Forms.DataGridView dtgvTTNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHINHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHAI;
    }
}