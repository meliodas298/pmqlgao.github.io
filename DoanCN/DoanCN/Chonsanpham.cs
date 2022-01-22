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
    public partial class Chonsanpham : Form
    {
        database db = new database("localhost", "QLGAO");
        int tong = 0;
      
        public Chonsanpham()
        {
            InitializeComponent();
        }

        

        private void btht_Click(object sender, EventArgs e)
        {

            db.ExcuteNonQuery("THEMHOADONXuatNhap '" + MAXK.maxk + "', N'" + MAXK.tenkh + "', '" + MANV.manv + "' , '" + DateTime.Now.ToString() + "' ,  " + tong + "   , N'" + MAXK.tennvvc + "'");

            for (int i = 0; i < dgvds.Rows.Count-1; i++)
            {
               db.ExcuteNonQuery("THEMCTHDXK '" + MAXK.maxk + "', '"+ dgvds.Rows[i].Cells[0].Value.ToString()+"', "+ dgvds.Rows[i].Cells[1].Value + ", '"+dgvds.Rows[i].Cells[3].Value.ToString()+"' , "+ dgvds.Rows[i].Cells[2].Value );
            }

            MessageBox.Show("Thêm sản phẩm thành công");
            XuatKho xk = new XuatKho();
            this.Hide();
            xk.ShowDialog();
        }

        private void Chonsanpham_Load(object sender, EventArgs e)
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

        private void btnhap_Click(object sender, EventArgs e)
        {
            if (txtsl.Text != "" && int.Parse(txtsl.Text) <= int.Parse(txttonkho.Text) ) 
            {
                int rowId = dgvds.Rows.Add();
                DataGridViewRow row = dgvds.Rows[rowId];
                row.Cells[0].Value = cbbmasp.SelectedValue.ToString();
                row.Cells[1].Value = txtsl.Text;
                row.Cells[2].Value = (int.Parse(txtsl.Text) * int.Parse(txtdongia.Text)).ToString();
                row.Cells[3].Value = txtdonvi.Text;
                tong += int.Parse(row.Cells[2].Value.ToString());
                txttong.Text = string.Format("{0:n0}", tong);
            }
            else
                MessageBox.Show("Số lượng hàng trong kho không đủ hoặc chưa nhập số lượng");
            dgvds.DefaultCellStyle.ForeColor = Color.Blue;
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
            txtsl.Text = "0";
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
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            tong = 0;
            foreach (DataGridViewCell oneCell in dgvds.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    dgvds.Rows.RemoveAt(oneCell.RowIndex);
                    for (int i = 0; i < dgvds.Rows.Count-1; i++)
                    {
                        tong += int.Parse(dgvds.Rows[i].Cells[2].Value.ToString());
                    }
                    txttong.Text = string.Format("{0:n0}", tong);
                }
            };
           
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            XuatKho xk = new XuatKho();
            MAXK.maxk = null;            
            this.Hide();
            xk.ShowDialog(); 
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
