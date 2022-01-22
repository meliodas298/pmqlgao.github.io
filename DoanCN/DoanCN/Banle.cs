using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoanCN
{
    public partial class Banle : Form
    {
        database db = new database("localhost", "QLGAO");

        public Banle()
        {
            InitializeComponent();
        }

        private void Banle_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            DataTable dt1 = db.ExcuteQuery("select MaSP,TenSP from SANPHAM");
            cbbsp.DataSource = dt1;
            cbbsp.DisplayMember = "TenSP";
            cbbsp.ValueMember = "MaSP";
            DataTable dt = db.ExcuteQuery("select*from TTSANPHAM('" + cbbsp.SelectedValue.ToString() + "')");
            if (cbbsp.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string anh = cbbsp.SelectedValue.ToString().Substring(3, 3);
                txttonkho.Text = dt.Rows[0][2].ToString();
                txtdonvi.Text = "Đơn vị: " + dt.Rows[0][1].ToString() + "Kg";
                txtgia.Text = dt.Rows[0][0].ToString();

                ptanh.Image = Image.FromFile("anh/" + anh + ".jpg");
                ptanh.SizeMode = PictureBoxSizeMode.Zoom;
            }
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            a.BackColor = System.Drawing.Color.Transparent;
            txtdonvi.BackColor = System.Drawing.Color.Transparent;
            
        }

        private void cbbsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = db.ExcuteQuery("select*from TTSANPHAM('" + cbbsp.SelectedValue.ToString() + "')");
            if (cbbsp.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string anh = cbbsp.SelectedValue.ToString().Substring(3, 3);
                txttonkho.Text = dt.Rows[0][2].ToString();
                txtdonvi.Text = "Đơn vị: " + dt.Rows[0][1].ToString() + "Kg";
                txtgia.Text = dt.Rows[0][0].ToString();
                
                ptanh.Image = Image.FromFile("anh/"+anh+".jpg");
                ptanh.SizeMode = PictureBoxSizeMode.Zoom;
            }
            soluong.Value = 0;
            txttong.Text = "0";
        }

        private void soluong_ValueChanged(object sender, EventArgs e)
        {
            int sl = (int)soluong.Value;
            int tong = int.Parse(txtgia.Text);
            tong = tong * sl;
            txttong.Text = tong.ToString();
        }

        private void btthanhtoan_Click(object sender, EventArgs e)
        {
            DataTable dt = db.ExcuteQuery("select top 1(MaHD) from HOADON where MaHD like 'BL%' order by MaHD desc");
            string ma = int.Parse(dt.Rows[0][0].ToString().Substring(2))+1+"";
            DateTime date = DateTime.Now;
            ma = "BL" + ma.PadLeft(4, '0');
            string a = txtdonvi.Text.Substring(8,5);

            db.ExcuteNonQuery("THEMHOADON '"+ma+"', N'','"+MANV.manv+"','"+date.Date+"',"+txttong.Text+",'"+ cbbsp.SelectedValue.ToString() + "',"+(int)soluong.Value+",'"+a+"'");

            MessageBox.Show("Mã hóa đơn: "+ma+ "\nSản Phẩm: "+cbbsp.Text +"_"+ cbbsp.SelectedValue.ToString() + "\nSố lượng: "+ (int)soluong.Value + "\nTổng tiền: "+ txttong.Text);
        }

       

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
