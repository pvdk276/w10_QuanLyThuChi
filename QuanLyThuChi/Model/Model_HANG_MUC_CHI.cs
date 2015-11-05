using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_HANG_MUC_CHI
    {
        [PrimaryKey,AutoIncrement]
        public int IdHangMucChi { get; set; }
        public int IdHangMucChiCha { get; set; }    //Foreign key from Model_HANG_MUC_CHI_CHA
        [MaxLength(100)]
        public string TenHangMucChi { get; set; }
        [MaxLength(200)]
        public string GhiChuHangMucChi { get; set; }
        public bool ChinhSuaHangMucChi { get; set; }    //false: không chỉnh sửa, True: có thể chỉnh sửa
        [MaxLength(200)]
        public string Email { get; set; }   //Foreign key from Model_USERS
    }
}
