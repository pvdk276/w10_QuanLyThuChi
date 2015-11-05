using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_LOAI_TAI_KHOAN
    {
        [PrimaryKey,AutoIncrement]
        public int IdLoaiTaiKhoan { get; set; }
        public string TenLoaiTaiKhoan { get; set; }
    }
}
