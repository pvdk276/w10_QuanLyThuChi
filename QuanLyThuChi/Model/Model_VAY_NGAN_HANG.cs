using System;
using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_VAY_NGAN_HANG
    {
        [PrimaryKey,AutoIncrement]
        public int IdVayNganHang { get; set; }
        public DateTime NgayVayNganHang { get; set; }
        public long SoTienVay { get; set; }
        [MaxLength(4)]
        public string MaLoaiTien { get; set; }  //Foreign key from Model_LOAI_TIEN
        [MaxLength(100)]
        public string LoaiLaiSuat { get; set; } //Loại lãi suất: Trả gốc và lãi theo dư nợ giảm dần, Trả góp đều hàng tháng theo Lãi suất kép, Trả góp đều theo Lãi suất đơn, Trả góp đều, lãi tính trên dư nợ giảm dần hàng tháng
        public float LaiSuatCoDinhThang { get; set; }
        public byte KyHanNam { get; set; }
        [MaxLength(10)]
        public string TinhTrang { get; set; }   //Đã xong hoặc chưa xong
        [MaxLength(200)]
        public string Email { get; set; }   //Foreign key from Model_USERS
    }
}
