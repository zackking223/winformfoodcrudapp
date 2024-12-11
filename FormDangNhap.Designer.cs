
namespace QL_NVL_MonAn
{
    partial class FormDangNhap
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
            this.thoatBtn = new System.Windows.Forms.Button();
            this.dangNhapBtn = new System.Windows.Forms.Button();
            this.matKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thoatBtn
            // 
            this.thoatBtn.BackColor = System.Drawing.Color.DarkRed;
            this.thoatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoatBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.thoatBtn.Location = new System.Drawing.Point(324, 302);
            this.thoatBtn.Name = "thoatBtn";
            this.thoatBtn.Size = new System.Drawing.Size(160, 40);
            this.thoatBtn.TabIndex = 11;
            this.thoatBtn.Text = "Thoát";
            this.thoatBtn.UseVisualStyleBackColor = false;
            this.thoatBtn.Click += new System.EventHandler(this.thoatBtn_Click);
            // 
            // dangNhapBtn
            // 
            this.dangNhapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangNhapBtn.Location = new System.Drawing.Point(137, 302);
            this.dangNhapBtn.Name = "dangNhapBtn";
            this.dangNhapBtn.Size = new System.Drawing.Size(160, 40);
            this.dangNhapBtn.TabIndex = 10;
            this.dangNhapBtn.Text = "Đăng nhập";
            this.dangNhapBtn.UseVisualStyleBackColor = true;
            this.dangNhapBtn.Click += new System.EventHandler(this.dangNhapBtn_Click);
            // 
            // matKhau
            // 
            this.matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matKhau.Location = new System.Drawing.Point(235, 215);
            this.matKhau.Name = "matKhau";
            this.matKhau.PasswordChar = '*';
            this.matKhau.Size = new System.Drawing.Size(331, 27);
            this.matKhau.TabIndex = 9;
            this.matKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.matKhau_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu";
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenDangNhap.Location = new System.Drawing.Point(235, 131);
            this.tenDangNhap.Name = "tenDangNhap";
            this.tenDangNhap.Size = new System.Drawing.Size(331, 27);
            this.tenDangNhap.TabIndex = 7;
            this.tenDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tenDN_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đăng nhập";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 412);
            this.Controls.Add(this.thoatBtn);
            this.Controls.Add(this.dangNhapBtn);
            this.Controls.Add(this.matKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDangNhap";
            this.Text = "Đăng nhập";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDangNhap_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button thoatBtn;
        private System.Windows.Forms.Button dangNhapBtn;
        private System.Windows.Forms.TextBox matKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

