using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_DichVu
    {
        private string madv;
        private string tendv;
        private string giadv;

        //public DTO_DichVu(string madv, string tendv, int gia)
        //{
        //    this.Madv = madv;
        //    this.Tendv = tendv;
        //    this.Giadv = gia;
        //}

        //public DTO_DichVu(DataRow row)
        //{
        //    this.Madv = row["MADV"].ToString();
        //    this.Tendv = row["TENDV"].ToString();
        //    this.Giadv = (int)Convert.ToInt32(row["GIA"].ToString());
        //}

        public string Madv { get => madv; set => madv = value; }
        public string Tendv { get => tendv; set => tendv = value; }
        public string Giadv { get => giadv; set => giadv = value; }
    }
}
