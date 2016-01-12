using System;
using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_THIET_LAP
    {
        [PrimaryKey,AutoIncrement]
        public int IdThietLap { get; set; }
        public ushort PinCode { get; set; }
        public DateTime NhacNhoGhiChep { get; set; }
        [MaxLength(4)]
        public string MaLoaiTien { get; set; }//Foreign key from Model_LOAI_TIEN
        [MaxLength(200)]
        public string Email { get; set; }   //Foreign key from Model_USERS
    }
}
