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
    public partial class ThongKeDoanhThu : Form
    {
        database db = new database("localhost", "QLGAO");
        public ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            dgvds.RowHeadersVisible = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            cbbnam.Items.Add("Tất cả");
            cbbthang.Items.Add("Tất cả");
            cbloaihd.Items.Add("Tất cả");
            cbloaihd.Text = "Tất cả";
            string[] a = { "Hóa Đơn Bán Lẻ", "Hóa Đơn Xuất Kho", "Hóa Đơn Nhập Kho" };
            string[] b = { "BL", "XK", "NK" };
            for (int i = 0; i < 3; i++)
            {
                TreeNode node = new TreeNode();
                node.Text = a[i];
                node.Tag = b[i];
                treeds.Nodes.Add(node);
                cbloaihd.Items.Add(a[i]);
                DataTable dt1 = db.ExcuteQuery("select*from HOADONTHEOLOAI('"+b[i]+"')");
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    TreeNode node1 = new TreeNode();
                    node1.Text = dt1.Rows[j][0].ToString();
                    node1.Tag = dt1.Rows[j][0].ToString();
                    node.Nodes.Add(node1);
                }

            }
            cbbnam.Text = "Tất cả";
            cbbthang.Text = "Tất cả";
            for (int i = 1; i < 13; i++)
                cbbthang.Items.Add(i);
            for (int i = 2021; i < 2027; i++)
                cbbnam.Items.Add(i);
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            groupBox3.BackColor = System.Drawing.Color.Transparent;
            abc.BackColor = System.Drawing.Color.Transparent;
            lbtong.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
        }

        private void treeds_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string a = treeds.SelectedNode.Text;
            string b = treeds.SelectedNode.Tag.ToString();
            if (a.Substring(0, 3) != "Bán")
            {
                dgvds.DataSource = db.ExcuteQuery("Select*from XUATCTHD('"+b+"')");
                int tong = 0;
                for (int i = 0; i < dgvds.Rows.Count - 1; i++)
                {
                    tong += int.Parse(dgvds.Rows[i].Cells[4].Value.ToString());
                }
                lbtong.Text = "Tổng tiền: " + string.Format("{0:n0} đồng",tong); 
            }
        }

  

        private void btin_Click(object sender, EventArgs e)
        {
          
            if (cbloaihd.Text == "Hóa Đơn Bán Lẻ")
                INHOADON.mahd = "BL";
           else if (cbloaihd.Text == "Hóa Đơn Xuất Kho")
                INHOADON.mahd = "XK";
            else if (cbloaihd.Text == "Hóa Đơn Nhập Kho")
                INHOADON.mahd = "NK";
            if (cbloaihd.Text == "Tất cả" && cbbthang.Text == "Tất cả" && cbbnam.Text == "Tất cả")
                INHOADON.id = 1;
            else if (cbloaihd.Text == "Tất cả" && cbbthang.Text == "Tất cả")
            {
                INHOADON.id = 2;
                INHOADON.nam = int.Parse(cbbnam.Text);
            }
            else if (cbloaihd.Text == "Tất cả" && cbbnam.Text == "Tất cả")
            {
                INHOADON.id = 3;
                INHOADON.thang = int.Parse(cbbthang.Text);
            }
            else if (cbbthang.Text == "Tất cả" && cbbnam.Text == "Tất cả")
            {
                INHOADON.id = 4;

            }
            else if (cbloaihd.Text == "Tất cả")
            {
                INHOADON.id = 5;
                INHOADON.nam = int.Parse(cbbnam.Text);
                INHOADON.thang = int.Parse(cbbthang.Text);
            }
            else if (cbbthang.Text == "Tất cả")
            {
                INHOADON.id = 6;
                INHOADON.nam = int.Parse(cbbnam.Text);

                
            }
            else if (cbbnam.Text == "Tất cả")
            {
                INHOADON.id = 7;
                INHOADON.thang = int.Parse(cbbthang.Text);
            }
            else
            {
                INHOADON.id = 8;
                INHOADON.nam = int.Parse(cbbnam.Text);
                INHOADON.thang = int.Parse(cbbthang.Text);
            }
            /* MessageBox.Show(cbbthang.Text);
             MessageBox.Show(cbbnam.Text);
             MessageBox.Show(INHOADON.id.ToString());
             MessageBox.Show(INHOADON.mahd);
             MessageBox.Show(INHOADON.thang.ToString());
             MessageBox.Show(INHOADON.nam.ToString()); */
            ViewINHOADON In = new ViewINHOADON();
            In.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvds_DataSourceChanged(object sender, EventArgs e)
        {
            dgvds.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvds.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvds.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvds.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvds.DefaultCellStyle.ForeColor = Color.Blue;
        }
    }
}
