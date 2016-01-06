using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.DAL;
using QuanLyThuChi.Model;
namespace QuanLyThuChi.BLL
{
    class BLL_HANG_MUC_CHI
    {
        DAL_HANG_MUC_CHI DAL_Hang_Muc_Chi= new DAL_HANG_MUC_CHI();
        public List<Model_HANG_MUC_CHI> GetHangMucChi()
        {
            return DAL_Hang_Muc_Chi.GetHangMucChi();
        }
    }
}
