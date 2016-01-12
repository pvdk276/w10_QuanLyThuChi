using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Objects
{
    class LOAITAIKHOAN
    {
        public int IdLoaiTaiKhoan { get; set; }
        public string TenLoaiTaiKhoan { get; set; }

        public LOAITAIKHOAN(int idLoaiTaiKhoan, string TenLoaiTaiKhoan)
        {
            IdLoaiTaiKhoan = idLoaiTaiKhoan;
            this.TenLoaiTaiKhoan = TenLoaiTaiKhoan;
        }

        public LOAITAIKHOAN()
        {

        }
    }
}
