using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.Model;
using QuanLyThuChi.Objects;

namespace QuanLyThuChi.DAL
{
    public class DAL_GHI_CHEP
    {
        SQLite.Net.SQLiteConnection conn = (new ConnectToDB()).getConnect();

        public int addGhiChep(int ngay,
            int thang,
            int nam,
            string gio,
            string thuChiChuyenKhoan,
            string mucThu,
            string mucChi,
            long sotien,
            string maloaitien,
            string ghichu,
            string sukien,
            string tuTK,
            string denTK,
            string email)
        {
            //Insert data to Model_GHI_CHEP
            if (conn.Insert(new Model_GHI_CHEP()
            {
                Ngay = ngay,
                Thang = thang,
                Nam = nam,
                Gio = gio,
                ThuChiChuyenKhoan = thuChiChuyenKhoan,
                MucThu = mucThu,
                MucChi = mucChi,
                SoTien = sotien,
                MaLoaiTien = maloaitien,
                GhiChuGhiChep = ghichu,
                SuKien = sukien,
                TuTaiKhoan = tuTK,
                DenTaiKhoan = denTK,
                Email = email
            }) == 0)
                return 0;
            return 1;
        }

        public List<GHI_CHEP> getGhiChepByEmail(string email)
        {
            var query =
                conn.Query<GHI_CHEP>(
                    "select * from Model_GHI_CHEP where email='" + email + "'")
                    .ToList();
            return query;
        }

        public List<GHI_CHEP> getGhiChepByEmailAndAccount(string email, string accountName)
        {
            var query =
                conn.Query<GHI_CHEP>(
                    "select * from Model_GHI_CHEP where email='" + email + "' and TuTaiKhoan ='" + accountName + "'")
                    .ToList();
            return query;
        }

        public List<GHI_CHEP> getGhiChepByDate(int day, int month, int year, string email)
        {
            var query =
                conn.Query<GHI_CHEP>(
                    "select * from Model_GHI_CHEP where email='" + email + "' and Ngay = " + day 
                    + " and Thang=" + month + " and Nam= " + year + "")
                    .ToList();
            return query;
        }

        public List<GHI_CHEP> getGhiChepByMonth(int month, int year, string email)
        {
            var query =
                conn.Query<GHI_CHEP>(
                    "select * from Model_GHI_CHEP where email='" + email + "' and Thang=" + month + " and Nam= " + year + "")
                    .ToList();
            return query;
        }

        public List<GHI_CHEP> getGhiChepByYear(int year, string email)
        {
            var query =
                conn.Query<GHI_CHEP>(
                    "select * from Model_GHI_CHEP where email='" + email + "' and Nam= " + year + "")
                    .ToList();
            return query;
        }

    }
}
