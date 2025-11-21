using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class conncls
    {
        SqlConnection con;
        SqlCommand cmd;

        public conncls()
        {

            con = new SqlConnection(@"server=LAPTOP-IF3SH872\SQLEXPRESS;database=Registration;Integrated Security=True;");
        }


        public int fun_Nonquery(string query)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            //topil declare aakiyakond just cmd and con
            cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string Fn_Scalar(string sqlquery)//scalarfuns....count,sum
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            //topil declare aakiyakond just cmd and con
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
    }
}
