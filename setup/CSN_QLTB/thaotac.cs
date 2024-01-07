using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSN_QLTB
{
    internal class thaotac
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;
        public thaotac()
        {
            string strCnn = "Data Source=PC\\SQLEXPRESS;database=CSN_QLTB_31/12;Integrated Security=true";
            sqlConn = new SqlConnection(strCnn);
        }

        // Select Command

        public DataTable Excute(string sql)
        {
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        // Them , Xoa, Sua 

        public void excuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();

            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}
