using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.DAL;
using QuanLyThuChi.Model;
using QuanLyThuChi.Objects;

namespace QuanLyThuChi.BLL
{
    class BLL_TaiKhoan
    {
        DAL_TaiKhoan DAL_TaiKhoan = new DAL_TaiKhoan();
        public List<Model_TAI_KHOAN> GetTaiKhoan()
        {
            return DAL_TaiKhoan.GetTaiKhoan();
        }
        public int insertTaiKhoan(TAIKHOANS taikhoan, string tenloaitk, string loaitien)
        {
            return DAL_TaiKhoan.insertTaiKhoan(taikhoan.idTaiKhoan,
                taikhoan.tenTaiKhoan,
                (uint)DAL_TaiKhoan.getIDbyLoaiTaiKhoan(tenloaitk),
                DAL_TaiKhoan.getMaTienbyLoaiTien(loaitien),
                taikhoan.ghiChu,
                taikhoan.soTienTaiKhoan,
                taikhoan.email
                );
        }

    }
}
