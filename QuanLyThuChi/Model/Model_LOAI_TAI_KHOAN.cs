using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace QuanLyThuChi.Model
{
    public class Model_LOAI_TAI_KHOAN
    {
        [PrimaryKey,AutoIncrement]
        public int idLoaiTaiKhoan { get; set; }
        public string tenLoaiTaiKhoan { get; set; }
    }
}
