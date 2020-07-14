using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BUS_Hotel
{
    public class BUS_NhanVien
    {
        private DAL_NhanVien dal;

        public BUS_NhanVien()
        {
            dal = new DAL_NhanVien();
        }

        public string SelectAll(List<DTO_NhanVien> lsobj)
        {
            return dal.SelectAll(lsobj);
        }

        public string Delete(DTO_NhanVien obj)
        {
            return dal.Delete(obj);
        }

        public string Insert(DTO_NhanVien obj)
        {
            return dal.Insert(obj);
        }

        public string Update(DTO_NhanVien obj)
        {
            return dal.Update(obj);
        }

        public string Search(string kq, List<DTO_NhanVien> lsobj)
        {
            return dal.Search(kq, lsobj);
        }
    }
}
