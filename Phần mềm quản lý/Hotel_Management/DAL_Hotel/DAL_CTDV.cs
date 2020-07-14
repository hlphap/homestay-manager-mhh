using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    public class DAL_CTDV
    {
        private string connectionSTR = null;

        

        public DAL_CTDV()
        {
            connectionSTR = ConfigurationManager.AppSettings["ConnectionSTR"];
        }
        public string selectAll(List<DTO_CTDV> lsObj)
        {

            string query = string.Empty;
            query += "SELECT * FROM TBL_CTDV";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_CTDV obj = new DTO_CTDV();
                                obj.Madv = reader["MADV"].ToString();
                                obj.Macthd = reader["MACTHD"].ToString();
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Selecting fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
        public string Insert(DTO_CTDV obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [TBL_CTDV] ([MACTHD], [MADV] ) ";
            query += "VALUES (@MACTHD, @MADV)";


            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    comm.Parameters.AddWithValue("@MACTHD", obj.Macthd);
                    comm.Parameters.AddWithValue("@MADV", obj.Madv);

                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Adding fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string DeleteAll(DTO_CTDV obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [TBL_CTDV] ";
            query += " WHERE ";
            query += " [MACTHD] = @MACTHD ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MACTHD", obj.Macthd);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Deleting fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
        public string Delete(DTO_CTDV obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [TBL_CTDV] ";
            query += " WHERE ";
            query += " [MACTHD] = @MACTHD ";
            query += "AND [MADV] = @MADV";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MACTHD", obj.Macthd);
                    comm.Parameters.AddWithValue("@MADV", obj.Madv);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Deleting fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string Update(DTO_CTDV obj)
        {
            string query = string.Empty;
            query += " UPDATE [TBL_CTDV] SET";
            query += " [MACTHD] = @MACTHD";
            query += " [MADV] = @MADV";
            query += " WHERE ";
            query += " [MACTHD] = @MACTHD ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MACTHD", obj.Macthd);
                    comm.Parameters.AddWithValue("@MAKH", obj.Madv);
                 


                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Updating fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

      
     
    }

}

