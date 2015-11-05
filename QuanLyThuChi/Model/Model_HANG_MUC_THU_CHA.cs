using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_HANG_MUC_THU_CHA
    {
        [PrimaryKey,AutoIncrement]
        public int IdHangMucThuCha { get; set; }
        [MaxLength(100)]
        public string TenHangMucThuCha { get; set; }
    }
}
