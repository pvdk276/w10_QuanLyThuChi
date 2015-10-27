using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using QuanLyThuChi.GUI;
using Windows.ApplicationModel.Activation;
using System;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace QuanLyThuChi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void StackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void btnSync_Click(object sender, RoutedEventArgs e)
        {
            Frame homeFrame = Window.Current.Content as Frame;
            homeFrame.Navigate(typeof(Login));
        }

        private void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
