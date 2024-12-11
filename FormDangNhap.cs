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
    public partial class FormDangNhap : Form
    {
        ProcessDataBase processDB = new ProcessDataBase();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void thoatBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dangNhapBtn_Click()
        {
            if (processDB.XacThuc(tenDangNhap.Text.Trim(), matKhau.Text.Trim()))
            {
                this.Hide();
                TaiKhoan user = processDB.LayThongTin(tenDangNhap.Text.Trim());

                var form2 = new FormTrungTam(user.Anh, user.ChucVu, user.Ten);

                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Sai email hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dangNhapBtn_Click(object sender, EventArgs e)
        {
            if (processDB.XacThuc(tenDangNhap.Text.Trim(), matKhau.Text.Trim()))
            {
                this.Hide();
                TaiKhoan user = processDB.LayThongTin(tenDangNhap.Text.Trim());

                var form2 = new FormTrungTam(user.Anh, user.ChucVu, user.Ten);

                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Sai email hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangNhapBtn_Click();
            }
        }

        private void matKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangNhapBtn_Click();
            }
        }

        private void tenDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangNhapBtn_Click();
            }
        }
    }
}

