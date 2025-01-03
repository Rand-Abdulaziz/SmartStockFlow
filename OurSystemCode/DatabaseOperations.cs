using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    internal class DatabaseOperations
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=warehousedb.chce80egkzdn.eu-north-1.rds.amazonaws.com;initial catalog=WHMSdb;user id=admin1;password=TheStrongTeam1;";

            return con;
        }

        public DataSet getData(String query)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in getData : " + ex);
            }
            return ds;
        }

        public int setData(String query, String msg)
        {
            int rowsAffected = 0;
            try
            {
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                rowsAffected = cmd.ExecuteNonQuery(); 
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in setData : " + ex);
            }
            return rowsAffected; 

        }

    }
}
