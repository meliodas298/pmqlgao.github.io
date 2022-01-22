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
    public partial class GDQuanLi : Form
    {
        database db = new database("localhost", "QLGAO");
        public GDQuanLi()
        {
            InitializeComponent();
        }

        private void GDQuanLi_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            cbthang.Text = "1";
            cbnam.Text = "2021";
            for (int i = 1; i < 13; i++)
                cbthang.Items.Add(i);
            for (int i = 2021; i < 2026; i++)
                cbnam.Items.Add(i);
            cbnv.DataSource = db.ExcuteQuery("select MaNV,HoTen from NHANVIEN where ChucVu= N'Kế Toán'");
            cbnv.ValueMember = "MaNV";
            cbnv.DisplayMember = "HoTen";
            dgvds.RowHeadersVisible = false;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            a.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Upnhanvien nv = new Upnhanvien();
            nv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Upsanpham sp = new Upsanpham();
            sp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChamCong cc = new ChamCong();
            cc.ShowDialog();
        }

        private void cbnv_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cbnv.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                dgvds.DataSource = db.ExcuteQuery("select*from XUATHOADONTHEONV('"+ cbnv.SelectedValue.ToString() 
                    + "',"+cbthang.Text+","+cbnam.Text+")");
            }
        }

        private void cbthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvds.DataSource = db.ExcuteQuery("select*from XUATHOADONTHEONV('" + cbnv.SelectedValue.ToString()
                    + "'," + cbthang.Text + "," + cbnam.Text + ")");
        }

        private void cbnam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvds.DataSource = db.ExcuteQuery("select*from XUATHOADONTHEONV('" + cbnv.SelectedValue.ToString()
                    + "'," + cbthang.Text + "," + cbnam.Text + ")");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
            this.Close();
        }

        private void dgvds_DataSourceChanged(object sender, EventArgs e)
        {
            dgvds.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvds.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvds.DefaultCellStyle.ForeColor = Color.Blue;
        }

        private void GDQuanLi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Environment.Exit(1);
                e.Cancel = false;             
            }
            else
                e.Cancel = true;
        }
    }
}
