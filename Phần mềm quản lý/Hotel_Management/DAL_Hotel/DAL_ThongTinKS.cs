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
    public class DAL_ThongTinKS
    {
        private static DAL_ThongTinKS instance;
        public static DAL_ThongTinKS Instance
        {
            get { if (instance == null) instance = new DAL_ThongTinKS(); return DAL_ThongTinKS.instance; }
            private set { DAL_ThongTinKS.instance = value; }
        }
        private string connectionSTR = null;
        public DAL_ThongTinKS()
        {
            connectionSTR = ConfigurationManager.AppSettings["ConnectionSTR"];
        }
        public DTO_ThongTinKS selectAll()
        {
            DTO_ThongTinKS ttks = new DTO_ThongTinKS();
            string query = string.Empty;
            query += "USP_GETTHONGTINKS";
            SqlConnection conn = new SqlConnection(connectionSTR);
            SqlCommand comm = new SqlCommand();
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
                        
                        ttks.Maks = reader["MAKS"].ToString();
                        ttks.Tenks = reader["TENKS"].ToString();
                        ttks.Diachiks = reader["DIACHIKS"].ToString();
                        ttks.Emailks = reader["EMAILKS"].ToString();
                        ttks.SDTks = reader["SDTKS"].ToString();
                        ttks.Websiteks = reader["WEBSITEKS"].ToString();
                    }
                }
                return ttks;
                
            }
            catch
            {
                conn.Close();
                return ttks;
            }
            
  
        }
    }
}


           