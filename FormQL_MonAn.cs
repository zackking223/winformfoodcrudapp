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
    public partial class FormQL_MonAn : Form
    {
        ProcessDataBase processDB = new ProcessDataBase();
        string tenTable = "MonAn";
        string tenCotID = "maMA";
        public FormQL_MonAn()
        {
            InitializeComponent();
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.Image = imageBox.InitialImage;
            getData();
            getNVL();
        }

        private void getData()
        {
            DataTable table = processDB.DocBang("SELECT * FROM MonAn;");
            dataView.DataSource = table;
            dataView.Columns[0].HeaderText = "Mã";
            dataView.Columns[1].HeaderText = "Tên";
            dataView.Columns[2].HeaderText = "Ảnh";
            dataView.Columns[3].HeaderText = "Giá / g";
            dataView.Columns[3].HeaderText = "Số lượng";

            table.Dispose();
        }

        private void getThanhPhan()
        {
            if (textBox1.Text.Trim() != "")
            {
                DataTable table = processDB.DocBang($"SELECT NguyenVatLieu.maNVL, NguyenVatLieu.ten, NguyenVatLieu.gia, ThanhPhan.trongLuong from ThanhPhan INNER JOIN NguyenVatLieu On ThanhPhan.maNVL = NguyenVatLieu.maNVL WHERE ThanhPhan.maMA = N'{textBox1.Text.Trim()}';");
                dsThanhPhan.DataSource = table;
                dsThanhPhan.Columns[0].HeaderText = "Mã";
                dsThanhPhan.Columns[1].HeaderText = "Tên";
                dsThanhPhan.Columns[2].HeaderText = "Giá / g";
                dsThanhPhan.Columns[3].HeaderText = "Trọng lượng (g)";
                table.Dispose();
            }
        }

        private void getNVL(string sqlQuery = "SELECT maNVL, ten, gia, trongLuong from NguyenVatLieu;")
        {
            DataTable table = processDB.DocBang(sqlQuery);
            dsNVL.DataSource = table;
            dsNVL.Columns[0].HeaderText = "Mã";
            dsNVL.Columns[1].HeaderText = "Tên";
            dsNVL.Columns[2].HeaderText = "Giá / g";
            dsNVL.Columns[3].HeaderText = "Trọng lượng (g)";
            table.Dispose();
        }

        private bool CheckValidate()
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return false;
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return false;
            }
            else if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập giá món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return false;
            }
            else if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return false;
            }
            else if (textBox13.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải thêm ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                themAnhBtn.Focus();
                return false;
            }

            return true;
        }


        private void themBtn_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            if (CheckValidate())
            {
                if (processDB.KiemTraLap(tenTable, textBox1.Text.Trim(), tenCotID))
                {
                    MessageBox.Show("Trùng mã: \"" + textBox1.Text.Trim() + "\"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                else
                {
                    processDB.CapNhatDuLieu($"Insert into {tenTable} values (N'{textBox1.Text.Trim()}',N'{textBox2.Text.Trim()}',N'{textBox13.Text.Trim()}',{textBox3.Text.Trim()},N'{textBox4.Text.Trim()}')");
                    getData();
                }
            }
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            if (CheckValidate())
            {
                if (processDB.KiemTraLap(tenTable, textBox1.Text.Trim(), tenCotID))
                {
                    processDB.CapNhatDuLieu($"Update {tenTable} SET ten=N'{textBox2.Text.Trim()}', anh=N'{textBox13.Text.Trim()}', gia={textBox3.Text.Trim()}, soLuong=N'{textBox4.Text.Trim()}' WHERE {tenCotID} = N'{textBox1.Text.Trim()}';");
                    getData();
                } else
                {
                    MessageBox.Show("Mã món ăn không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                }
            }
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else
            {
                if (processDB.KiemTraLap(tenTable, textBox1.Text.Trim(), tenCotID))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa món ăn mã: \"" + textBox1.Text.Trim() + "\" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                        processDB.CapNhatDuLieu($"Delete from {tenTable} where {tenCotID} =N'{textBox1.Text.Trim()}'");
                    getData();
                }
                else
                {
                    MessageBox.Show("Mã món ăn không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                }
            }
        }

        private void quayLaiBtn_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            this.Hide();
            TaiKhoan nv = processDB.LayThongTin(TaiKhoan.maTK);
            var form2 = new FormTrungTam(nv.Anh, nv.ChucVu, nv.Ten);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Text = dataView.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataView.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataView.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataView.CurrentRow.Cells[4].Value.ToString();

            textBox13.Text = dataView.CurrentRow.Cells[2].Value.ToString(); //Picture
            if (textBox13.Text.Trim() != "")
                imageBox.Image = Image.FromFile(textBox13.Text.Replace(@"/", @"//"));
            getThanhPhan();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            DataTable table = processDB.DocBang($"SELECT * FROM {tenTable} WHERE ten LIKE N'%{textBox9.Text.Trim()}%';");
            dataView.DataSource = table;
            dataView.Columns[0].HeaderText = "Mã";
            dataView.Columns[1].HeaderText = "Tên";
            dataView.Columns[2].HeaderText = "Ảnh";
            dataView.Columns[3].HeaderText = "Giá / g";
            dataView.Columns[3].HeaderText = "Số lượng";

            table.Dispose();
        }

        private void productsFilter_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            DataTable table = processDB.DocBang($"SELECT maNVL, ten, gia, trongLuong from NguyenVatLieu WHERE ten LIKE N'%{ingFilter.Text.Trim()}%';");
            dsNVL.DataSource = table;
            dsNVL.Columns[0].HeaderText = "Mã";
            dsNVL.Columns[1].HeaderText = "Tên";
            dsNVL.Columns[2].HeaderText = "Giá / g";
            dsNVL.Columns[3].HeaderText = "Trọng lượng (g)";
            table.Dispose();
        }

        private void productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CheckValidate())
            {
                textBox1.Enabled = false;
                string id = (string)dsNVL.CurrentRow.Cells[0].Value;
                int trongLuong = (int)dsNVL.CurrentRow.Cells[3].Value;
                int gia = (int)dsNVL.CurrentRow.Cells[2].Value;

                //Kiem tra con trong kho ko
                if (trongLuong > 0)
                {
                    //Tru` so luong sp
                    processDB.CapNhatDuLieu($"UPDATE NguyenVatLieu SET trongLuong = trongLuong - 1 WHERE maNVL = N'{id.Trim()}';");
                    //Kiem tra xem gio hang da co chua
                    if (!processDB.KiemTraLap("ThanhPhan", id.Trim(), textBox1.Text.Trim(), "maNVL", "maMA"))
                    {
                        //Chua co thi them ten san pham, so luong
                        processDB.CapNhatDuLieu($"INSERT INTO ThanhPhan (maNVL, maMA, trongLuong) VALUES (N'{id.Trim()}',N'{textBox1.Text.Trim()}',N'1')");
                        getThanhPhan();
                    }
                    else
                    {
                        //Co roi thi +1 so luong
                        processDB.CapNhatDuLieu($"UPDATE ThanhPhan SET trongLuong = trongLuong + 1 WHERE maNVL = N'{id.Trim()}' and maMA = N'{textBox1.Text.Trim()}';");
                        getThanhPhan();
                    }
                    ChinhGia();
                    getNVL();
                }
            }
        }

        private void ChinhGia()
        {
            int tong = 0;
            foreach (DataGridViewRow row in dsThanhPhan.Rows)
            {
                tong += (int)row.Cells[2].Value * (int)row.Cells[3].Value;
            }
            processDB.CapNhatDuLieu($"UPDATE {tenTable} SET gia=N'{tong}' WHERE {tenCotID} = N'{textBox1.Text.Trim()}';");
            textBox3.Text = tong.ToString();
        }

        private void dsThanhPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CheckValidate())
            {
                textBox1.Enabled = false;
                string id = (string)dsThanhPhan.CurrentRow.Cells[0].Value;
                processDB.CapNhatDuLieu($"UPDATE NguyenVatLieu SET trongLuong = trongLuong + 1 WHERE maNVL = N'{id.Trim()}';");
                getNVL();
                if ((int)dsThanhPhan.CurrentRow.Cells[3].Value <= 1)
                {
                    processDB.CapNhatDuLieu($"DELETE FROM ThanhPhan WHERE maNVL = N'{id.Trim()}' and maMA = N'{textBox1.Text.Trim()}';");
                }
                else
                {
                    processDB.CapNhatDuLieu($"UPDATE ThanhPhan SET trongLuong = trongLuong - 1 WHERE maNVL = N'{id.Trim()}' and maMA = N'{textBox1.Text.Trim()}';");
                }
                ChinhGia();
                getThanhPhan();
            }
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

        private void cartFilter_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                DataTable table = processDB.DocBang($"SELECT NguyenVatLieu.maNVL, NguyenVatLieu.ten, NguyenVatLieu.gia, ThanhPhan.trongLuong from ThanhPhan INNER JOIN NguyenVatLieu On ThanhPhan.maNVL = NguyenVatLieu.maNVL WHERE ThanhPhan.maMA = N'{textBox1.Text.Trim()}' AND NguyenVatLieu.ten LIKE N'%{cartFilter.Text.Trim()}%';");
                dsThanhPhan.DataSource = table;
                dsThanhPhan.Columns[0].HeaderText = "Mã";
                dsThanhPhan.Columns[1].HeaderText = "Tên";
                dsThanhPhan.Columns[2].HeaderText = "Giá / g";
                dsThanhPhan.Columns[3].HeaderText = "Trọng lượng (g)";
                table.Dispose();
            }
        }
    }
}
