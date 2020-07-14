using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class BUS_KhachHang
    {
        private static BUS_KhachHang instance;

        public static BUS_KhachHang Instance { get => instance; set => instance = value; }

        private DAL_KhachHang dal;

        public BUS_KhachHang()
        {
            dal = new DAL_KhachHang();
        }

        public string SelectAll(List<DTO_KhachHang> lsobj)
        {
            return dal.selectAll(lsobj);
        }

        public string Delete(DTO_KhachHang obj)
        {
            return dal.delete(obj);
        }

        public string Insert(DTO_KhachHang obj)
        {
            return dal.Insert(obj);
        }

        public string Update(DTO_KhachHang obj)
        {
            return dal.update(obj);
        }

        public string Search(string kq, List<DTO_KhachHang> lsobj)
        {
            return dal.search(kq, lsobj);
        }
        public string TaoMaKH()
        {
            return dal.TaoMa();
        }
    }
}
