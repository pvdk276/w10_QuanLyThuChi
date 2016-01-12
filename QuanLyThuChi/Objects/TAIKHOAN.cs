using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Objects
{
    class TAIKHOAN
    {
        public int idTaiKhoan { get; set; }

        public string tenTaiKhoan { get; set; }

        public int idLoaiTaiKhoan { get; set; }   
        
        public string TenLoaiTaiKhoan { get; set; } 

        public string MaLoaiTien { get; set; }

        public string GhiChu { get; set; }

        public long SoTienTaiKhoan { get; set; }

        public string Email { get; set; }

        public TAIKHOAN(int idTaiKhoan, string tenTaiKhoan, int idLoaiTaiKhoan, string tenLoaiTaiKhoan, string maLoaiTien, string ghiChu, long soTienTaiKhoan, string email)
        {
            this.idTaiKhoan = idTaiKhoan;
            tenTaiKhoan = tenTaiKhoan;
            idLoaiTaiKhoan = idLoaiTaiKhoan;
            TenLoaiTaiKhoan = tenLoaiTaiKhoan;
            MaLoaiTien = maLoaiTien;
            GhiChu = ghiChu;
            SoTienTaiKhoan = soTienTaiKhoan;
            Email = email;
        }
        public TAIKHOAN(string tenTaiKhoan, int idLoaiTaiKhoan, string maLoaiTien, string ghiChu, long soTienTaiKhoan, string email)
        {
            tenTaiKhoan = tenTaiKhoan;
            idLoaiTaiKhoan = idLoaiTaiKhoan;
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
