using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Hotel;
using DTO_Hotel;

namespace BUS_Hotel
{
    public class BUS_SignIn
    {
        DAL_SignIn dalSignIn = new DAL_SignIn();

        public string SignIn(DTO_SignIn Account)
        {
            return dalSignIn.SignIn(Account);
        }

        public string SelectAll(string x)
        {
            return dalSignIn.SelectAll(x);
        }
    }
}
