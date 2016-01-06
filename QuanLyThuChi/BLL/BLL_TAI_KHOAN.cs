using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.DAL;
using QuanLyThuChi.Objects;

namespace QuanLyThuChi.BLL
{
    class BLL_TAI_KHOAN
    {
        DAL_TAI_KHOAN Dal_Tai_Khoan = new DAL_TAI_KHOAN();

        public List<TAIKHOAN> getTaiKhoan()
        {
            return Dal_Tai_Khoan.GetTaiKhoan();
        }
    }
}
