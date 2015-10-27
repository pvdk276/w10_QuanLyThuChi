using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_TAI_KHOAN
    {
        [PrimaryKey,AutoIncrement]
        public int idTaiKhoan { get; set; }
        public string tenTaiKhoan { get; set; }
        public int idLoaiTaiKhoan { get; set; }
    }
}
