using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Objects
{
    public class LOAI_TIEN
    {
        public string MaLoaiTien { get; set; }
        public string TenLoaiTien { get; set; }
        public float TyGiaSoVoiUSD { get; set; }

        public LOAI_TIEN(string maloaitien, string tenloaitien, float tygiasovoiUSD)
        {
            this.MaLoaiTien = maloaitien;
            this.TenLoaiTien = tenloaitien;
            this.TyGiaSoVoiUSD = tygiasovoiUSD;
        }

        public LOAI_TIEN(string maloaitien, string tenloaitien)
        {
            this.MaLoaiTien = maloaitien;
            this.TenLoaiTien = tenloaitien;
        }

        public LOAI_TIEN()
        {
        }
    }
}
