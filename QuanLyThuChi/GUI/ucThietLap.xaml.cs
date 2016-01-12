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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace QuanLyThuChi.GUI
{
    public sealed partial class ucThietLap : UserControl
    {
        public ucThietLap()
        {
            this.InitializeComponent();
        }

        private void linkLogout_Click(object sender, RoutedEventArgs e)
        {
            //Lưu thông tin đăng nhập
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            // Create a simple setting
            localSettings.Values["Email"] = "";
            localSettings.Values["Password"] = "";
            Frame homeFrame = Window.Current.Content as Frame;
            homeFrame.Navigate(typeof(Welcome));
        }
    }
}
