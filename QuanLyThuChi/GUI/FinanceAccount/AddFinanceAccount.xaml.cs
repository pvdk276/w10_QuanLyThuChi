using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace QuanLyThuChi.GUI.FinanceAccount
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddFinanceAccount : Page
    {
        public AddFinanceAccount()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var currentView = SystemNavigationManager.GetForCurrentView();
            //Show back button on title
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            //Back button press
            currentView.BackRequested += backButton_Tapped;
        }

        /// <summary>
        /// Handles the Tapped event of the backButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="BackRequestedEventArgs"/> instance containing the event data.</param>
        private void backButton_Tapped(object sender, BackRequestedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            var currentView = SystemNavigationManager.GetForCurrentView();
            //hide back button on title
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            frame.Navigate(typeof(MainPage));
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            BLL_TAI_KHOAN bllTaiKhoan = new BLL_TAI_KHOAN();
            int idLoaiTaiKhoan = (cmbAccountType.SelectedItem as LOAITAIKHOAN).IdLoaiTaiKhoan;
            string maLoaiTien = (cmbMoneyType.SelectedItem as LOAI_TIEN).MaLoaiTien;
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            // get setting
            Object email = localSettings.Values["Email"];

            TAIKHOAN tk = new TAIKHOAN(txtAccountName.Text,
                idLoaiTaiKhoan,
                maLoaiTien,
                txtNote.Text,
                long.Parse(txtMoney.Text),
                email.ToString());
            int result = bllTaiKhoan.insertAccount(tk);
            if (result == 1)
            {
                var dialog = new MessageDialog("Tạo tài khoản thành công");
                dialog.ShowAsync();
            }
            else if(result == 2)
            {
                var dialog = new MessageDialog("Tài khoản đã tồn tại");
                dialog.ShowAsync();
            }
            else
            {
                var dialog = new MessageDialog("Có lỗi khi tạo tài khoản");
                dialog.ShowAsync();
            }
        }

        private void Page_Loading(FrameworkElement sender, object args)
        {
            BLL_TAI_KHOAN blltk = new BLL_TAI_KHOAN();
            this.cmbAccountType.DataContext = blltk.getLoaiTaiKhoan();
            this.cmbAccountType.SelectedIndex = 0;

            BLL_LOAI_TIEN bllLoaiTien = new BLL_LOAI_TIEN();
            this.cmbMoneyType.DataContext = bllLoaiTien.GetLoaiTien();
            this.cmbMoneyType.SelectedIndex = 0;
        }

        private void txtMoney_GotFocus(object sender, RoutedEventArgs e)
        {
            this.gridCal1.Visibility = Visibility.Visible;
            ucCalculator uc = new ucCalculator();
            uc.HorizontalAlignment = HorizontalAlignment.Center;
            uc.VerticalAlignment = VerticalAlignment.Center;
            this.gridCal1.Children.Add(uc);
        }

        private void gridCal1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ucCalculator.result != null)
                this.txtMoney.Text = ucCalculator.result;
        }
    }
}
