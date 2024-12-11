
namespace QL_NVL_MonAn
{
    partial class FormTrungTam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrungTam));
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.tenTK = new System.Windows.Forms.Label();
            this.chucVuTK = new System.Windows.Forms.Label();
            this.taiKhoanBtn = new System.Windows.Forms.Button();
            this.monAnBtn = new System.Windows.Forms.Button();
            this.nguyenLieuBtn = new System.Windows.Forms.Button();
            this.dangXuatBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // avatarBox
            // 
            this.avatarBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("avatarBox.InitialImage")));
            this.avatarBox.Location = new System.Drawing.Point(12, 12);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(100, 100);
            this.avatarBox.TabIndex = 0;
            this.avatarBox.TabStop = false;
            // 
            // tenTK
            // 
            this.tenTK.AutoSize = true;
            this.tenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTK.Location = new System.Drawing.Point(128, 12);
            this.tenTK.Name = "tenTK";
            this.tenTK.Size = new System.Drawing.Size(144, 25);
            this.tenTK.TabIndex = 2;
            this.tenTK.Text = "Tên tài khoản";
            // 
            // chucVuTK
            // 
            this.chucVuTK.AutoSize = true;
            this.chucVuTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chucVuTK.Location = new System.Drawing.Point(129, 48);
            this.chucVuTK.Name = "chucVuTK";
            this.chucVuTK.Size = new System.Drawing.Size(70, 20);
            this.chucVuTK.TabIndex = 2;
            this.chucVuTK.Text = "Chức vụ";
            // 
            // taiKhoanBtn
            // 
            this.taiKhoanBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.taiKhoanBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.taiKhoanBtn.Location = new System.Drawing.Point(101, 271);
            this.taiKhoanBtn.Name = "taiKhoanBtn";
            this.taiKhoanBtn.Size = new System.Drawing.Size(132, 44);
            this.taiKhoanBtn.TabIndex = 3;
            this.taiKhoanBtn.Text = "Tài khoản";
            this.taiKhoanBtn.UseVisualStyleBackColor = false;
            this.taiKhoanBtn.Click += new System.EventHandler(this.taiKhoanBtn_Click);
            // 
            // monAnBtn
            // 
            this.monAnBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.monAnBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.monAnBtn.Location = new System.Drawing.Point(310, 271);
            this.monAnBtn.Name = "monAnBtn";
            this.monAnBtn.Size = new System.Drawing.Size(132, 44);
            this.monAnBtn.TabIndex = 3;
            this.monAnBtn.Text = "Món ăn";
            this.monAnBtn.UseVisualStyleBackColor = false;
            this.monAnBtn.Click += new System.EventHandler(this.monAnBtn_Click);
            // 
            // nguyenLieuBtn
            // 
            this.nguyenLieuBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.nguyenLieuBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nguyenLieuBtn.Location = new System.Drawing.Point(519, 271);
            this.nguyenLieuBtn.Name = "nguyenLieuBtn";
            this.nguyenLieuBtn.Size = new System.Drawing.Size(132, 44);
            this.nguyenLieuBtn.TabIndex = 3;
            this.nguyenLieuBtn.Text = "Nguyên liệu";
            this.nguyenLieuBtn.UseVisualStyleBackColor = false;
            this.nguyenLieuBtn.Click += new System.EventHandler(this.nguyenLieuBtn_Click);
            // 
            // dangXuatBtn
            // 
            this.dangXuatBtn.BackColor = System.Drawing.Color.DarkRed;
            this.dangXuatBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dangXuatBtn.Location = new System.Drawing.Point(133, 84);
            this.dangXuatBtn.Name = "dangXuatBtn";
            this.dangXuatBtn.Size = new System.Drawing.Size(98, 28);
            this.dangXuatBtn.TabIndex = 4;
            this.dangXuatBtn.Text = "Đăng xuất";
            this.dangXuatBtn.UseVisualStyleBackColor = false;
            this.dangXuatBtn.Click += new System.EventHandler(this.dangXuatBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý";
            // 
            // FormTrungTam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(760, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dangXuatBtn);
            this.Controls.Add(this.nguyenLieuBtn);
            this.Controls.Add(this.monAnBtn);
            this.Controls.Add(this.taiKhoanBtn);
            this.Controls.Add(this.chucVuTK);
            this.Controls.Add(this.tenTK);
            this.Controls.Add(this.avatarBox);
            this.Name = "FormTrungTam";
            this.Text = "Trung tâm quản lý";
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.Label tenTK;
        private System.Windows.Forms.Label chucVuTK;
        private System.Windows.Forms.Button taiKhoanBtn;
        private System.Windows.Forms.Button monAnBtn;
        private System.Windows.Forms.Button nguyenLieuBtn;
        private System.Windows.Forms.Button dangXuatBtn;
        private System.Windows.Forms.Label label1;
    }
}