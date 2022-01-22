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
    public partial class QLDoiMatKhau : Form
    {
        database db = new database("localhost", "QLGAO");
        public QLDoiMatKhau()
        {
            InitializeComponent();
        }

        private void QLDoiMatKhau_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            cbbtk.DataSource = db.ExcuteQuery("select*from HIENTHITAIKHOAN()");
            cbbtk.DisplayMember = "TaiKhoan";
            cbbtk.ValueMember = "TaiKhoan";
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
        }

        private void txtcn_Click(object sender, EventArgs e)
        {
            db.ExcuteNonQuery("DOIMATKHAU '" + cbbtk.Text + "', '" + txtmk.Text + "'");
            MessageBox.Show("cập nhật mật khẩu mới thành công");
        }


        private void cbbtk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbtk.Text != "System.Data.DataRowView")
            {
                DataTable dt = db.ExcuteQuery("select*from XUATMANV('" + cbbtk.Text + "')");
                txtma.Text = dt.Rows[0][0].ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
