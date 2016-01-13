using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using QuanLyThuChi.BLL;
using QuanLyThuChi.GUI.Util;
using QuanLyThuChi.Objects;
using Windows.UI.Popups;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace QuanLyThuChi.GUI
{
    public sealed partial class ucGhiChep_ChiTien : UserControl
    {
        private BLL_HANG_MUC_CHI BLL_hangmucchi;
        private BLL_TAI_KHOAN BLL_TaiKhoan;
        public ucGhiChep_ChiTien()
        {
            this.InitializeComponent();
            txbTien.GotFocus += TxbTien_GotFocus;
            txbTien.LostFocus += TxbTien_LostFocus;
            BLL_hangmucchi = new BLL_HANG_MUC_CHI();
            BLL_TaiKhoan = new BLL_TAI_KHOAN();
            cmbMucChi.ItemsSource = BLL_hangmucchi.GetHangMucChi();
            cmbMucChi.DisplayMemberPath = "TenHangMucChi";
            cmbMucChi.SelectedIndex = 0;
            cmbTuTaiKhoan.ItemsSource = BLL_TaiKhoan.getTaiKhoanByEmail();
            cmbTuTaiKhoan.DisplayMemberPath = "tenTaiKhoan";
            cmbTuTaiKhoan.SelectedIndex = 0;
        }

        private void TxbTien_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txbTien.Text == "")
                txbTien.Text = "0";
        }

        private void TxbTien_GotFocus(object sender, RoutedEventArgs e)
        {
            txbTien.Text = "";
            this.gridCal1.Visibility = Visibility.Visible;
            ucCalculator uc = new ucCalculator();
            uc.HorizontalAlignment = HorizontalAlignment.Center;
            uc.VerticalAlignment = VerticalAlignment.Center;
            this.gridCal1.Children.Add(uc);
        }

        private void gridCal1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ucCalculator.result != null)
                this.txbTien.Text = ucCalculator.result;
        }

        private void btnLuuGhiChep_Click(object sender, RoutedEventArgs e)
        {
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            // get setting
            Object email = localSettings.Values["Email"];

            BLL_GHI_CHEP bll = new BLL_GHI_CHEP();
            GHI_CHEP gc = new GHI_CHEP(txbNgayChi.Date.Day, txbNgayChi.Date.Month,
                txbNgayChi.Date.Year,
                txbGioChi.Time.ToString(),
                "Chi",
                "",
                (cmbMucChi.SelectedItem as HANG_MUC_CHI).TenHangMucChi,
                long.Parse(txbTien.Text),
                "VND",
                "",
                txbSuKien.Text,
                (cmbTuTaiKhoan.SelectedItem as TAIKHOAN).tenTaiKhoan,
                "",
                email.ToString());

            if(bll.addGhiChep(gc) == 1)
            {
                var dialog = new MessageDialog("Thêm thành công");
                dialog.ShowAsync();
            }
            else
            {
                var dialog = new MessageDialog("Thêm thất bại");
                dialog.ShowAsync();
            }
        }
    }
}
