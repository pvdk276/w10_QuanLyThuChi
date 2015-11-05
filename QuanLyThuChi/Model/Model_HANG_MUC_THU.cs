using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_HANG_MUC_THU
    {
        [PrimaryKey,AutoIncrement]
        public int IdHangMucThu { get; set; }
        public int IdHangMucCha { get; set; }   //foreign key from Model_HANG_MUC_THU_CHA
        [MaxLength(100)]
        public string TenHangMucThu { get; set; }
        [MaxLength(200)]
        public string GhiChuHangMucThu { get; set; }
        public bool ChinhSuaHangMucThu { get; set; }    //false: không dc chỉnh sửa, true: có thể chỉnh sửa
        [MaxLength(200)]
        public string Email { get; set; }   //foreign key from Model_USERS
    }
}
