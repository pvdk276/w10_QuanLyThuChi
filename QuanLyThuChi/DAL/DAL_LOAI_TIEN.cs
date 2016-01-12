using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.Objects;

namespace QuanLyThuChi.DAL
{
    public class DAL_LOAI_TIEN
    {
        SQLite.Net.SQLiteConnection conn = (new ConnectToDB()).getConnect();

        public List<LOAI_TIEN> GetLoaiTien()
        {
            var query =
                conn.Query<LOAI_TIEN>(
                    "select * from Model_LOAI_TIEN")
                    .ToList();
            return query;
        }
    }
}
