using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_TAI_KHOAN
    {
        [PrimaryKey,AutoIncrement]
        public uint idTaiKhoan { get; set; }
        [MaxLength(100)]
        public string tenTaiKhoan { get; set; }
        [Indexed]
        public uint idLoaiTaiKhoan { get; set; }    //Foreign Key from Model_LOAI_TAI_KHOAN
        [MaxLength(4)]
        public string MaLoaiTien { get; set; } //Foreign key form Model_LOAI_TIEN
        [MaxLength(200)]
        public string GhiChu { get; set; }
        public long SoTienTaiKhoan { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }// Foreign key from Model_USERS
    }
}
