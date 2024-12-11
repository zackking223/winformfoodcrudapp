
namespace QL_NVL_MonAn
{
    partial class FormQL_TaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQL_TaiKhoan));
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.quayLaiBtn = new System.Windows.Forms.Button();
            this.suaBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            this.themAnhBtn = new System.Windows.Forms.Button();
            this.themBtn = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chucVuBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageBox.InitialImage")));
            this.imageBox.Location = new System.Drawing.Point(736, 172);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(150, 150);
            this.imageBox.TabIndex = 58;
            this.imageBox.TabStop = false;
            // 
            // quayLaiBtn
            // 
            this.quayLaiBtn.Location = new System.Drawing.Point(892, 108);
            this.quayLaiBtn.Name = "quayLaiBtn";
            this.quayLaiBtn.Size = new System.Drawing.Size(122, 38);
            this.quayLaiBtn.TabIndex = 9;
            this.quayLaiBtn.Text = "Quay lại";
            this.quayLaiBtn.UseVisualStyleBackColor = true;
            this.quayLaiBtn.Click += new System.EventHandler(this.quayLaiBtn_Click);
            // 
            // suaBtn
            // 
            this.suaBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.suaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.suaBtn.Location = new System.Drawing.Point(892, 28);
            this.suaBtn.Name = "suaBtn";
            this.suaBtn.Size = new System.Drawing.Size(122, 38);
            this.suaBtn.TabIndex = 7;
            this.suaBtn.Text = "Sửa";
            this.suaBtn.UseVisualStyleBackColor = false;
            this.suaBtn.Click += new System.EventHandler(this.suaBtn_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.BackColor = System.Drawing.Color.DarkRed;
            this.xoaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.xoaBtn.Location = new System.Drawing.Point(736, 108);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(122, 38);
            this.xoaBtn.TabIndex = 8;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.UseVisualStyleBackColor = false;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // themAnhBtn
            // 
            this.themAnhBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.themAnhBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.themAnhBtn.Location = new System.Drawing.Point(892, 200);
            this.themAnhBtn.Name = "themAnhBtn";
            this.themAnhBtn.Size = new System.Drawing.Size(122, 38);
            this.themAnhBtn.TabIndex = 10;
            this.themAnhBtn.Text = "Ảnh mới";
            this.themAnhBtn.UseVisualStyleBackColor = false;
            this.themAnhBtn.Click += new System.EventHandler(this.themAnhBtn_Click);
            // 
            // themBtn
            // 
            this.themBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.themBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.themBtn.Location = new System.Drawing.Point(736, 28);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(122, 38);
            this.themBtn.TabIndex = 6;
            this.themBtn.Text = "Thêm";
            this.themBtn.UseVisualStyleBackColor = false;
            this.themBtn.Click += new System.EventHandler(this.themBtn_Click);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(32, 422);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(982, 299);
            this.dataView.TabIndex = 52;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(534, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Tìm kiếm theo chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Tìm kiếm theo tên";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(892, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 25);
            this.label13.TabIndex = 44;
            this.label13.Text = "Ảnh thẻ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mã tài khoản";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(892, 292);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(122, 30);
            this.textBox13.TabIndex = 38;
            this.textBox13.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(191, 292);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(438, 30);
            this.textBox5.TabIndex = 5;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(736, 357);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(278, 27);
            this.textBox9.TabIndex = 12;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(191, 357);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(304, 27);
            this.textBox8.TabIndex = 11;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(191, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(438, 30);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(191, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(438, 30);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(191, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 30);
            this.textBox1.TabIndex = 1;
            // 
            // chucVuBox
            // 
            this.chucVuBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chucVuBox.FormattingEnabled = true;
            this.chucVuBox.Items.AddRange(new object[] {
            "Quản trị viên",
            "Nhân viên"});
            this.chucVuBox.Location = new System.Drawing.Point(191, 223);
            this.chucVuBox.Name = "chucVuBox";
            this.chucVuBox.Size = new System.Drawing.Size(438, 33);
            this.chucVuBox.TabIndex = 59;
            // 
            // FormQL_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 751);
            this.Controls.Add(this.chucVuBox);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.quayLaiBtn);
            this.Controls.Add(this.suaBtn);
            this.Controls.Add(this.xoaBtn);
            this.Controls.Add(this.themAnhBtn);
            this.Controls.Add(this.themBtn);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormQL_TaiKhoan";
            this.Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button quayLaiBtn;
        private System.Windows.Forms.Button suaBtn;
        private System.Windows.Forms.Button xoaBtn;
        private System.Windows.Forms.Button themAnhBtn;
        private System.Windows.Forms.Button themBtn;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox chucVuBox;
    }
}

