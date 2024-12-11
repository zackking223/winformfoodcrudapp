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
    public partial class FormQL_TaiKhoan : Form
    {
        ProcessDataBase processDB = new ProcessDataBase();
        string tenTable = "TaiKhoan";
        string tenCotID = "maTK";
        public FormQL_TaiKhoan()
        {
            InitializeComponent();
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.Image = imageBox.InitialImage;
            getData();
        }

        private void getData()
        {
            DataTable table = processDB.DocBang("Select * from " + tenTable);
            dataView.DataSource = table;
            dataView.Columns[0].HeaderText = "Mã tài khoản";
            dataView.Columns[1].HeaderText = "Tên đăng nhập";
            dataView.Columns[2].HeaderText = "Mật khẩu (mã hóa)";
            dataView.Columns[3].HeaderText = "Chức vụ";
            dataView.Columns[4].HeaderText = "Họ và tên";
            dataView.Columns[5].HeaderText = "Ảnh";

            table.Dispose();
        }

        private bool CheckValidate()
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return false;
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return false;
            }
            else if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return false;
            }
            else if (chucVuBox.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chucVuBox.Focus();
                return false;
            }
            else if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập họ và tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return false;
            }
            else if (textBox13.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải chọn ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                themAnhBtn.Focus();
                return false;
            }
            return true;
        }


        private void themBtn_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                if (processDB.KiemTraLap(tenTable, textBox1.Text.Trim(), tenCotID))
                {
                    MessageBox.Show("Trùng mã: \"" + textBox1.Text.Trim() + "\"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                else if (processDB.KiemTraLap(tenTable, textBox2.Text.Trim(), "tenDangNhap"))
                {
                    MessageBox.Show("Tên đăng nhập đã bị lấy: \"" + textBox2.Text.Trim() + "\"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                else
                {
                    processDB.CapNhatDuLieu($"Insert into {tenTable} values (N'{textBox1.Text.Trim()}',N'{textBox2.Text.Trim()}',N'{MaHoaMatKhau(textBox3.Text.Trim())}',N'{chucVuBox.Text.Trim()}',N'{textBox5.Text.Trim()}',N'{textBox13.Text.Trim()}');");
                    getData();
                }
            }
        }

        public static string MaHoaMatKhau(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                if (processDB.KiemTraLap(tenTable, textBox1.Text.Trim(), tenCotID))
                {
                    processDB.CapNhatDuLieu($"Update {tenTable} SET tenDangNhap=N'{textBox2.Text.Trim()}', matKhau=N'{MaHoaMatKhau(textBox3.Text.Trim())}', chucVu=N'{chucVuBox.Text.Trim()}', ten=N'{textBox5.Text.Trim()}', anh=N'{textBox13.Text.Trim()}' WHERE {tenCotID} = N'{textBox1.Text.Trim()}';");
                    getData();
                } else
                {
                    MessageBox.Show("Mã tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                }
            }
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else
            {
                if (processDB.KiemTraLap(tenTable, textBox1.Text.Trim(), tenCotID))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa tài khoản: \"" + textBox1.Text.Trim() + "\" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                        processDB.CapNhatDuLieu($"Delete from {tenTable} where {tenCotID} =N'{textBox1.Text.Trim()}'");
                    getData();
                } else
                {
                    MessageBox.Show("Mã tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                }
            }
        }

        private void quayLaiBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaiKhoan nv = processDB.LayThongTin(TaiKhoan.maTK);
            var form2 = new FormTrungTam(nv.Anh, nv.ChucVu, nv.Ten);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataView.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataView.CurrentRow.Cells[1].Value.ToString();
            //textBox3.Text = dataView.CurrentRow.Cells[2].Value.ToString();
            chucVuBox.Text = dataView.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataView.CurrentRow.Cells[4].Value.ToString();

            textBox13.Text = dataView.CurrentRow.Cells[5].Value.ToString(); //Picture
            if (textBox13.Text.Trim() != "")
                imageBox.Image = Image.FromFile(textBox13.Text.Replace(@"/", @"//"));
        }

        private void themAnhBtn_Click(object sender, EventArgs e)
        {
            //c# open file dialog with image filters
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //c# display image in picture box 
                    imageBox.Image = new Bitmap(ofd.FileName);
                    //c# image file path 
                    textBox13.Text = ofd.FileName;
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            DataTable table = processDB.DocBang($"Select * from {tenTable} where ten LIKE N'%{textBox8.Text.Trim()}%'");
            dataView.DataSource = table;
            dataView.Columns[0].HeaderText = "Mã tài khoản";
            dataView.Columns[1].HeaderText = "Tên đăng nhập";
            dataView.Columns[2].HeaderText = "Mật khẩu (mã hóa)";
            dataView.Columns[3].HeaderText = "Chức vụ";
            dataView.Columns[4].HeaderText = "Họ và tên";
            dataView.Columns[5].HeaderText = "Ảnh";

            table.Dispose();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            DataTable table = processDB.DocBang($"Select * from {tenTable} where chucVu LIKE N'%{textBox9.Text.Trim()}%'");
            dataView.DataSource = table;
            dataView.Columns[0].HeaderText = "Mã tài khoản";
            dataView.Columns[1].HeaderText = "Tên đăng nhập";
            dataView.Columns[2].HeaderText = "Mật khẩu (mã hóa)";
            dataView.Columns[3].HeaderText = "Chức vụ";
            dataView.Columns[4].HeaderText = "Họ và tên";
            dataView.Columns[5].HeaderText = "Ảnh";

            table.Dispose();
        }
    }
}
