using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Objects
{
    public class GHI_CHEP
    {
        public uint IdGhiChep { get; set; }
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public string Gio { get; set; } //00:00
        public string ThuChiChuyenKhoan { get; set; }//Thu, Chi, Chuyển Khoản
        public string MucThu { get; set; }//Foreign key from Model_HANG_MUC_THU
        public string MucChi { get; set; }//Foreign key form Model_HANG_MUC_CHI
        public long SoTien { get; set; }
        public string sotienConverted { get; set; }
        public string MaLoaiTien { get; set; }//Foreign key form Model_LOAI_TIEN
        public string GhiChuGhiChep { get; set; }
        public string SuKien { get; set; }
        public string TuTaiKhoan { get; set; }
        public string DenTaiKhoan { get; set; }
        public string Email { get; set; } // Foreign key from Model_USERS

        public GHI_CHEP(int ngay,
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
            Ngay = ngay;
            Thang = thang;
            Nam = nam;
            Gio = gio;
            ThuChiChuyenKhoan = thuChiChuyenKhoan;
            MucThu = mucThu;
            MucChi = mucChi;
            SoTien = sotien;
            sotienConverted = string.Format("{0:#,###0.#}", SoTien);
            MaLoaiTien = maloaitien;
            GhiChuGhiChep = ghichu;
            SuKien = sukien;
            TuTaiKhoan = tuTK;
            DenTaiKhoan = denTK;
            Email = email;
        }

        public GHI_CHEP()
        {

        }
    }
}
