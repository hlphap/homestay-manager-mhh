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
    public class DAL_SignIn
    {

        private string connectionSTR = null;

        public DAL_SignIn()
        {
            connectionSTR = ConfigurationManager.AppSettings["ConnectionSTR"];
        }

        public string SignIn(DTO_SignIn account)
        {
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        string sql = string.Format("SELECT CHUCVU FROM TBL_TAIKHOAN WHERE TAIKHOAN = '" + account.user + "' and MATKHAU = '" + account.pass + "'");
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader dta = cmd.ExecuteReader();
                        if (dta.Read() == true)
                        {
                            return dta["CHUCVU"].ToString();
                        }
                        else
                        {
                            return "0";
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return "0";
        }

        public string insert(DTO_SignIn account)
        {
            string query = string.Empty;
            query += "INSERT INTO TBL_TAIKHOAN ( TAIKHOAN, MANV, MATKHAU, CHUCVU )";
            query += " VALUES ( @TAIKHOAN, @MANV, @MATKHAU, @CHHUCVU )";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {

                }
            }
            return "0";
        }

        public string SelectAll(string x)
        {
            string query = string.Empty;
            query += "SELECT MANV FROM TBL_TAIKHOAN WHERE TAIKHOAN = '" + x + "'";
            string Makh = null;
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
                            while (reader.Read())
                            {
                                Makh = reader["MANV"].ToString();
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
            return Makh;
        }
    }

}
