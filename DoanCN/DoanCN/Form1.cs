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
    public partial class Form1 : Form
    {
        database db = new database("localhost", "QLGAO");
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = db.ExcuteQuery("select dbo.DANGNHAP1('"+tk.Text+"','"+mk.Text+"')");
            int a = int.Parse(dt.Rows[0][0].ToString());
            if (a != 0)
            {
                DataTable dt1 = db.ExcuteQuery("select*from DNMANV('" + tk.Text + "')");
                MANV.manv = dt1.Rows[0][0].ToString();
                MANV.mk = dt1.Rows[0][1].ToString();
                MANV.tk = dt1.Rows[0][2].ToString();
                int ma = int.Parse(dt1.Rows[0][0].ToString().Substring(2, 1));
                if (ma == 2)
                {
                    GDKetoan kt = new GDKetoan();
                    this.Hide();               
                    kt.ShowDialog();
                    
                }
                else
                {
                    GDQuanLi ql = new GDQuanLi();
                    this.Hide();             
                    ql.ShowDialog();
                    
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công! sai tài khoản hoặc mật khẩu.");
                mk.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
              MaximizeBox = false;
                label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            //  MinimizeBox = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
