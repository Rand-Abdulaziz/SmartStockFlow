//Start laibrary
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; //Sql Server
//End laibrary
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

        // ✅ Get data from the database with parameters
        public DataSet getDataWithParameter(string query, Dictionary<string, object> parameters = null)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                       
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

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
        //
        // ✅ Insert, Update, Delete data in the database with parameters
        public int setDataWithParameter(string query, Dictionary<string, object> parameters)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection con = getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                       
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        con.Open();
                        rowsAffected = cmd.ExecuteNonQuery();


                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in setDataWithParameter: " + ex.Message);
            }
            return rowsAffected;
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

