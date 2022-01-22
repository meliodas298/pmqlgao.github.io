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
    public partial class RP_XuatKhau : Form
    {
        database db = new database("localhost", "QLGAO");
        public RP_XuatKhau()
        {
            InitializeComponent();
        }

        private void RP_XuatKhau_Load(object sender, EventArgs e)
        {
            

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        
            RP_XUATNHAPKHO rp = new RP_XUATNHAPKHO();
            rp.SetDataSource(db.ExcuteQuery("select*from XUATRPXUATNHAPHD('" + MAXK.maxk + "')"));
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
