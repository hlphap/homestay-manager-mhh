using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_Hotel
{
    public class BUS_DichVu
    {
        private static BUS_DichVu instance;

        public static BUS_DichVu Instance { get => instance; set => instance = value; }

        private DAL_DichVu dal;

        public BUS_DichVu()
        {
            dal = new DAL_DichVu();
        }

        public string SelectAll(List<DTO_DichVu> lsobj)
        {
            return dal.SelectAll(lsobj);
        }

        public string Delete(DTO_DichVu obj)
        {
            return dal.Delete(obj);
        }

        public string Insert(DTO_DichVu obj)
        {
            return dal.Insert(obj);
        }

        public string Update(DTO_DichVu obj)
        {
            return dal.Update(obj);
        }

        public string Search(string kq, List<DTO_DichVu> lsobj)
        {
            return dal.Search(kq, lsobj);
        }
    }
}
