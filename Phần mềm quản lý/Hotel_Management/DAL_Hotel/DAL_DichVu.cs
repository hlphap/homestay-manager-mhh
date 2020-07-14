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
    public class DAL_DichVu
    {
        private static DAL_DichVu instance;

        public static DAL_DichVu Instance { get => instance; set => instance = value; }

        private string connectionSTR = null;

        public DAL_DichVu()
        {
            connectionSTR = ConfigurationManager.AppSettings["ConnectionSTR"];
        }

        public string Insert(DTO_DichVu obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [TBL_DICHVU] ( [MADV], [TENDV], [GIADV] )";
            query += "VALUES (@MADV, @TENDV, @GIADV)";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    comm.Parameters.AddWithValue("@MADV", obj.Madv);
                    comm.Parameters.AddWithValue("@TENDV", obj.Tendv);
                    comm.Parameters.AddWithValue("@GIADV", obj.Giadv);

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

        public string SelectAll(List<DTO_DichVu> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [MADV], [TENDV], [GIADV]";
            query += " FROM [TBL_DICHVU]";

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
                                DTO_DichVu obj = new DTO_DichVu();
                                obj.Madv = reader["MADV"].ToString();
                                obj.Tendv = reader["TENDV"].ToString();
                                obj.Giadv = reader["GIADV"].ToString();
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

        public string SelectAllBySophong(List<DTO_DichVu> lsObj, int madv)
        {

            string query = string.Empty;
            query += " SELECT [MADV], [TENDV], [GIADV]";
            query += " FROM [TBL_DICHVU]";
            query += " WHERE ";
            query += " [MADV] = @MADV ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MADV", madv);

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_DichVu obj = new DTO_DichVu();
                                obj.Madv = reader["MADV"].ToString();
                                obj.Tendv = reader["TENDV"].ToString();
                                obj.Giadv = reader["GIADV"].ToString();
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

        public string Search(string kq, List<DTO_DichVu> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [MADV], [TENDV], [GIADV]";
            query += " FROM [TBL_DICHVU]";
            query += " WHERE ";
            query += " [MADV] = @MADV ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MAKH", "%" + kq.ToString() + "%");
                    comm.Parameters.AddWithValue("@TENKH", "%" + kq.ToString() + "%");

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_DichVu obj = new DTO_DichVu();
                                obj.Madv = reader["MADV"].ToString();
                                obj.Tendv = reader["TENDV"].ToString();
                                obj.Giadv = reader["GIADV"].ToString();
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Searching fail fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string Delete(DTO_DichVu obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [TBL_DICHVU] ";
            query += " WHERE ";
            query += " [MADV] = @MADV ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
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

        public string Update(DTO_DichVu obj)
        {
            string query = string.Empty;
            query += " UPDATE [TBL_DICHVU] SET";
            query += " [TENDV] = @TENDV";
            query += " [GIADV] = @GIADV";
            query += " WHERE ";
            query += " [MADV] = @MADV ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MADV", obj.Madv);
                    comm.Parameters.AddWithValue("@TENDV", obj.Tendv);
                    comm.Parameters.AddWithValue("@GIADV", obj.Giadv);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' Cập nhật that bai!!!
                        return "Updating fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
    }
}
