using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.DAL;
using QuanLyThuChi.Objects;

namespace QuanLyThuChi.BLL
{
    public class BLL_LOAI_TIEN
    {
        DAL_LOAI_TIEN dal = new DAL_LOAI_TIEN();

        public List<LOAI_TIEN> GetLoaiTien()
        {
            return dal.GetLoaiTien();
        }
    }
}
