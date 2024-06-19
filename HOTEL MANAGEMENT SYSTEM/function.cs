using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Drawing;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM
{
    class function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-8BL3MIG\\SQLEXPRESS; database = myHotel ; integrated security = True";
            return con;

        }
        public DataSet GetData(string query) // Get Data From Database
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void SetData(string query, String message) //Insertion , Deletion , Updation
        {
            SqlConnection con = GetConnection() ;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query ;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" '"+message+"  '", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public SqlDataReader getforcombo(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query,con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
            
        }
    }
}
