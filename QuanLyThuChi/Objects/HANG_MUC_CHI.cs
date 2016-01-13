using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Objects
{
    class HANG_MUC_CHI
    {
        public int IdHangMucChi { get; set; }
        public int IdHangMucChiCha { get; set; }    //Foreign key from Model_HANG_MUC_CHI_CHA
        public string TenHangMucChi { get; set; }
        public string GhiChuHangMucChi { get; set; }
        public bool ChinhSuaHangMucChi { get; set; }    //false: không chỉnh sửa, True: có thể chỉnh sửa
        public string Email { get; set; }   //Foreign key from Model_USERS

        public HANG_MUC_CHI(int _idHangMucChiCha, string _tenHangMucChi, string _ghiChu, bool _chinhSua, string _email)
        {
            IdHangMucChiCha = _idHangMucChiCha;
            TenHangMucChi = _tenHangMucChi;
            GhiChuHangMucChi = _ghiChu;
            ChinhSuaHangMucChi = _chinhSua;
            Email = _email;
        }

        public HANG_MUC_CHI()
        {

        }
    }
}
