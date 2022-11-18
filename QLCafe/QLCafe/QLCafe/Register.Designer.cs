namespace QLCafe
{
    partial class frmRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserR = new System.Windows.Forms.TextBox();
            this.txtPassR = new System.Windows.Forms.TextBox();
            this.txtRepeatP = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReturnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu:\r\n";
            // 
            // txtUserR
            // 
            this.txtUserR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserR.Location = new System.Drawing.Point(178, 55);
            this.txtUserR.Name = "txtUserR";
            this.txtUserR.Size = new System.Drawing.Size(354, 22);
            this.txtUserR.TabIndex = 3;
            // 
            // txtPassR
            // 
            this.txtPassR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassR.Location = new System.Drawing.Point(178, 132);
            this.txtPassR.Name = "txtPassR";
            this.txtPassR.Size = new System.Drawing.Size(354, 22);
            this.txtPassR.TabIndex = 4;
            // 
            // txtRepeatP
            // 
            this.txtRepeatP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepeatP.Location = new System.Drawing.Point(178, 211);
            this.txtRepeatP.Name = "txtRepeatP";
            this.txtRepeatP.Size = new System.Drawing.Size(354, 22);
            this.txtRepeatP.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(250, 279);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(110, 38);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReturnLogin
            // 
            this.btnReturnLogin.Location = new System.Drawing.Point(422, 279);
            this.btnReturnLogin.Name = "btnReturnLogin";
            this.btnReturnLogin.Size = new System.Drawing.Size(110, 38);
            this.btnReturnLogin.TabIndex = 7;
            this.btnReturnLogin.Text = "Trở về";
            this.btnReturnLogin.UseVisualStyleBackColor = true;
            this.btnReturnLogin.Click += new System.EventHandler(this.btnReturnLogin_Click);
            // 
            // frmRegister
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 356);
            this.Controls.Add(this.btnReturnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRepeatP);
            this.Controls.Add(this.txtPassR);
            this.Controls.Add(this.txtUserR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserR;
        private System.Windows.Forms.TextBox txtPassR;
        private System.Windows.Forms.TextBox txtRepeatP;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReturnLogin;
    }
}