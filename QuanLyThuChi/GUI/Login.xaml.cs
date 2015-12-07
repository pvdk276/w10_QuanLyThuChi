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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace QuanLyThuChi.GUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
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
            Frame loginFrame = Window.Current.Content as Frame;
            //if(loginFrame.CanGoBack)
            //{
            //    loginFrame.GoBack();
            //}
            var currentView = SystemNavigationManager.GetForCurrentView();
            //hide back button on title
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            loginFrame.Navigate(typeof(Welcome));
        }

        /// <summary>
        /// Checks the login.
        /// </summary>
        private void Logining()
        {
            //Loai user
            string loai = string.Empty;
            BLL_USERS bllusr = new BLL_USERS();
            if (bllusr.checkLogin(out loai, this.txtEmail.Text, this.txtPassword.Password) == 1)
            {
                var currentView = SystemNavigationManager.GetForCurrentView();
                //hide back button on title
                currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
                //Kiểm tra loại user
                if (loai == "Admin") //loại là admin
                {
                    Frame.Navigate(typeof(AdminPage));
                }
                else //Loại là user
                {
                    Frame.Navigate(typeof(MainPage));
                }
            }
            else
            {
                var dialog = new MessageDialog("Sai email và mật khẩu đăng nhập","Xảy ra lỗi khi đăng nhập");
                dialog.ShowAsync();         
            }
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Logining();
        }

        private void txtPassword_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if(e.Key == Windows.System.VirtualKey.Enter)
            {
                this.Logining();
            }
        }
    }
}
