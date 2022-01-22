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
    public partial class Upsanpham : Form
    {
        database db = new database("localhost", "QLGAO");
        int button = 0;
        public Upsanpham()
        {
            InitializeComponent();
        }

        private void Upsanpham_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            dgvds.DataSource = db.ExcuteQuery("Select*from SANPHAM");
            txtma.Text = dgvds.Rows[0].Cells[0].Value.ToString();
            txtten.Text = dgvds.Rows[0].Cells[1].Value.ToString();
            txtdongia.Text = dgvds.Rows[0].Cells[2].Value.ToString();
            txtdonvi.Text = dgvds.Rows[0].Cells[3].Value.ToString();
            txttonkho.Text = dgvds.Rows[0].Cells[4].Value.ToString();
            setButton(true);
            setButton2(true);
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            a.BackColor = System.Drawing.Color.Transparent;
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            label8.BackColor = System.Drawing.Color.Transparent;
            label10.BackColor = System.Drawing.Color.Transparent;
            dgvds.RowHeadersVisible = false;
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

        private void txtgia2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Upsanpham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        void setButton(bool a)
        {
            btghi.Enabled = !a;
            bthuy.Enabled = !a;
            btthem.Enabled = a;
            btcapnhat.Enabled = a;
            
        }
        void setButton2(bool a)
        {           
            txtgia.Enabled = !a;
            txtgia2.Enabled = !a;
        }
        void setButton3(bool a)
        {
            txtdongia.Enabled = !a;
            txtdonvi.Enabled = !a;
            txtma.Enabled = !a;
            txtten.Enabled = !a;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            setButton(false);
            setButton3(false);
            button = 0;
            DataTable dt = db.ExcuteQuery("select top 1(MaSP) from SANPHAM order by MaSP desc");
            string ma = int.Parse(dt.Rows[0][0].ToString().Substring(2)) + 1 + "";
            ma = "NV" + ma.PadLeft(3, '0');
            txtma.Text = ma;
            txtdongia.Text = "";
            txtdonvi.Text = "";
            txttonkho.Text = "";
            txtten.Text = "";
            txtgia.Text = "0";
            txtgia2.Text = "0";
        }

        private void btghi_Click(object sender, EventArgs e)
        {
            
            if (button == 1)
                if ((txtgia.Text != "" && txtgia2.Text != "") || txttonkho.Text != "")
                    if (MessageBox.Show("Bạn đồng ý cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        if (txtgia.Text == "")
                         {                                            
                            int a = int.Parse(txtdongia.Text) * int.Parse(txtgia2.Text) / 100;
                            db.ExcuteNonQuery("CAPNHATSP '" + txtma.Text + "', " + a + ", " + int.Parse(txttonkho.Text));
                            MessageBox.Show("Cập nhật thành công");
                            txtgia.Text = "";
                            txtgia2.Text = "";
                            setButton(true);
                            setButton2(true);
                            setButton3(false);
                            dgvds.DataSource = db.ExcuteQuery("Select*from SANPHAM");
                            txtma.Text = dgvds.Rows[0].Cells[0].Value.ToString();
                            txtten.Text = dgvds.Rows[0].Cells[1].Value.ToString();
                            txtdongia.Text = dgvds.Rows[0].Cells[2].Value.ToString();
                            txtdonvi.Text = dgvds.Rows[0].Cells[3].Value.ToString();
                            txttonkho.Text = dgvds.Rows[0].Cells[4].Value.ToString();
                        }
                         else
                            {
                             db.ExcuteNonQuery("CAPNHATSP '" + txtma.Text + "', " + int.Parse(txtgia.Text) + ", " + int.Parse(txttonkho.Text));
                             MessageBox.Show("Cập nhật thành công");
                            txtgia.Text = "";
                            txtgia2.Text = "";
                            setButton(true);
                            setButton2(true);
                            setButton3(false);
                            dgvds.DataSource = db.ExcuteQuery("Select*from SANPHAM");
                            txtma.Text = dgvds.Rows[0].Cells[0].Value.ToString();
                            txtten.Text = dgvds.Rows[0].Cells[1].Value.ToString();
                            txtdongia.Text = dgvds.Rows[0].Cells[2].Value.ToString();
                            txtdonvi.Text = dgvds.Rows[0].Cells[3].Value.ToString();
                            txttonkho.Text = dgvds.Rows[0].Cells[4].Value.ToString();
                          }
                  else { }
                else
                 {
                    MessageBox.Show("Nhập không đủ thông tin(giá, số lượng)");
                 }
            else if (txtma.Text != "" && txtten.Text != "" && txtdonvi.Text != "" && txtdongia.Text != "" && txttonkho.Text != "")
            {
                if (MessageBox.Show("Bạn đồng ý thêm sản phẩm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.ExcuteNonQuery("THEMSP '" + txtma.Text + "' , N'" + txtten.Text + "', " + int.Parse(txtdongia.Text) + ", '" + txtdonvi.Text + "'," + int.Parse(txttonkho.Text));
                    MessageBox.Show("Thêm sản phẩm thành công");
                    setButton(true);
                    setButton2(true);
                    setButton3(false);
                    dgvds.DataSource = db.ExcuteQuery("Select*from SANPHAM");
                    txtma.Text = dgvds.Rows[0].Cells[0].Value.ToString();
                    txtten.Text = dgvds.Rows[0].Cells[1].Value.ToString();
                    txtdongia.Text = dgvds.Rows[0].Cells[2].Value.ToString();
                    txtdonvi.Text = dgvds.Rows[0].Cells[3].Value.ToString();
                    txttonkho.Text = dgvds.Rows[0].Cells[4].Value.ToString();
                }
            }
            else
                MessageBox.Show("Nhập không đủ thông tin( mã, tên, đơn vị, giá, số lượng)");

       
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            setButton(false);
            setButton2(false);
            setButton3(true);
            button = 1;
            txtgia.Text = "0";
            txtgia2.Text = "0";
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            setButton(true);
            setButton2(true);
            setButton3(false);
            dgvds.DataSource = db.ExcuteQuery("Select*from SANPHAM");
            txtma.Text = dgvds.Rows[0].Cells[0].Value.ToString();
            txtten.Text = dgvds.Rows[0].Cells[1].Value.ToString();
            txtdongia.Text = dgvds.Rows[0].Cells[2].Value.ToString();
            txtdonvi.Text = dgvds.Rows[0].Cells[3].Value.ToString();
            txttonkho.Text = dgvds.Rows[0].Cells[4].Value.ToString();
        }

      

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    

        private void txtgia_TextChanged(object sender, EventArgs e)
        {
            txtgia2.Text = "";
        }

        private void dgvds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                
                    DataGridViewRow row = this.dgvds.Rows[e.RowIndex];
                    string a = row.Cells[0].Value.ToString();
                    if (a != "")
                         { 
                    txtma.Text = row.Cells[0].Value.ToString();
                    txtten.Text = row.Cells[1].Value.ToString();
                    txtdongia.Text = row.Cells[2].Value.ToString();
                    txtdonvi.Text = row.Cells[3].Value.ToString();
                    txttonkho.Text = row.Cells[4].Value.ToString();
                         }
            }
            txtgia.Text = "";
            txtgia2.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvds_DataSourceChanged(object sender, EventArgs e)
        {
            dgvds.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvds.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvds.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvds.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvds.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvds.DefaultCellStyle.ForeColor = Color.Blue;
        }
    }
}
