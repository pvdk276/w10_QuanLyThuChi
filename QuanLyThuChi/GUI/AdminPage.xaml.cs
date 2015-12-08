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
using Windows.UI.Popups;
using QuanLyThuChi.Objects;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace QuanLyThuChi.GUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPage : Page
    {
        public AdminPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loading(FrameworkElement sender, object args)
        {
            BLL_USERS blluser = new BLL_USERS();
            this.DataContext = blluser.getUser();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void lstbUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedUser = lstbUser.SelectedItem as USERS;
        }

        private USERS selectedUser;

        private async void btnXoa_Click(object sender, RoutedEventArgs e)
        {

            var confirm = new MessageDialog("Bạn có muốn xóa tài khoản " + selectedUser.email + " không?", "Xác nhận xóa");
            confirm.Commands.Add(new UICommand("Yes", new UICommandInvokedHandler(CommandHander)));
            confirm.Commands.Add(new UICommand("No", new UICommandInvokedHandler(CommandHander)));
            await confirm.ShowAsync();         
        }

        private async System.Threading.Tasks.Task Deleting()
        {
            BLL_USERS blluser = new BLL_USERS();
            if (blluser.deleteUser(selectedUser.email) == 0)
            {
                var dialog = new MessageDialog("Đã xóa " + selectedUser.email);
                await dialog.ShowAsync();
            }
            else if (blluser.deleteUser(selectedUser.email) == 1)
            {
                var dialog = new MessageDialog("Có lỗi hoạt không tìm thấy user");
                await dialog.ShowAsync();
            }
            else
            {
                var dialog = new MessageDialog("Không thể xóa tài khoản Admin");
                await dialog.ShowAsync();
            }
        }

        private async void CommandHander(IUICommand command)
        {
            var commandLabel = command.Label;
            switch (commandLabel)
            {
                case "Yes":
                    {
                        await Deleting();
                        BLL_USERS blluser = new BLL_USERS();
                        this.DataContext = blluser.getUser();
                    }                   
                    break;
                case "No":
                    break;
            }
        }

        private void tapThemTK_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame quanlyFrame = Window.Current.Content as Frame;
            quanlyFrame.Navigate(typeof(ThemTK));
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            Frame quanlyFrame = Window.Current.Content as Frame;
            quanlyFrame.Navigate(typeof(SuaTK));
        }

        private void tapVi_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame quanlyFrame1 = Window.Current.Content as Frame;
            quanlyFrame1.Navigate(typeof(QuanLyTK));
        }
    }
}
