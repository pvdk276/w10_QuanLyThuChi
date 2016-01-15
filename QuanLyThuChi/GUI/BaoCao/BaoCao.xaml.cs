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
using QuanLyThuChi.Objects;
using DevExpress.UI.Xaml.Controls;
using DevExpress.UI.Xaml.Charts;
using Windows.UI.Core;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace QuanLyThuChi.GUI.BaoCao
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BaoCao : Page
    {
        public BaoCao()
        {
            this.InitializeComponent();
            DataContext = new ViewModel();
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


        private void Page_Loading(FrameworkElement sender, object args)
        {
            BLL_GHI_CHEP bllgc = new BLL_GHI_CHEP();

        }

        private void lstbBaoCaoNgay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    public class BaoCaoNgay
    {
        public string Ngay;
        public double Thu;
        public double Chi;
        public double ChuyenKhoan;

        public BaoCaoNgay(string _Ngay, double _Thu, double _Chi, double _ChuyenKhoan)
        {
            Ngay = _Ngay;
            Thu = _Thu;
            Chi = _Chi;
            ChuyenKhoan = _ChuyenKhoan;
        }

        public BaoCaoNgay()
        {

        }
    }
}
