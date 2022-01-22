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
    public partial class NVDoiMatKhau : Form
    {
        database db = new database("localhost", "QLGAO");
        public NVDoiMatKhau()
        {
            InitializeComponent();
        }

        private void NVDoiMatKhau_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            txttk.Text = MANV.tk;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
        }

        private void btcn_Click(object sender, EventArgs e)
        {
            if (txtmk.Text == MANV.mk)
                if (txtmkmoi.Text == txtnlmk.Text)
                    {
                        db.ExcuteNonQuery("DOIMATKHAU '" + MANV.tk + "', '" + MANV.mk + "'");
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                    }
                else
                    MessageBox.Show("Mật khẩu không trùng nhau");
            else
                MessageBox.Show("Sai mật khẩu");
        }


        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
