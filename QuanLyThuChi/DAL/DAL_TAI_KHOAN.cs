using QuanLyThuChi.Model;
using QuanLyThuChi.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.DAL
{
    class DAL_TAI_KHOAN
    {
        SQLite.Net.SQLiteConnection conn = (new ConnectToDB()).getConnect();

        public List<TAIKHOAN> GetTaiKhoan()
        {
            var query =
                conn.Query<TAIKHOAN>(
                    "select * from Model_TAI_KHOAN TK inner join Model_LOAI_TAI_KHOAN LTK on TK.idLoaiTaiKhoan=LTK.IdLoaiTaiKhoan")
                    .ToList();
            return query;
        }
    }
}
