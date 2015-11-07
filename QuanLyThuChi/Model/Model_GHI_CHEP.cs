using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_GHI_CHEP
    {
        [PrimaryKey,AutoIncrement]
        public uint IdGhiChep { get; set; }
        public byte Ngay { get; set; }
        public byte Thang { get; set; }
        public ushort Nam { get; set; }
        [MaxLength(5)]
        public string Gio { get; set; } //00:00
        [MaxLength(3)]
        public string ThuChiChuyenKhoan { get; set; }//Thu, Chi, Chuyển Khoản
        [MaxLength(100)]
        public string MucThu { get; set; }//Foreign key from Model_HANG_MUC_THU
        [MaxLength(100)]
        public string MucChi { get; set; }//Foreign key form Model_HANG_MUC_CHI
        public long SoTien { get; set; }
        [MaxLength(4)]
        public string MaLoaiTien { get; set; }//Foreign key form Model_LOAI_TIEN
        [MaxLength(200)]
        public string GhiChuGhiChep { get; set; }
        [MaxLength(100)]
        public string SuKien { get; set; }
        [MaxLength(100)]
        public string TuTaiKhoan { get; set; }
        [MaxLength(100)]
        public string DenTaiKhoan { get; set; }
        [MaxLength(200)]
        public string Email { get; set; } // Foreign key from Model_USERS
    }
}
