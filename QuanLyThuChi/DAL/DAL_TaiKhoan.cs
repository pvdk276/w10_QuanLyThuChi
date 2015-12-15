using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.Model;
using QuanLyThuChi.Objects;

namespace QuanLyThuChi.DAL
{
    class DAL_TaiKhoan
    {
        SQLite.Net.SQLiteConnection conn = (new ConnectToDB()).getConnect();
        public List<Model_TAI_KHOAN> GetTaiKhoan()
        {
            var query = conn.Table<Model_TAI_KHOAN>();
            List<Model_TAI_KHOAN> listTaiKhoan = new List<Model_TAI_KHOAN>();
            foreach(var item in query)
            {
                listTaiKhoan.Add(new Model_TAI_KHOAN(){
                    idTaiKhoan = item.idTaiKhoan,
                    tenTaiKhoan = item.tenTaiKhoan,
                    idLoaiTaiKhoan = item.idLoaiTaiKhoan,
                    MaLoaiTien = item.MaLoaiTien,
                    GhiChu = item.GhiChu,
                    SoTienTaiKhoan = item.SoTienTaiKhoan,
                    Email = item.Email

                });
            }
            return listTaiKhoan;
        }
        public int insertTaiKhoan(uint idTaiKhoan, string tenTaiKhoan, uint idLoaiTaiKhoan, string maLoaiTien,
            string ghiChu, long soTienTaiKhoan, string email)
        {
            if (conn.Insert(new Model_TAI_KHOAN()
            {
                idTaiKhoan = idTaiKhoan,
                tenTaiKhoan = tenTaiKhoan,
                idLoaiTaiKhoan = idLoaiTaiKhoan,
                MaLoaiTien = maLoaiTien,
                GhiChu = ghiChu,
                SoTienTaiKhoan = soTienTaiKhoan,
                Email = email
            }) == 0)
                return 0;
            return 1;
        }
        public int getIDbyLoaiTaiKhoan(string loaiTaiKhoan)
        {
            var query = conn.Table<Model_LOAI_TAI_KHOAN>().Where(x => x.TenLoaiTaiKhoan == loaiTaiKhoan);
            TAIKHOANS tkhoan = new TAIKHOANS();
            foreach (var item in query)
            {
                return item.IdLoaiTaiKhoan;
                //Debug.WriteLine("[QLTC]" + usr.email + " | " + usr.password);
            }
            return 0;
        }
        public string getMaTienbyLoaiTien(string loaitien)
        {
            var query = conn.Table<Model_LOAI_TIEN>().Where(x => x.TenLoaiTien == loaitien);
            TAIKHOANS tkhoan = new TAIKHOANS();
            foreach (var item in query)
            {
                return item.MaLoaiTien;
                //Debug.WriteLine("[QLTC]" + usr.email + " | " + usr.password);
            }
            return "";
        }
    }
}
