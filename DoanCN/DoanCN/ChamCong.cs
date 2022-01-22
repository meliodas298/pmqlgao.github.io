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
    public partial class ChamCong : Form
    {
        string manv="";
        DateTime date;
        database db = new database("localhost", "QLGAO");
        public ChamCong()
        {
            InitializeComponent();
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            cbcv.DataSource = db.ExcuteQuery("select*from dbo.CHUCVUNV()");
            cbcv.ValueMember = "ChucVu";
            cbcv.DisplayMember = "ChucVu";
            txtnhapung.Text = "0";
            txtnhapthuong.Text = "0";
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            a.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            dgvds.RowHeadersVisible = false;

        }

        private void cbcv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcv.Text != "System.Data.DataRowView")
            {
                dgvds.DataSource = db.ExcuteQuery("select*from TenNV(N'" + cbcv.Text + "')");
                txtten.Text = dgvds.Rows[0].Cells[0].Value.ToString();
                DataTable dt = db.ExcuteQuery("select*from XUATCHAMCONG('" + dgvds.Rows[0].Cells[1].Value.ToString() + "')");
                txtchamcong.Text = dt.Rows[0][0].ToString();
                txtungtruoc.Text = dt.Rows[0][1].ToString();
                txtluong.Text = dt.Rows[0][2].ToString();
                txtthuong.Text = dt.Rows[0][3].ToString();
                txttongluong.Text = dt.Rows[0][4].ToString();
                manv = dgvds.Rows[0].Cells[1].Value.ToString();
                date = DateTime.Parse(dt.Rows[0][5].ToString());
            }
        }

        private void dgvds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvds.Rows[e.RowIndex];
                string a = row.Cells[0].Value.ToString();
                if (a != "")
                {
                    txtten.Text = row.Cells[0].Value.ToString(); 
                    DataTable dt = db.ExcuteQuery("select*from XUATCHAMCONG('" + row.Cells[1].Value.ToString() + "')");
                    txtchamcong.Text = dt.Rows[0][0].ToString();
                    txtungtruoc.Text = dt.Rows[0][1].ToString();
                    txtluong.Text = dt.Rows[0][2].ToString();
                    txtthuong.Text = dt.Rows[0][3].ToString();
                    txttongluong.Text = dt.Rows[0][4].ToString();
                    manv = row.Cells[1].Value.ToString();
                    date = DateTime.Parse(dt.Rows[0][5].ToString());
                }
            }
            txtnhapthuong.Text = "0";
            txtnhapung.Text = "0";
        }

        private void btchamcong_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string a = (int.Parse(txtchamcong.Text) + 1).ToString();

            if (now.Date.ToShortDateString() != date.Date.ToShortDateString())
            {
                db.ExcuteNonQuery("PROCCHAMCONG '" + now.Date.ToShortDateString() + "','" + manv 
                    + "', " + a + ", " + int.Parse(txtluong.Text)
                    +", "+ int.Parse(txtthuong.Text) + ", "+ int.Parse(txtungtruoc.Text) 
                    + ", "+ int.Parse(txtluong.Text)* (int.Parse(txtchamcong.Text)+1));
                MessageBox.Show("Điểm danh thành công");
                dgvds.DataSource = db.ExcuteQuery("select*from TenNV(N'" + cbcv.Text + "')");
                txtten.Text = dgvds.Rows[0].Cells[0].Value.ToString();
                DataTable dt = db.ExcuteQuery("select*from XUATCHAMCONG('" + dgvds.Rows[0].Cells[1].Value.ToString() + "')");
                txtchamcong.Text = dt.Rows[0][0].ToString();
                txtungtruoc.Text = dt.Rows[0][1].ToString();
                txtluong.Text = dt.Rows[0][2].ToString();
                txtthuong.Text = dt.Rows[0][3].ToString();
                txttongluong.Text = dt.Rows[0][4].ToString();
                manv = dgvds.Rows[0].Cells[1].Value.ToString();
                date = DateTime.Parse(dt.Rows[0][5].ToString());
               

            }
            else
            {
                MessageBox.Show("Hôm nay đẫ chấm công nhân viên này");
            } 
        }

        private void btthuongung_Click(object sender, EventArgs e)
        {
            db.ExcuteNonQuery("NHAPUNGTHUONG '" + manv + "','" + date + "'," + int.Parse(txtnhapung.Text) + "," + int.Parse(txtnhapthuong.Text));
            MessageBox.Show("Cập nhật thành công");
            dgvds.DataSource = db.ExcuteQuery("select*from TenNV(N'" + cbcv.Text + "')");
            txtten.Text = dgvds.Rows[0].Cells[0].Value.ToString();
            DataTable dt = db.ExcuteQuery("select*from XUATCHAMCONG('" + dgvds.Rows[0].Cells[1].Value.ToString() + "')");
            txtchamcong.Text = dt.Rows[0][0].ToString();
            txtungtruoc.Text = dt.Rows[0][1].ToString();
            txtluong.Text = dt.Rows[0][2].ToString();
            txtthuong.Text = dt.Rows[0][3].ToString();
            txttongluong.Text = dt.Rows[0][4].ToString();
            manv = dgvds.Rows[0].Cells[1].Value.ToString();
            date = DateTime.Parse(dt.Rows[0][5].ToString());
            txtnhapung.Text = "0";
            txtnhapthuong.Text = "0";
        }

        private void txtnhapung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtnhapthuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn cập nhật lại Chấm công = 0 ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable dt = db.ExcuteQuery("select MaNV from NHANVIEN");
                for (int i = 0; i < dt.Rows.Count-1; i++)
                {
                    DataTable dt1 = db.ExcuteQuery("select*from NGAYCUOITHANG('" + dt.Rows[i][0].ToString() + "')");
                    db.ExcuteNonQuery("THANGMOI '" + dt.Rows[i][0].ToString() + "','" + dt1.Rows[0][0].ToString() + "'");
                }
                MessageBox.Show("Cập nhật chấm công thành công");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvds_DataSourceChanged(object sender, EventArgs e)
        {
            dgvds.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvds.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvds.DefaultCellStyle.ForeColor = Color.Blue;
        }
    }
}

