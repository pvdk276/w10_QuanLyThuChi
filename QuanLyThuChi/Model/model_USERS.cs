using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_USERS
    {
        [PrimaryKey,MaxLength(200)]
        public string Email { get; set; }
        [MaxLength(100),NotNull]
        public string FirstName { get; set; }
        [MaxLength(100),NotNull]
        public string LastName { get; set; }
        [NotNull]
        public string Password { get; set; }
        [MaxLength(20),NotNull]
        public string Type { get; set; }    //Loại: admin, user
        [NotNull]
        public bool Status { get; set; }    //đã xác nhận mail hay chưa
        public string CodeChangePassword { get; set; }  //khi đổi password sẽ tạo code
    }
}
