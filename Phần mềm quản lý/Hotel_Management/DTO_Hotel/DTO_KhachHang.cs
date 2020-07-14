using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_KhachHang
    {
        private string makh;
        private string tenkh;
        private string diachi;
        private string gioitinh;
        private string cmnd;
        private string quoctich;
        private string sdt;

        //public DTO_KhachHang(string makh, string tenkh, string diachi, string sex, string cmnd, string quoctich, string sdt)
        //{
        //    this.Makh = makh;
        //    this.Tenkh = tenkh;
        //    this.Diachi = diachi;
        //    this.Gioitinh = sex;
        //    this.Cmnd = cmnd;
        //    this.Quoctich = quoctich;
        //    this.Sdt = sdt;
        //}

        //public DTO_KhachHang(DataRow row)
        //{
        //    this.Makh = row["MAKH"].ToString();
        //    this.Tenkh = row["TENKH"].ToString();
        //    this.Diachi = row["DIACHI"].ToString();
        //    this.Gioitinh = row["GIOITINH  "].ToString();
        //    this.Cmnd = row["CMND"].ToString();
        //    this.Quoctich = row["QUOCTICH"].ToString();
        //    this.Sdt = row["SDT"].ToString();
        //}

        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Quoctich { get => quoctich; set => quoctich = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
