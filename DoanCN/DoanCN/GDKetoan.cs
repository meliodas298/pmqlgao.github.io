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
    public partial class GDKetoan : Form
    {
        database db = new database("localhost", "QLGAO");
        public GDKetoan()
        {
            InitializeComponent();
        }


        private void GDKetoan_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            label1.BackColor = Color.Transparent;
            a.BackColor = Color.Transparent;   
        }

        private void btbanle_Click(object sender, EventArgs e)
        {
            Banle BL = new Banle();
            BL.ShowDialog();
        }

        private void btxuatkho_Click(object sender, EventArgs e)
        {
            XuatKho XK = new XuatKho();
            XK.ShowDialog();
        }

        private void btnhapkho_Click(object sender, EventArgs e)
        {
            NhapKho NK = new NhapKho();
            NK.ShowDialog();
        }

        private void btthongke_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu tk = new ThongKeDoanhThu();
            tk.ShowDialog();
        }

        private void btdoimk_Click(object sender, EventArgs e)
        {
            NVDoiMatKhau dmk = new NVDoiMatKhau();
            dmk.ShowDialog();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
            this.Close();
        }

        private void GDKetoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Environment.Exit(1);
                this.Close();
                e.Cancel = false;             
            } 
            else
                e.Cancel = true;
        }
    }
}
