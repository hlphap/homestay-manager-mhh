using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class BUS_HoaDon
    {
        private DAL_HoaDon dal;

        public BUS_HoaDon()
        {
            dal = new DAL_HoaDon();
        }
        public string TaoMaHD()
        {
            return dal.TaoMa();
        }
        public string SelectAll(List<DTO_HoaDon> lsobj)
        {
            return dal.selectAll(lsobj);
        }

        public string Delete(DTO_HoaDon obj)
        {
            return dal.Delete(obj);
        }

        public string Insert(DTO_HoaDon obj)
        {
            return dal.Insert(obj);
        }

        public string Update(DTO_HoaDon obj)
        {
            return dal.Update(obj);
        }

        public string Search(string kq, List<DTO_HoaDon> lsobj)
        {
            return dal.Search(kq, lsobj);
        }
    }
}
