using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Objects
{
    class TAIKHOANS
    {
        public uint idTaiKhoan { get; set; }        
        public string tenTaiKhoan { get; set; }
        public uint idLoaiTaiKhoan { get; set; }    //Foreign Key from Model_LOAI_TAI_KHOAN        
        public string maLoaiTien { get; set; } //Foreign key form Model_LOAI_TIEN        
        public string ghiChu { get; set; }
        public long soTienTaiKhoan { get; set; }        
        public string email { get; set; }// Foreign key from Model_USERS

        public TAIKHOANS()
        {

        }
        public TAIKHOANS(uint idTaiKhoan, string tenTaiKhoan, uint idLoaiTaiKhoan,string maLoaiTien, 
            string ghiChu, long soTienTaiKhoan, string email)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.tenTaiKhoan = tenTaiKhoan;
            this.idLoaiTaiKhoan = idLoaiTaiKhoan;
            this.maLoaiTien = maLoaiTien;
            this.ghiChu = ghiChu;
            this.soTienTaiKhoan = soTienTaiKhoan;
            this.email = email;
        }

    }
}
