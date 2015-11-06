using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.DAL;

namespace QuanLyThuChi.BLL
{
    public class BLL_ConnectToDB
    {
        public int checkConnect()
        {
            ConnectToDB db = new ConnectToDB();
            return db.createDatabase();
        }
    }
}
