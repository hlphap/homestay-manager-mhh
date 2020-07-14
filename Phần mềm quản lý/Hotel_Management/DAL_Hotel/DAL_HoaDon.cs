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
    public class DAL_HoaDon
    {
        private string connectionSTR = null;

        public DAL_HoaDon()
        {
            connectionSTR = ConfigurationManager.AppSettings["ConnectionSTR"];
        }

        public string selectAll(List<DTO_HoaDon> lsObj)
        {

            string query = string.Empty;
            query += "SELECT * FROM TBL_HOADON";

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
                                DTO_HoaDon obj = new DTO_HoaDon();
                                obj.Mahd = reader["MAHD"].ToString();
                                obj.MaCTHD = reader["MACTHD"].ToString();
                                obj.Ngaythanhtoan = reader["NGAYTHANHTOAN"].ToString();
                                obj.Tratruoc = reader["TRATRUOC"].ToString();
                                obj.Manv = reader["MANV"].ToString();
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

        public string Insert(DTO_HoaDon obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [TBL_HOADON] ( [MAHD], [NGAYTHANHTOAN], [TRATRUOC], [MANV], [MACTHD] )";
            query += "VALUES (@MAHD, @NGAYTHANHTOAN, @TRATRUOC, @MANV, @MACTHD)";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    comm.Parameters.AddWithValue("@MAHD", obj.Mahd);
                    comm.Parameters.AddWithValue("@NGAYTHANHTOAN", obj.Ngaythanhtoan);
                    comm.Parameters.AddWithValue("@TRATRUOC", obj.Tratruoc);
                    comm.Parameters.AddWithValue("@MANV", obj.Manv);
                    comm.Parameters.AddWithValue("@MACTHD", obj.MaCTHD);

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

        public string Delete(DTO_HoaDon obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [TBL_HOADON] ";
            query += " WHERE ";
            query += " [MACTHD] = @MACTHD ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MACTHD", obj.MaCTHD);
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

        public string Update(DTO_HoaDon obj)
        {
            string query = string.Empty;
            query += " UPDATE [TBL_HOADON] SET";
            query += " [NGAYTHANHTOAN] = @NGAYTHANHTOAN";
            query += " [TRATRUOC] = @TRATRUOC";
            query += " [MANV] = @MANV";
            query += " WHERE ";
            query += " [MAHD] = @MAHD ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MAHD", obj.Mahd);
                    comm.Parameters.AddWithValue("@NGAYTHANHTOAN", obj.Ngaythanhtoan);
                    comm.Parameters.AddWithValue("@TRATRUOC", obj.Tratruoc);
                    comm.Parameters.AddWithValue("@MANV", obj.Manv);

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
        public string TaoMa()
        {
            string Ma = null;
            string query = string.Empty;
            query += "AUTO_IDHD";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = query;
                    SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);

                    //  
                    resultParam.Direction = ParameterDirection.ReturnValue;

                    comm.Parameters.Add(resultParam);



                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();

                        if (resultParam.Value != DBNull.Value)
                        {
                            Ma = (string)resultParam.Value;
                        }

                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' Cập nhật that bai!!!
                        return "Tạo mã thất bại" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
                return Ma;
            }
        }

        public string Search(string kq, List<DTO_HoaDon> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [MAHD], [NGAYTHANHTOAN], [TRATRUOC], [MANV]";
            query += " FROM [TBL_HOADON]";
            query += " WHERE";
            query += " [MAHD] = @MAHD ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MAHD", "%" + kq.ToString() + "%");

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_HoaDon obj = new DTO_HoaDon();
                                obj.Mahd = reader["MAHD"].ToString();
                                obj.Ngaythanhtoan = reader["NGAYTHANHTOAN"].ToString();
                                obj.Manv = reader["MANV"].ToString();
                                obj.Tratruoc = reader["TRATRUOC"].ToString();

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
