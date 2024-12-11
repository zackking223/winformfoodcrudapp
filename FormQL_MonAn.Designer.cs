
namespace QL_NVL_MonAn
{
    partial class FormQL_MonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQL_MonAn));
            this.dsThanhPhan = new System.Windows.Forms.DataGridView();
            this.dsNVL = new System.Windows.Forms.DataGridView();
            this.quayLaiBtn = new System.Windows.Forms.Button();
            this.suaBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            this.themBtn = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ingFilter = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.themAnhBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.cartFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsThanhPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNVL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dsThanhPhan
            // 
            this.dsThanhPhan.AllowUserToAddRows = false;
            this.dsThanhPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsThanhPhan.Location = new System.Drawing.Point(26, 382);
            this.dsThanhPhan.Name = "dsThanhPhan";
            this.dsThanhPhan.RowHeadersVisible = false;
            this.dsThanhPhan.RowHeadersWidth = 51;
            this.dsThanhPhan.RowTemplate.Height = 24;
            this.dsThanhPhan.Size = new System.Drawing.Size(520, 188);
            this.dsThanhPhan.TabIndex = 86;
            this.dsThanhPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsThanhPhan_CellContentClick);
            this.dsThanhPhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsThanhPhan_CellContentClick);
            // 
            // dsNVL
            // 
            this.dsNVL.AllowUserToAddRows = false;
            this.dsNVL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsNVL.Location = new System.Drawing.Point(594, 382);
            this.dsNVL.Name = "dsNVL";
            this.dsNVL.RowHeadersVisible = false;
            this.dsNVL.RowHeadersWidth = 51;
            this.dsNVL.RowTemplate.Height = 24;
            this.dsNVL.Size = new System.Drawing.Size(520, 188);
            this.dsNVL.TabIndex = 85;
            this.dsNVL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productList_CellContentClick);
            this.dsNVL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productList_CellContentClick);
            // 
            // quayLaiBtn
            // 
            this.quayLaiBtn.Location = new System.Drawing.Point(886, 89);
            this.quayLaiBtn.Name = "quayLaiBtn";
            this.quayLaiBtn.Size = new System.Drawing.Size(122, 38);
            this.quayLaiBtn.TabIndex = 72;
            this.quayLaiBtn.Text = "Quay lại";
            this.quayLaiBtn.UseVisualStyleBackColor = true;
            this.quayLaiBtn.Click += new System.EventHandler(this.quayLaiBtn_Click);
            // 
            // suaBtn
            // 
            this.suaBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.suaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.suaBtn.Location = new System.Drawing.Point(886, 23);
            this.suaBtn.Name = "suaBtn";
            this.suaBtn.Size = new System.Drawing.Size(122, 38);
            this.suaBtn.TabIndex = 70;
            this.suaBtn.Text = "Sửa";
            this.suaBtn.UseVisualStyleBackColor = false;
            this.suaBtn.Click += new System.EventHandler(this.suaBtn_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.BackColor = System.Drawing.Color.DarkRed;
            this.xoaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.xoaBtn.Location = new System.Drawing.Point(730, 89);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(122, 38);
            this.xoaBtn.TabIndex = 71;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.UseVisualStyleBackColor = false;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // themBtn
            // 
            this.themBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.themBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.themBtn.Location = new System.Drawing.Point(730, 23);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(122, 38);
            this.themBtn.TabIndex = 69;
            this.themBtn.Text = "Thêm";
            this.themBtn.UseVisualStyleBackColor = false;
            this.themBtn.Click += new System.EventHandler(this.themBtn_Click);
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(25, 644);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(1089, 299);
            this.dataView.TabIndex = 84;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 605);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 82;
            this.label9.Text = "Tìm kiếm theo tên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(802, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 80;
            this.label10.Text = "Lọc tên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(589, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 25);
            this.label8.TabIndex = 81;
            this.label8.Text = "Danh sách vật liệu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 79;
            this.label7.Text = "Thành phần";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 83;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 75;
            this.label2.Text = "Tên món ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Mã món ăn";
            // 
            // ingFilter
            // 
            this.ingFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingFilter.Location = new System.Drawing.Point(892, 338);
            this.ingFilter.Name = "ingFilter";
            this.ingFilter.Size = new System.Drawing.Size(222, 27);
            this.ingFilter.TabIndex = 68;
            this.ingFilter.TextChanged += new System.EventHandler(this.productsFilter_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(185, 602);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(520, 27);
            this.textBox9.TabIndex = 67;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(185, 221);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(438, 30);
            this.textBox4.TabIndex = 64;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(185, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(438, 30);
            this.textBox2.TabIndex = 62;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(185, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 30);
            this.textBox1.TabIndex = 61;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(185, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(438, 30);
            this.textBox3.TabIndex = 87;
            this.textBox3.Text = "0";
            // 
            // imageBox
            // 
            this.imageBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageBox.InitialImage")));
            this.imageBox.Location = new System.Drawing.Point(730, 159);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(150, 150);
            this.imageBox.TabIndex = 91;
            this.imageBox.TabStop = false;
            // 
            // themAnhBtn
            // 
            this.themAnhBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.themAnhBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.themAnhBtn.Location = new System.Drawing.Point(886, 187);
            this.themAnhBtn.Name = "themAnhBtn";
            this.themAnhBtn.Size = new System.Drawing.Size(122, 38);
            this.themAnhBtn.TabIndex = 88;
            this.themAnhBtn.Text = "Ảnh mới";
            this.themAnhBtn.UseVisualStyleBackColor = false;
            this.themAnhBtn.Click += new System.EventHandler(this.themAnhBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(886, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 25);
            this.label13.TabIndex = 90;
            this.label13.Text = "Ảnh món ăn";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(886, 279);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(122, 30);
            this.textBox13.TabIndex = 89;
            this.textBox13.Visible = false;
            // 
            // cartFilter
            // 
            this.cartFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartFilter.Location = new System.Drawing.Point(324, 341);
            this.cartFilter.Name = "cartFilter";
            this.cartFilter.Size = new System.Drawing.Size(222, 27);
            this.cartFilter.TabIndex = 68;
            this.cartFilter.TextChanged += new System.EventHandler(this.cartFilter_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Lọc tên:";
            // 
            // FormQL_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 959);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.themAnhBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dsThanhPhan);
            this.Controls.Add(this.dsNVL);
            this.Controls.Add(this.quayLaiBtn);
            this.Controls.Add(this.suaBtn);
            this.Controls.Add(this.xoaBtn);
            this.Controls.Add(this.themBtn);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartFilter);
            this.Controls.Add(this.ingFilter);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormQL_MonAn";
            this.Text = "Món ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dsThanhPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNVL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dsThanhPhan;
        private System.Windows.Forms.DataGridView dsNVL;
        private System.Windows.Forms.Button quayLaiBtn;
        private System.Windows.Forms.Button suaBtn;
        private System.Windows.Forms.Button xoaBtn;
        private System.Windows.Forms.Button themBtn;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ingFilter;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button themAnhBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox cartFilter;
        private System.Windows.Forms.Label label5;
    }
}