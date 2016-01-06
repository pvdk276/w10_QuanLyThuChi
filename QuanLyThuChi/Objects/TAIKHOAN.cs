using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Objects
{
    class TAIKHOAN
    {
        public int IdTaiKhoan { get; set; }

        public string TenTaiKhoan { get; set; }

        public int IdLoaiTaiKhoan { get; set; }   
        
        public string TenLoaiTaiKhoan { get; set; } 

        public string MaLoaiTien { get; set; }

        public string GhiChu { get; set; }

        public long SoTienTaiKhoan { get; set; }

        public string Email { get; set; }

        public TAIKHOAN(int idTaiKhoan, string tenTaiKhoan, int idLoaiTaiKhoan, string tenLoaiTaiKhoan, string maLoaiTien, string ghiChu, long soTienTaiKhoan, string email)
        {
            IdTaiKhoan = idTaiKhoan;
            TenTaiKhoan = tenTaiKhoan;
            IdLoaiTaiKhoan = idLoaiTaiKhoan;
            TenLoaiTaiKhoan = tenLoaiTaiKhoan;
            MaLoaiTien = maLoaiTien;
            GhiChu = ghiChu;
            SoTienTaiKhoan = soTienTaiKhoan;
            Email = email;
        }

        public TAIKHOAN()
        {
        }
    }
}
