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
    public partial class Chonsanphamnhap : Form
    {
        database db = new database("localhost", "QLGAO");
        public int tong = 0;
        public Chonsanphamnhap()
        {
            InitializeComponent();
        }

        private void txtgia_TextChanged(object sender, EventArgs e)
        {
            txtgia2.Text = "";
        }

        private void txtgia2_TextChanged(object sender, EventArgs e)
        {
            txtgia.Text = "";
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtgia2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnhap_Click(object sender, EventArgs e)
        {
            
            if (txtsl.Text != "" )
            {
                int rowId = dgvds.Rows.Add();
                DataGridViewRow row = dgvds.Rows[rowId];
                row.Cells[0].Value = cbbmasp.SelectedValue.ToString();
                row.Cells[1].Value = txtsl.Text;
                if (txtgia.Text != "")
                    row.Cells[2].Value = (int.Parse(txtsl.Text) * int.Parse(txtgia.Text)).ToString();
                else if (txtgia2.Text != "")
                    row.Cells[2].Value = (int.Parse(txtsl.Text) * int.Parse(txtdongia.Text) * int.Parse(txtgia2.Text)/100).ToString();
                else
                    MessageBox.Show("Chưa có giá nhập kho");
                row.Cells[3].Value = txtdonvi.Text;
                tong += int.Parse(row.Cells[2].Value.ToString());
                txttong.Text = string.Format("{0:n0}", tong);
                txtgia.Text = "";
                txtgia2.Text = "";
                txtsl.Text = "0";
            }
            else
                MessageBox.Show("Chưa nhập số lượng");
            dgvds.DefaultCellStyle.ForeColor = Color.Blue;

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            tong = 0;
            foreach (DataGridViewCell oneCell in dgvds.SelectedCells)
            {
                if (oneCell.Selected)
                    dgvds.Rows.RemoveAt(oneCell.RowIndex);                    
            };
            for (int i = 0; i < dgvds.Rows.Count-1; i++)
            {
                tong += int.Parse(dgvds.Rows[i].Cells[2].Value.ToString());
            }
            txttong.Text = string.Format("{0:n0}", tong);
        }

        private void bthoanthanh_Click(object sender, EventArgs e)
        {
            db.ExcuteNonQuery("THEMHOADONXuatNhap '" + MAXK.maxk + "', N'" + MAXK.tenkh + "', '" + MANV.manv + "' , '" + DateTime.Now.ToString() + "' ,  " + tong + "   , N'" + MAXK.tennvvc + "'");

            for (int i = 0; i < dgvds.Rows.Count - 1; i++)
            {
                db.ExcuteNonQuery("THEMCTHDNK '" + MAXK.maxk + "', '" + dgvds.Rows[i].Cells[0].Value.ToString() + "', " + dgvds.Rows[i].Cells[1].Value + ", '" + dgvds.Rows[i].Cells[3].Value.ToString() + "' , " + dgvds.Rows[i].Cells[2].Value);
            }

            MessageBox.Show("Thêm sản phẩm thành công");
            NhapKho nk = new NhapKho();
            this.Hide();
            nk.ShowDialog();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            NhapKho nk = new NhapKho();
            MAXK.maxk = null;
            this.Hide();
            nk.ShowDialog();
        }

        private void Chonsanphamnhap_Load(object sender, EventArgs e)
        {

            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            cbbmasp.DataSource = db.ExcuteQuery("select MaSP from SANPHAM");
            cbbmasp.DisplayMember = "MaSP";
            cbbmasp.ValueMember = "MaSP";
            cbbtensp.DataSource = db.ExcuteQuery("select MaSP,TenSP from SANPHAM");
            cbbtensp.DisplayMember = "TenSP";
            cbbtensp.ValueMember = "MaSP";
            dgvds.RowHeadersVisible = false;
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            a.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            
        }

        private void cbbmasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = db.ExcuteQuery("select*from TTSANPHAM1('" + cbbmasp.SelectedValue.ToString() + "')");
            if (cbbmasp.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                txtdongia.Text = dt.Rows[0][2].ToString();
                cbbtensp.Text = dt.Rows[0][1].ToString();
                txtdonvi.Text = dt.Rows[0][3].ToString();
                txttonkho.Text = dt.Rows[0][4].ToString();
            }
            txtsl.Text = "";
            txtgia2.Text = "";
            txtgia.Text = "";
        }

        private void cbbtensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = db.ExcuteQuery("select*from TTSANPHAM1('" + cbbtensp.SelectedValue.ToString() + "')");
            if (cbbtensp.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                txtdongia.Text = dt.Rows[0][2].ToString();
                cbbmasp.Text = dt.Rows[0][0].ToString();
                txtdonvi.Text = dt.Rows[0][3].ToString();
                txttonkho.Text = dt.Rows[0][4].ToString();
            }
            txtsl.Text = "";
            txtgia2.Text = "";
            txtgia.Text = "";
        }

        private void a_Click(object sender, EventArgs e)
        {

        }
    }
}
