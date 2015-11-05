using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_GUI_TIET_KIEM
    {
        [PrimaryKey,AutoIncrement]
        public int IdGuiTietKiem { get; set; }
        public int IdTaiKhoan { get; set; } //foreign key from Model_TAI_KHOAN
        [MaxLength(50)]
        public string KyHan { get; set; }
        public float LaiSuatNam { get; set; }
        public float KhongKyHan { get; set; }
        public long SoTienGui { get; set; }
    }
}
