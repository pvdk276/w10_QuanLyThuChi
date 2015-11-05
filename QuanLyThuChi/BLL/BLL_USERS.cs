using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.Objects;
using QuanLyThuChi.DAL;

namespace QuanLyThuChi.BLL
{
    public class BLL_USERS
    {
        DAL_USERS dal = new DAL_USERS();
        public int insertUser(USERS user)
        {
            return dal.insertUser(user.email, 
                user.firstName, 
                user.lastName, 
                user.password, 
                user.type, 
                user.status);
        }
    }
}