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

        public string SoTienTaiKhoanConverted { get; set; }

        public string Email { get; set; }

        public TAIKHOAN(int idTaiKhoan, string _tenTaiKhoan, int _idLoaiTaiKhoan, string tenLoaiTaiKhoan, string maLoaiTien, string ghiChu, long soTienTaiKhoan, string email)
        {
            this.idTaiKhoan = idTaiKhoan;
            tenTaiKhoan = _tenTaiKhoan;
            idLoaiTaiKhoan = _idLoaiTaiKhoan;
            TenLoaiTaiKhoan = tenLoaiTaiKhoan;
            MaLoaiTien = maLoaiTien;
            GhiChu = ghiChu;
            SoTienTaiKhoan = soTienTaiKhoan;
            SoTienTaiKhoanConverted = string.Format("{0:#,###0.#}", SoTienTaiKhoan);
            Email = email;
        }
        public TAIKHOAN(string _tenTaiKhoan, int _idLoaiTaiKhoan, string maLoaiTien, string ghiChu, long soTienTaiKhoan, string email)
        {
            tenTaiKhoan = _tenTaiKhoan;
            idLoaiTaiKhoan = _idLoaiTaiKhoan;
            MaLoaiTien = maLoaiTien;
            GhiChu = ghiChu;
            SoTienTaiKhoan = soTienTaiKhoan;
            SoTienTaiKhoanConverted = string.Format("{0:#,###0.#}", SoTienTaiKhoan);
            Email = email;
        }
        public TAIKHOAN()
        {
        }
    }
}
