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
    public class DAL_LoaiNV
    {
        private string connectionSTR = null;

        public DAL_LoaiNV()
        {
            connectionSTR = ConfigurationManager.AppSettings["ConnectionSTR"];
        }

        public string selectAll(List<DTO_LoaiNV> lsObj)
        {

            string query = string.Empty;
            query += " EXEC USP_GETLOAIPHONG";

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
                                DTO_LoaiNV obj = new DTO_LoaiNV();
                                obj.Malnv = reader["MALNV"].ToString();
                                obj.Tenlnv = reader["TENLNV"].ToString();
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

        public string Insert(DTO_LoaiNV obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [TBL_NHANVIEN] ( [MALNV], [TENLNV] )";
            query += "VALUES (@MALNV, @TENLNV)";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    comm.Parameters.AddWithValue("@MALNV", obj.Malnv);
                    comm.Parameters.AddWithValue("@TENLNV", obj.Tenlnv);

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

        public string Delete(DTO_LoaiNV obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [TBL_LOAINHANVIEN] ";
            query += " WHERE ";
            query += " [MALNV] = @MALNV ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MALNV", obj.Malnv);
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

        public string Update(DTO_LoaiNV obj)
        {
            string query = string.Empty;
            query += " UPDATE [TBL_LOAINHANVIEN] SET";
            query += " [TENLNV] = @TENLNV";
            query += " WHERE ";
            query += " [MALNV] = @MALNV ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MALNV", obj.Malnv);
                    comm.Parameters.AddWithValue("@TENLNV", obj.Tenlnv);

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

        public string Search(string kq, List<DTO_LoaiNV> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [MALNV], [TENLNV]";
            query += " FROM [TBL_LOAINHANVIEN]";
            query += " WHERE";
            query += " [MALNV] = @MALNV ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MALNV", "%" + kq.ToString() + "%");
                    comm.Parameters.AddWithValue("@TENLNV", "%" + kq.ToString() + "%");

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_LoaiNV obj = new DTO_LoaiNV();
                                obj.Malnv = reader["MALNV"].ToString();
                                obj.Tenlnv = reader["TENLNV"].ToString();
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
    }
}
