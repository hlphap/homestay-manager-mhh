using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class BUS_LoaiPhong
    {
        private DAL_LoaiPhong dal;
        public BUS_LoaiPhong()
        {
            dal = new DAL_LoaiPhong();
        }

        public string Insert(DTO_LoaiPhong obj)
        {
            return dal.Insert(obj);
        }

        public string Delete(DTO_LoaiPhong obj)
        {
            return dal.Delete(obj);
        }

        public string Update(DTO_LoaiPhong obj)
        {
            return dal.Update(obj);
        }

        public string SelectAll(List<DTO_LoaiPhong> lsObj)
        {
              return dal.selectAll(lsObj);
        }

        public string Search(string kq, List<DTO_LoaiPhong> lsobj)
        {
            return dal.Search(kq, lsobj);
        }

        public string TaoMaLP()
        {
            return dal.TaoMa();
        }
    }
}
