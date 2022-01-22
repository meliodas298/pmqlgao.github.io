using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanCN
{
    public partial class Upnhanvien : Form
    {
        database db = new database("localhost", "QLGAO");
        int ghi = 0;
        public Upnhanvien()
        {
            InitializeComponent();
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            setButton(false);
            cbhoten.Enabled = false;
            txtma.Enabled = false;
            txtchucvu.Enabled = false;
            ghi = 0;
            
        }

        private void btghi_Click(object sender, EventArgs e)
        {
            
            if (ghi == 0)
            {
                db.ExcuteNonQuery("CAPNHATNV '" + txtma.Text + "', '" + datengaysinh.Value + "' , '" + txtsdt.Text + "', '" + txtcccd.Text + "' , N'" + txtquequan.Text + "' , '" + datengay.Value + "'");
                MessageBox.Show("Cập nhật nhân viên "+cbhoten.Text+" thành công");
                setButton(true);

            }
            else
            {
                db.ExcuteNonQuery("THEMNV '" + txtma.Text + "', N'"+cbhoten.Text+"' ,'" + datengaysinh.Value + "' , '" + txtsdt.Text + "', '" + txtcccd.Text + "' , N'" + txtquequan.Text + "' , '" + datengay.Value + "' , N'"+cbcv.Text+"','"+int.Parse(txtluong.Text)+"'");
                MessageBox.Show("Thêm nhân viên thành công");
                setButton(true);
                txtluong.Enabled = false;
            }

        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            setButton(true);
            cbhoten.Enabled = true;
            cbhoten.DataSource = db.ExcuteQuery("select * from dbo.TENNV(N'" + cbcv.Text + "')");
            cbhoten.DisplayMember = "HoTen";
            cbhoten.ValueMember = "MaNV";

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            setButton(false);
            DataTable dt = db.ExcuteQuery("select*from TANGMANHANVIEN(N'"+cbcv.SelectedValue+"')");
            string ma = int.Parse(dt.Rows[0][0].ToString().Substring(2)) + 1 + "";
            ma = "NV" + ma.PadLeft(3, '0');
            txtma.Text = ma;
            ghi = 1;
            cbhoten.Text = "";
            txtcccd.Text = "";
            txtluong.Text = "";
            txtsdt.Text = "";
            txtquequan.Text = "";
            txtluong.Enabled = true;
        }

        private void btdoimk_Click(object sender, EventArgs e)
        {
            QLDoiMatKhau dmk = new QLDoiMatKhau();
            dmk.ShowDialog();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (int.Parse(cbhoten.SelectedValue.ToString().Substring(2, 1)) != 2 || int.Parse(cbhoten.SelectedValue.ToString().Substring(2, 1)) != 3)
                {
                     db.ExcuteNonQuery("XOANV '" + cbhoten.SelectedValue + "'");
                     MessageBox.Show("Dã xóa thành công nhân viên: "+cbhoten.Text);
                     cbhoten.DataSource = db.ExcuteQuery("select * from dbo.TENNV(N'" + cbcv.Text + "')");
                     cbhoten.DisplayMember = "HoTen";
                     cbhoten.ValueMember = "MaNV";
                }
            else
                MessageBox.Show("Không được xóa thông tin kế toán hoặc quản lí");
           
        }



        private void cbcv_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbhoten.DataSource = db.ExcuteQuery("select * from dbo.TENNV(N'"+cbcv.Text+"')");
            cbhoten.DisplayMember = "HoTen";
            cbhoten.ValueMember = "MaNV";
        }

        private void cbhoten_SelectedIndexChanged(object sender, EventArgs e)
        {
 
                DataTable dt = db.ExcuteQuery("select * from dbo.THONGTINNV('"+cbhoten.SelectedValue.ToString()+"')");
                txtma.Text = dt.Rows[0][1].ToString();
                datengaysinh.Value = DateTime.Parse(dt.Rows[0][2].ToString());
                txtsdt.Text = dt.Rows[0][3].ToString();
                txtquequan.Text = dt.Rows[0][5].ToString(); 
                txtcccd.Text = dt.Rows[0][4].ToString();
                txtchucvu.Text = dt.Rows[0][6].ToString();
                datengay.Value = DateTime.Parse(dt.Rows[0][7].ToString());
        }
        private void Upnhanvien_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            cbcv.DataSource = db.ExcuteQuery("select*from dbo.CHUCVUNV()");
            cbcv.ValueMember = "ChucVu";
            cbcv.DisplayMember = "ChucVu";
            setButton(true);
            txtchucvu.Enabled = false;
            txtluong.Enabled = false;
            label9.BackColor = System.Drawing.Color.Transparent;
            label11.BackColor = System.Drawing.Color.Transparent;
            a.BackColor = System.Drawing.Color.Transparent;
            groupBox1.BackColor = System.Drawing.Color.Transparent;
          
        }
        void setButton(bool a)
        {
            btghi.Enabled = !a;
            bthuy.Enabled = !a;
            btthem.Enabled = a;
            btcapnhat.Enabled = a;
            txtchucvu.Enabled = !a;
            txtma.Enabled = !a;
            cbcv.Enabled = a;
           

        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int MaxLength = 12;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtsdt.Text.Length > MaxLength)
                txtsdt.Text = txtsdt.Text.Substring(0, MaxLength);
        }

        private void txtcccd_KeyPress(object sender, KeyPressEventArgs e)
        {
            int MaxLength = 12;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtcccd.Text.Length > MaxLength)
                txtcccd.Text = txtcccd.Text.Substring(0, MaxLength);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            GDQuanLi gd = new GDQuanLi();
            this.Close();
        }
    }
}
