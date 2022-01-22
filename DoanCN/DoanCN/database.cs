using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoanCN
{
    class database
    {
        public SqlConnection cnn;

        public database(string svname, string dtbase)
        {
            string sqlcon = @"Data Source=" + svname + ";Initial Catalog=" + dtbase + ";Integrated Security=True";
            cnn = new SqlConnection(sqlcon);

        }

        public DataTable ExcuteQuery(string sql)
        {
            cnn.Open();
            SqlCommand cd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cnn.Close();
            return dt;
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
