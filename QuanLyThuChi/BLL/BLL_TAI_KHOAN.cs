using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.DAL;
using QuanLyThuChi.Objects;

namespace QuanLyThuChi.BLL
{
    class BLL_TAI_KHOAN
    {
        DAL_TAI_KHOAN Dal_Tai_Khoan = new DAL_TAI_KHOAN();

        public List<TAIKHOAN> getTaiKhoan()
        {
            return Dal_Tai_Khoan.GetTaiKhoan();
        }
        
        public List<TAIKHOAN> getTaiKhoanByEmail()
        {
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            // get setting
            Object email = localSettings.Values["Email"];

            List<TAIKHOAN> lst = Dal_Tai_Khoan.GetTaiKhoanByEmail(email.ToString());
            List<TAIKHOAN> result = new List<TAIKHOAN>();
            foreach (TAIKHOAN item in lst)
            {
                result.Add(new TAIKHOAN(item.tenTaiKhoan, item.idLoaiTaiKhoan, item.MaLoaiTien, item.GhiChu,
                    item.SoTienTaiKhoan, item.Email));
            }
            return result;
        }
        public List<LOAITAIKHOAN> getLoaiTaiKhoan()
        {
            return Dal_Tai_Khoan.getLoaiTaiKhoan();
        }

        public int insertAccount(TAIKHOAN taikhoan)
        {
            foreach(TAIKHOAN item in this.getTaiKhoanByEmail())
            {
                if (taikhoan.tenTaiKhoan == item.tenTaiKhoan)
                    return 2;
            }
            return Dal_Tai_Khoan.insertAccount(taikhoan.tenTaiKhoan,
                taikhoan.idLoaiTaiKhoan,
                taikhoan.MaLoaiTien,
                taikhoan.GhiChu,
                taikhoan.SoTienTaiKhoan,
                taikhoan.Email);
        }
    }
}
