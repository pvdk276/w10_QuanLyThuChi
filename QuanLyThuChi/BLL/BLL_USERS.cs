using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.Objects;
using System.Data;
using QuanLyThuChi.DAL;
using QuanLyThuChi.Util;

namespace QuanLyThuChi.BLL
{
    public class BLL_USERS
    {
        DAL_USERS dal = new DAL_USERS();
        /// <summary>
        /// Inserts the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public int insertUser(USERS user)
        {
            //mã hóa pass
            EncryptPassword encryptPass = new EncryptPassword();
            string newPass = encryptPass.encrypt(user.password);
            //insert
            return dal.insertUser(user.email, 
                user.firstName, 
                user.lastName, 
                newPass, 
                user.type, 
                user.status);
        }

        /// <summary>
        /// Kiểm tra thông tin đăng nhập.
        /// </summary>
        /// <param name="loai">Loại user.</param>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public int checkLogin(out string loai,string email, string password)
        {
            //Encrypt password
            EncryptPassword encryptPass = new EncryptPassword();
            string newPass = encryptPass.encrypt(password);

            //Lấy user để check
            USERS usr = dal.getUsersByEmail(email);
            if (usr != null && (newPass == usr.password))
            {
                loai = usr.type;
                return 1;
            }
            loai = string.Empty;
            return 0;
        }

        public List<USERS> getUser()
        {
            return dal.getUser();
        }

        public int deleteUser(string email)
        {
            if (email != "admin@heodat.com")
                return dal.deleteUser(email);
            else return 2;
        }
    }
}