using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.Objects;
using QuanLyThuChi.DAL;
using QuanLyThuChi.Util;

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

        public int checkLogin(string email, string password)
        {
            //Encrypt password
            EncryptPassword encryptPass = new EncryptPassword();
            string newPass = encryptPass.encrypt(password);

            //Lấy user để check
            USERS usr = dal.getUsersByEmail(email);
            if (usr != null && (newPass == usr.password))
                return 1;
            return 0;
        }
    }
}