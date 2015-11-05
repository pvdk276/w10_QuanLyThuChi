using System;
using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_CHI_TIET_VAY_CHOVAY
    {
        [PrimaryKey,AutoIncrement]
        public int IdVayChoVay { get; set; }
        [MaxLength(10)]
        public string LoaiChiTiet { get; set; }//Vay hoặc Cho vay
        public long SoTienChiTiet { get; set; }
        [MaxLength(4)]
        public string MaLoaiTien { get; set; }//Foreign key from Model_LOAI_TIEN
        [MaxLength(20)]
        public string LoaiDoiTuong { get; set; }//Cá Nhân hoặc Ngân Hàng
        [MaxLength(100)]
        public string TenDoiTuong { get; set; }
        public float LaiSuat { get; set; }
        [MaxLength(10)]
        public string DonVi { get; set; }//Ngày, Tháng, Năm
        public DateTime NgayChiTiet { get; set; }
        public DateTime NgayTra { get; set; } //Ngày trả lớn hơn hoặc bằng ngày chi tiết
        public bool TinhTrangChoVay { get; set; }//true: chưa xong, false: đã xong
        [MaxLength(200)]
        public string Email { get; set; }//Foreign key from Model_USERS
    }
}
