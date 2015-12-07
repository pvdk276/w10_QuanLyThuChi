using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.DAL;
using QuanLyThuChi.Model;
namespace QuanLyThuChi.BLL
{
    class BLL_GhiChep
    {
        DAL_GhiChep DAL_GhiChep = new DAL_GhiChep();
        public List<Model_HANG_MUC_CHI> GetHangMucChi()
        {
            return DAL_GhiChep.GetHangMucChi();
        }
    }
}
