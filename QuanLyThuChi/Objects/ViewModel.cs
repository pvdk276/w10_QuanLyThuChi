using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.BLL;

namespace QuanLyThuChi.Objects
{
    public class ThuChiDataPoint
    {
        public string PointArgument { get; set; }
        public double PointValue { get; set; }
    }

    public class ViewModel
    {
        DateTime start = new DateTime(2000, 1, 1);
        IEnumerable itemsSource;


        public TimeSpan Step { get; set; }
        public int Count { get; set; }
        public double Start { get; set; }
        public IEnumerable ItemsSource
        {
            get { return itemsSource ?? (itemsSource = CreateItemsSource()); }
        }

        protected IEnumerable CreateItemsSource()
        {
            var points = new List<ThuChiDataPoint>();

            BLL_GHI_CHEP bllgc = new BLL_GHI_CHEP();
            List<GHI_CHEP> lstgc = new List<GHI_CHEP>();
            lstgc = bllgc.getGhiChepByDate(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);

            double thusum = 0;
            double chisum = 0;
            double chuyenKhoanSum = 0;
            if(lstgc != null)
            {
                foreach (GHI_CHEP item in lstgc)
                {
                    if (item.ThuChiChuyenKhoan == "Thu")
                    {
                        thusum += item.SoTien;
                    }

                    if (item.ThuChiChuyenKhoan == "Chi")
                    {
                        chisum += item.SoTien;
                    }

                    if (item.ThuChiChuyenKhoan == "Chuyển Khoản")
                    {
                        chuyenKhoanSum += item.SoTien;
                    }
                }
            }  
            points.Add(new ThuChiDataPoint() { PointArgument = "Thu",PointValue = thusum});
            points.Add(new ThuChiDataPoint() { PointArgument = "Chi", PointValue = chisum });
            points.Add(new ThuChiDataPoint() { PointArgument = "Chuyển khoản", PointValue = chuyenKhoanSum });

            //double value = 25;
            //points.Add(new ThuChiDataPoint() { PointArgument = start, PointValue = value });
            //for (int i = 1; i < count; i++)
            //{
            //    value += GenerateAddition(random);
            //    start = start + Step;
            //    points.Add(new ThuChiDataPoint() { PointArgument = start, PointValue = value });
            //}
            return points;
        }
    }
}
