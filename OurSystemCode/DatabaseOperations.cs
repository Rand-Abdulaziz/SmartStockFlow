using System;
using System.Collections.Generic;
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
                        // إضافة المعلمات إذا كانت موجودة
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

        //Backup Database
        public void BackupDatabase(string backupPath)
        {
            try
            {
                // استخدام الاتصال المعرّف في getConnection
                using (SqlConnection connection = getConnection())
                {
                    connection.Open();

                    // استعلام SQL لعمل نسخ احتياطي للقاعدة
                    string backupQuery = $"BACKUP DATABASE [WHMSdb] TO DISK = '{backupPath}'";

                    // تنفيذ استعلام النسخ الاحتياطي
                    SqlCommand command = new SqlCommand(backupQuery, connection);
                    command.ExecuteNonQuery();

                    Console.WriteLine("Database backup completed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //Restore Database
        public void RestoreDatabase(string backupPath)
        {
            try
            {
                // استخدام الاتصال المعرّف في getConnection
                using (SqlConnection connection = getConnection())
                {
                    connection.Open();

                    // استعلام SQL لاستعادة قاعدة البيانات
                    string restoreQuery = $"RESTORE DATABASE [WHMSdb] FROM DISK = '{backupPath}'";

                    // تنفيذ استعلام الاستعادة
                    SqlCommand command = new SqlCommand(restoreQuery, connection);
                    command.ExecuteNonQuery();

                    Console.WriteLine("Database restore completed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}

