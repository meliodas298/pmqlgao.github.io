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
    public partial class XuatKho : Form
    {
        database db = new database("localhost", "QLGAO");
        public XuatKho()
        {
            InitializeComponent();
        }

        private void XuatKho_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            if (MAXK.maxk==null)
            {
                DataTable dt = db.ExcuteQuery("select top 1(MaHD) from HOADON where MaHD like 'XK%' order by MaHD desc");
            string ma = int.Parse(dt.Rows[0][0].ToString().Substring(2)) + 1 + "";
            ma = "XK" + ma.PadLeft(4, '0');
            txtmahd.Text = ma.ToString();
            MAXK.maxk = ma;
            }
            else
            {
                DataTable dt = db.ExcuteQuery("select top 1(MaHD),TenKH,TongTien,NVVC from HOADON H,NHANVIEN N where H.MaNV=N.MaNV and MaHD like 'XK%' order by MaHD desc");
                txtmahd.Text = dt.Rows[0][0].ToString();
                txttenkh.Text = dt.Rows[0][1].ToString();
                int tong = int.Parse(dt.Rows[0][2].ToString());
                txttong.Text = string.Format("{0:n0}", tong);
                txtnv.Text = dt.Rows[0][3].ToString();
                MAXK.maxk = txtmahd.Text;
            }
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            a.BackColor = System.Drawing.Color.Transparent;
        }

        private void btthemsanpham_Click(object sender, EventArgs e)
        {
            MAXK.maxk = txtmahd.Text;
            MAXK.tenkh = txttenkh.Text;
            MAXK.tennvvc = txtnv.Text;
            Chonsanpham csp = new Chonsanpham();       
            this.Hide();
            csp.ShowDialog();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = db.ExcuteQuery("select top 1(MaHD),TenKH,HoTen,NgayXuat,TongTien,NVVC from HOADON H,NHANVIEN N where H.MaNV=N.MaNV and MaHD like 'XK%' order by MaHD desc");
            if (dt.Rows[0][0].ToString() == txtmahd.Text)
            {
                string str = "Mã hóa đơn: " + dt.Rows[0][0].ToString() + "\nTên khách hàng: " + dt.Rows[0][1].ToString() + "\nTên nhân viên: "
                 + dt.Rows[0][2].ToString() + "\nNgày xuất: " + dt.Rows[0][3].ToString() + "\nTổng Cộng: " + dt.Rows[0][4].ToString()
                 + " đồng\nNhân viên vận chuyển: " + dt.Rows[0][5].ToString();
                MessageBox.Show(str);
            }
            else
                MessageBox.Show("Chưa nhập hóa đơn này");
        }

        private void btin_Click(object sender, EventArgs e)
        {
            DataTable dt = db.ExcuteQuery("select top 1(MaHD),TenKH,HoTen,NgayXuat,TongTien,NVVC from HOADON H,NHANVIEN N where H.MaNV=N.MaNV and MaHD like 'XK%' order by MaHD desc");
            if (dt.Rows[0][0].ToString() == txtmahd.Text)
            {
                RP_XuatKhau rp = new RP_XuatKhau();
                rp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa nhập hóa đơn");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MAXK.maxk = null;
            this.Hide();
        }
    }
}
