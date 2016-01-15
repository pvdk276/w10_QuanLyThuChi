using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.Objects;
using QuanLyThuChi.DAL;

namespace QuanLyThuChi.BLL
{
    public class BLL_GHI_CHEP
    {
        DAL_GHI_CHEP dal = new DAL_GHI_CHEP();
        DAL_TAI_KHOAN daltk = new DAL_TAI_KHOAN();
        public int addGhiChep(GHI_CHEP gc)
        {
            //Minus money
            switch(gc.ThuChiChuyenKhoan)
            {
                case "Thu":
                    {
                        TAIKHOAN tkthu = daltk.GetTaiKhoanByEmailAndName(gc.Email, gc.DenTaiKhoan);
                        long result = tkthu.SoTienTaiKhoan + gc.SoTien;
                        daltk.editAccount(gc.DenTaiKhoan, result, gc.Email);
                    }
                    break;
                case "Chi":
                    {
                        TAIKHOAN tkchi = daltk.GetTaiKhoanByEmailAndName(gc.Email, gc.TuTaiKhoan);
                        long result = tkchi.SoTienTaiKhoan - gc.SoTien;
                        daltk.editAccount(gc.TuTaiKhoan, result, gc.Email);
                    }
                    break;
                case "Chuyển Khoản":
                    {
                        TAIKHOAN tkthu = daltk.GetTaiKhoanByEmailAndName(gc.Email, gc.DenTaiKhoan);
                        TAIKHOAN tkchi = daltk.GetTaiKhoanByEmailAndName(gc.Email, gc.TuTaiKhoan);
                        long resultChi = tkchi.SoTienTaiKhoan - gc.SoTien;
                        long resultThu = tkthu.SoTienTaiKhoan + gc.SoTien;
                        daltk.editAccount(gc.TuTaiKhoan, resultChi, gc.Email);
                        daltk.editAccount(gc.DenTaiKhoan, resultThu, gc.Email);
                    }
                    break;
            }

            return dal.addGhiChep(gc.Ngay, gc.Thang, gc.Nam, gc.Gio, gc.ThuChiChuyenKhoan, gc.MucThu,
                gc.MucChi, gc.SoTien, gc.MaLoaiTien, gc.GhiChuGhiChep, gc.SuKien, gc.TuTaiKhoan,
                gc.DenTaiKhoan, gc.Email);
        }
        public List<GHI_CHEP> getGhiChepByEmail()
        {
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            // get setting
            Object email = localSettings.Values["Email"];

            List<GHI_CHEP> lst = dal.getGhiChepByEmail(email.ToString());
            List<GHI_CHEP> result = new List<GHI_CHEP>();
            foreach (GHI_CHEP item in lst)
            {
                result.Add(new GHI_CHEP(item.Ngay,item.Thang,item.Nam,item.Gio,
                    item.ThuChiChuyenKhoan,item.MucThu,item.MucChi,item.SoTien,item.MaLoaiTien,item.GhiChuGhiChep,item.SuKien,
                    item.TuTaiKhoan,item.DenTaiKhoan,item.Email));
            }
            return result;
        }

        public List<GHI_CHEP> getGhiChepByDate(int day, int month, int year)
        {
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            // get setting
            Object email = localSettings.Values["Email"];

            List<GHI_CHEP> lst = dal.getGhiChepByDate(day,month,year,email.ToString());
            List<GHI_CHEP> result = new List<GHI_CHEP>();
            if(lst.Count == 0)
            {
                return null;
            }
            foreach (GHI_CHEP item in lst)
            {
                result.Add(new GHI_CHEP(item.Ngay, item.Thang, item.Nam, item.Gio,
                    item.ThuChiChuyenKhoan, item.MucThu, item.MucChi, item.SoTien, item.MaLoaiTien, item.GhiChuGhiChep, item.SuKien,
                    item.TuTaiKhoan, item.DenTaiKhoan, item.Email));
            }
            return result;
        }
    }  
}
