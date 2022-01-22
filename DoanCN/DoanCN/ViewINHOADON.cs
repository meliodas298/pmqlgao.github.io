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
    public partial class ViewINHOADON : Form
    {
        database db = new database("localhost", "QLGAO");
        public ViewINHOADON()
        {
            InitializeComponent();
        }

        private void ViewINHOADON_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            RP_INHOADON rp = new RP_INHOADON();    

            if (INHOADON.id == 1)
            {
               rp.SetDataSource(db.ExcuteQuery("select*from XUATDOANHTHU()"));
            }
            else if (INHOADON.id == 2)
            {
                rp.SetDataSource(db.ExcuteQuery("select*from XUATDOANHTHUN("+INHOADON.nam+")"));
            }
            else if (INHOADON.id == 3)
            {
                rp.SetDataSource(db.ExcuteQuery("select*from XUATDOANHTHUT("+INHOADON.thang+")"));
            }
            else if (INHOADON.id == 4)
            {
                rp.SetDataSource(db.ExcuteQuery("select*from XUATDOANHTHUM('"+INHOADON.mahd+"')"));
            }
            else if (INHOADON.id == 5)
            {
                rp.SetDataSource(db.ExcuteQuery("select*from XUATDOANHTHUTN("+ INHOADON.thang + ","+INHOADON.nam+")"));
            }
            else if (INHOADON.id == 6)
            {
                rp.SetDataSource(db.ExcuteQuery("select*from XUATDOANHTHUMN('" + INHOADON.mahd + "', " + INHOADON.nam + ")"));
            }
            else if (INHOADON.id == 7)
            {
                rp.SetDataSource(db.ExcuteQuery("select*from XUATDOANHTHUMT('" + INHOADON.mahd + "', " + INHOADON.thang + " )"));
            }
            else
            {
                rp.SetDataSource(db.ExcuteQuery("select*from XUATDOANHTHUMTN('" + INHOADON.mahd + "', " + INHOADON.thang + "," + INHOADON.nam + ")"));
            }
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
