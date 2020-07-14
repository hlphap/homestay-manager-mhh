using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class BUS_Phong
    {
        private DAL_Phong dal;
        public BUS_Phong()
        {
            dal = new DAL_Phong();
        }

        public string Insert(DTO_Phong obj)
        {
            return dal.Insert(obj);
        }

        public string Delete(DTO_Phong obj)
        {
            return dal.delete(obj);
        }

        public string Update(DTO_Phong obj)
        {
            return dal.update(obj);
        }

        public string SelectAll(List<DTO_Phong> lsObj)
        {
            return dal.selectAll(lsObj);
        }

        public string Search(string kq, List<DTO_Phong> lsobj)
        {
            return dal.search(kq, lsobj);
        }

        public string SelectWithCost(List<DTO_Phong> lsObj)
        {
            return dal.selectAllwithCost(lsObj);
        }
    }
}
