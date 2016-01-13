using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.Model;
using QuanLyThuChi.Objects;

namespace QuanLyThuChi.DAL
{
    class DAL_HANG_MUC_CHI
    {
        SQLite.Net.SQLiteConnection conn = (new ConnectToDB()).getConnect();
        public List<HANG_MUC_CHI> GetHangMucChi(string email)
        {
            var query =
                conn.Query<HANG_MUC_CHI>(
                    "select * from Model_HANG_MUC_CHI where email='" + email + "'")
                    .ToList();
            return query;
        }

        public int insert(int _idHangMucChiCha, string _tenHangMucChi, string _ghiChu, bool _chinhSua, string _email)
        {
            //Insert data to Model_HANG_MUC_CHI
            if (conn.Insert(new Model_HANG_MUC_CHI()
            {
                IdHangMucChiCha = _idHangMucChiCha,
                TenHangMucChi = _tenHangMucChi,
                GhiChuHangMucChi = _ghiChu,
                ChinhSuaHangMucChi = _chinhSua,
                Email = _email
            }) == 0)
                return 0;       //error
            return 1;
        }
    }
}
