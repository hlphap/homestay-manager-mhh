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
    public class DAL_NhanVien
    {
        private string connectionSTR = null;

        public DAL_NhanVien()
        {
            connectionSTR = ConfigurationManager.AppSettings["ConnectionSTR"];
        }

        public string Insert(DTO_NhanVien obj)
        {
            string query = string.Empty;
            query += " EXEC USP_INSERTNHANVIEN ";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    comm.Parameters.AddWithValue("@MANV", obj.Manv);
                    comm.Parameters.AddWithValue("@TENNV", obj.Name);
                    comm.Parameters.AddWithValue("@MALNV", obj.Malnv);
                    comm.Parameters.AddWithValue("@NGSINH", obj.Date);
                    comm.Parameters.AddWithValue("@GIOITINH", obj.Sex);
                    comm.Parameters.AddWithValue("@SDT", obj.Sdt);
                    comm.Parameters.AddWithValue("@DIACHI", obj.Address);

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

        public string SelectAll(List<DTO_NhanVien> lsObj)
        {

            string query = string.Empty;
            query += " EXEC USP_GETNHANVIEN ";

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
                                DTO_NhanVien obj = new DTO_NhanVien();
                                obj.Manv = reader["MANV"].ToString();
                                obj.Name = reader["TENNV"].ToString();
                                obj.Malnv = reader["GIADV"].ToString();
                                obj.Date = reader["NGSINH"].ToString();
                                obj.Sex = reader["GIOITINH"].ToString();
                                obj.Sdt = reader["SDT"].ToString();
                                obj.Address = reader["DIACHI"].ToString();
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

        public string SelectAllBySophong(List<DTO_NhanVien> lsObj, int manv)
        {

            string query = string.Empty;
            query += " SELECT [MANV], [TENNV], [MALNV], [NGSINH], [GIOITINH], [SDT], [DIACHI]";
            query += " FROM [TBL_NHANVIEN]";
            query += " WHERE ";
            query += " [MANV] = @MANV ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MANV", manv);

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_NhanVien obj = new DTO_NhanVien();
                                obj.Manv = reader["MANV"].ToString();
                                obj.Name = reader["TENNV"].ToString();
                                obj.Malnv = reader["GIADV"].ToString();
                                obj.Date = reader["NGSINH"].ToString();
                                obj.Sex = reader["GIOITINH"].ToString();
                                obj.Sdt = reader["SDT"].ToString();
                                obj.Address = reader["DIACHI"].ToString();
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

        public string Search(string kq, List<DTO_NhanVien> lsObj)
        {

            string query = string.Empty;
            query += " EXEC USP_GETNHANVIENBYMANV";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MANV", "%" + kq.ToString() + "%");
                    comm.Parameters.AddWithValue("@TENNV", "%" + kq.ToString() + "%");

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_NhanVien obj = new DTO_NhanVien();
                                obj.Manv = reader["MANV"].ToString();
                                obj.Name = reader["TENNV"].ToString();
                                obj.Malnv = reader["GIADV"].ToString();
                                obj.Date = reader["NGSINH"].ToString();
                                obj.Sex = reader["GIOITINH"].ToString();
                                obj.Sdt = reader["SDT"].ToString();
                                obj.Address = reader["DIACHI"].ToString();
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

        public string Delete(DTO_NhanVien obj)
        {
            string query = string.Empty;
            query += " EXEC USP_DELETENHANVIEN ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MANV", obj.Manv);
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

        public string Update(DTO_NhanVien obj)
        {
            string query = string.Empty;
            query += " EXEC USP_UPDATENHANVIEN";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MANV", obj.Manv);
                    comm.Parameters.AddWithValue("@TENNV", obj.Name);
                    comm.Parameters.AddWithValue("@MALNV", obj.Malnv);
                    comm.Parameters.AddWithValue("@NGSINH", obj.Date);
                    comm.Parameters.AddWithValue("@GIOITINH", obj.Sex);
                    comm.Parameters.AddWithValue("@SDT", obj.Sdt);
                    comm.Parameters.AddWithValue("@DIACHI", obj.Address);

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
