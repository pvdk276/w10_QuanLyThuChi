using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_USERS
    {
        [PrimaryKey]
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string type { get; set; }
        public bool status { get; set; }
        public string codeChangePassword { get; set; }
    }
}
