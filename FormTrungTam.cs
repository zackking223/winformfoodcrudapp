using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NVL_MonAn
{
    public partial class FormTrungTam : Form
    {
        string anhThe;
        string chucVu;
        string ten;
        public FormTrungTam(string anhThe, string chucVu, string ten)
        {
            this.anhThe = anhThe;
            this.chucVu = chucVu;
            this.ten = ten;
            InitializeComponent();
            avatarBox.SizeMode = PictureBoxSizeMode.StretchImage;
            if (this.anhThe != "")
            {
                avatarBox.Image = Image.FromFile(this.anhThe.Replace(@"/", @"//"));
            }
            else
            {
                avatarBox.Image = avatarBox.InitialImage;
            }
            if (this.ten != "") tenTK.Text = this.ten;
            if (this.chucVu != "") chucVuTK.Text = this.chucVu;
        }

        private void dangXuatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FormDangNhap();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void taiKhoanBtn_Click(object sender, EventArgs e)
        {
            if (chucVu == "Quản trị viên")
            {
                this.Hide();
                var form2 = new FormQL_TaiKhoan();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void monAnBtn_Click(object sender, EventArgs e)
        {
            if (chucVu == "Quản trị viên" || chucVu == "Nhân viên")
            {
                this.Hide();
                var form2 = new FormQL_MonAn();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nguyenLieuBtn_Click(object sender, EventArgs e)
        {
            if (chucVu == "Quản trị viên" || chucVu == "Nhân viên")
            {
                this.Hide();
                var form2 = new FormQL_NVL();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
