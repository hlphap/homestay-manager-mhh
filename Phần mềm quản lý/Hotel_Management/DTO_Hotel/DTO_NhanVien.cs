using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_NhanVien
    {
        private string manv;

        public string Manv { get => manv; set => manv = value; }
        public string Name { get => name; set => name = value; }
        public string Malnv { get => malnv; set => malnv = value; }
        public string Date { get => date; set => date = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Address { get => address; set => address = value; }

        private string name;
        private string malnv;
        private string date;
        private string sex;
        private string sdt;
        private string address;

        //public DTO_NhanVien(string manv, string name, string malnv, string date, bool sex, string sdt, string address)
        //{
        //    this.manv = manv;
        //    this.name = name;
        //    this.malnv = malnv;
        //    this.date = date;
        //    this.sex = sex;
        //    this.sdt = sdt;
        //    this.address = address;
        //}

        //public DTO_NhanVien(DataRow row)
        //{
        //    this.Manv = row["MANV"].ToString();
        //    this.Name = row["TENNV"].ToString();
        //    this.Malnv = row["MALNV"].ToString();
        //    this.Date = (string)(row["NGSINH"].ToString());
        //    this.Sex = (bool)Convert.ToBoolean(row["GIOITINH"].ToString());
        //    this.Sdt = row["SDT"].ToString();
        //    this.Address = row["DIACHI"].ToString();
        //}
    }
}
