using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_HANG_MUC_CHI_CHA
    {
        [PrimaryKey,AutoIncrement]
        public int IdHangMucCHiCha { get; set; }
        [MaxLength(100)]
        public string TenHangMucChiCha { get; set; }
    }
}
