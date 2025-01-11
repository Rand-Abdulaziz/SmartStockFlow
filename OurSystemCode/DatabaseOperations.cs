using System;
using System.Data;
using System.Data.SqlClient;

namespace OurSystemCode
{
    internal class DatabaseOperations
    {
        // ✅ Establish a database connection
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=warehousedb.chce80egkzdn.eu-north-1.rds.amazonaws.com;initial catalog=WHMSdb;user id=admin1;password=TheStrongTeam1;";
            return con;
        }

        // ✅ Get data from the database
        public DataSet getData(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            con.Open();
                            da.Fill(ds);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in getData: " + ex.Message);
            }
            return ds;
        }

        // ✅ Insert, Update, Delete data in the database
        public int setData(string query, string msg)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection con = getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine(msg);  // ✅ Optional success message
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in setData: " + ex.Message);
            }
            return rowsAffected;
        }
    }
}

