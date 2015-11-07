using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_LOAI_TIEN
    {
        [PrimaryKey,MaxLength(4)]
        public string MaLoaiTien { get; set; }
        [MaxLength(100)]
        public string TenLoaiTien { get; set; }
        public float TyGiaSoVoiUSD { get; set; }
    }
}
