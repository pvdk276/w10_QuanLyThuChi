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
        public List<TAIKHOAN> GetTaiKhoanByEmail(string email)
        {
            var query =
                conn.Query<TAIKHOAN>(
                    "select * from Model_TAI_KHOAN where email='" + email + "'")
                    .ToList();
            return query;
        }

        public List<LOAITAIKHOAN> getLoaiTaiKhoan()
        {
            var query =
                conn.Query<LOAITAIKHOAN>(
                    "select * from Model_LOAI_TAI_KHOAN")
                    .ToList();
            return query;
        }

        public int insertAccount(string _tenTaiKhoan,
            int _idLoaiTaiKhoan,
            string _MaLoaiTien,
            string _GhiChu,
            long _SoTienTaiKhoan,
            string _Email)
        {
            //Insert data to Model_TAI_KHOAN
            if (conn.Insert(new Model_TAI_KHOAN()
            {
                tenTaiKhoan = _tenTaiKhoan,
                idLoaiTaiKhoan = _idLoaiTaiKhoan,
                MaLoaiTien = _MaLoaiTien,
                GhiChu = _GhiChu,
                SoTienTaiKhoan = _SoTienTaiKhoan,
                Email = _Email
            }) == 0)
                return 0;       //error
            return 1;
        }
    }
}
