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
    public class DAL_KhachHang
    {
        private static DAL_KhachHang instance;
        public static DAL_KhachHang Instance
        {
            get { if (instance == null) instance = new DAL_KhachHang(); return DAL_KhachHang.instance; }
            private set { DAL_KhachHang.instance = value; }
        }

        private string connectionSTR = null;

        public DAL_KhachHang()
        {
            connectionSTR = ConfigurationManager.AppSettings["ConnectionSTR"];
        }

        public string Insert(DTO_KhachHang obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [TBL_KHACHHANG] ( [MAKH], [TENKH], [DIACHI], [GIOITINH], [NGAYSINH], [CMND], [QUOCTICH], [SDT] )";
            query += "VALUES (@MAKH, @TENKH, @DIACHI, @GIOITINH, @NGAYSINH, @CMND, @QUOCTICH, @SDT)";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    comm.Parameters.AddWithValue("@MAKH", obj.Makh);
                    comm.Parameters.AddWithValue("@TENKH", obj.Tenkh);
                    comm.Parameters.AddWithValue("@DIACHI", obj.Diachi);
                    comm.Parameters.AddWithValue("@GIOITINH", obj.Gioitinh);
                    comm.Parameters.AddWithValue("@NGAYSINH", obj.Ngaysinh);
                    comm.Parameters.AddWithValue("@CMND", obj.Cmnd);
                    comm.Parameters.AddWithValue("@QUOCTICH", obj.Quoctich);
                    comm.Parameters.AddWithValue("@SDT", obj.Sdt);

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

        public string SelectAll(List<DTO_KhachHang> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [MAKH], [TENKH], [DIACHI], [GIOITINH], [NGAYSINH], [CMND], [QUOCTICH], [SDT] ";
            query += " FROM [TBL_KHACHHANG]";

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
                                DTO_KhachHang obj = new DTO_KhachHang();
                                obj.Makh = reader["MAKH"].ToString();
                                obj.Tenkh = reader["TENKH"].ToString();
                                obj.Diachi = reader["DIACHI"].ToString();
                                obj.Gioitinh = reader["GIOITINH"].ToString();
                                obj.Ngaysinh = reader["NGAYSINH"].ToString();
                                obj.Cmnd = reader["CMND"].ToString();
                                obj.Quoctich = reader["QUOCTICH"].ToString();
                                obj.Sdt = reader["SDT"].ToString();
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

     

        public string Delete(DTO_KhachHang obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [TBL_KHACHHANG] ";
            query += " WHERE ";
            query += " [MAKH] = @MAKH ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MAKH", obj.Makh);
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

        public string Update(DTO_KhachHang obj)
        {
            string query = string.Empty;
            query += " UPDATE [TBL_KHACHHANG] SET";
            query += " [TENKH] = @TENKH";
            query += ", [DIACHI] = @DIACHI";
            query += ", [GIOITINH] = @GIOITINH";
            query += ", [NGAYSINH] = @NGAYSINH";
            query += ", [CMND] = @CMND";
            query += ", [QUOCTICH] = @QUOCTICH";
            query += ", [SDT] = @SDT";
            query += " WHERE ";
            query += " [MAKH] = @MAKH ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MAKH", obj.Makh);
                    comm.Parameters.AddWithValue("@TENKH", obj.Tenkh);
                    comm.Parameters.AddWithValue("@DIACHI", obj.Diachi);
                    comm.Parameters.AddWithValue("@GIOITINH", obj.Gioitinh);
                    comm.Parameters.AddWithValue("@NGAYSINH", obj.Ngaysinh);
                    comm.Parameters.AddWithValue("@CMND", obj.Cmnd);
                    comm.Parameters.AddWithValue("@QUOCTICH", obj.Quoctich);
                    comm.Parameters.AddWithValue("@SDT", obj.Sdt);
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

    
        public string TaoMa()
        {
            string Makh = null;
            string query = string.Empty;
            query += "AUTO_IDKH";
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
                            Makh = (string)resultParam.Value;
                        }

                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' Cập nhật that bai!!!
                        return "Tạo mã thất bại" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
                return Makh;
            }
        }
    }
}
