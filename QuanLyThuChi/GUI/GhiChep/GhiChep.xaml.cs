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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace QuanLyThuChi.GUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GhiChep : Page
    {
        public GhiChep()
        {
            this.InitializeComponent();
            SystemNavigationManager.GetForCurrentView().BackRequested += App_BackRequested;
            Dictionary<int,string> dictLoaiThuChi = new Dictionary<int,string>()
            {
                {1,"Chi tiền"},
                {2,"Thu tiền"},
                {3,"Chuyển khoản"},
                //{4,"Ghi theo tiền còn"}
            };
            cmbLoaiGhiChep.ItemsSource = dictLoaiThuChi;
            cmbLoaiGhiChep.DisplayMemberPath = "Value";
            cmbLoaiGhiChep.SelectedValuePath = "Key";
            
            
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            cmbLoaiGhiChep.SelectedIndex = int.Parse(e.Parameter.ToString());
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

        private void App_BackRequested(object sender, BackRequestedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null)
                return;

            // Navigate back if possible, and if the event has not 
            // already been handled .
            if (rootFrame.CanGoBack && e.Handled == false)
            {
                e.Handled = true;
                rootFrame.GoBack();
            }
        }

        private void cmbLoaiGhiChep_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {
            
        }

        private void cmbLoaiGhiChep_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.gridGhiChep.Children.Clear();
            switch (cmbLoaiGhiChep.SelectedIndex)
            {
                case 0:
                    ucGhiChep_ChiTien uc1 = new ucGhiChep_ChiTien();
                    this.gridGhiChep.Children.Add(uc1);
                    break;
                case 1:
                    ucGhiChep_ThuTien uc2 = new ucGhiChep_ThuTien();
                    this.gridGhiChep.Children.Add(uc2);
                    break;
                case 2:
                    ucGhiChep_ChuyenKhoan uc3 = new ucGhiChep_ChuyenKhoan();
                    this.gridGhiChep.Children.Add(uc3);
                    break;
            }
            
        }
    }
}
