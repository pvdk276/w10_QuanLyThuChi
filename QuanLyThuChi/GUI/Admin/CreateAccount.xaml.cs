using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using QuanLyThuChi.BLL;
using QuanLyThuChi.Objects;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace QuanLyThuChi.GUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateAccount : Page
    {
        public CreateAccount()
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
            //if(loginFrame.CanGoBack)
            //{
            //    loginFrame.GoBack();
            //}
            var currentView = SystemNavigationManager.GetForCurrentView();
            //hide back button on title
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            frame.Navigate(typeof(Welcome));
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            this.createNewAccount();
        }

        private void txtRePassword_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                this.createNewAccount();
            }
        }

        private async void createNewAccount()
        {
            if (this.txtEmail.Text != "" && this.txtPassword.Password != "" &&
                this.txtRePassword.Password != "" && this.txtFirstName.Text != "" && this.txtLastName.Text != "")
            {
                if (this.txtPassword.Password != txtRePassword.Password)
                {

                }
                else //Create
                {
                    BLL_USERS bll = new BLL_USERS();
                    if (bll.insertUser(new USERS(
                        this.txtEmail.Text,
                        this.txtFirstName.Text,
                        this.txtLastName.Text,
                        this.txtPassword.Password,
                        "User",
                        false)) == 1)
                    {
                        //Hiển thị thông báo
                        //// Get a toast XML template
                        //XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText01);

                        //// Fill in the text elements
                        //XmlNodeList stringElements = toastXml.GetElementsByTagName("text");
                        //for (int i = 0; i < stringElements.Length; i++)
                        //{
                        //    stringElements[i].AppendChild(toastXml.CreateTextNode("Đăng ký thành công"));
                        //}

                        //// Create the toast and attach event listeners
                        //ToastNotification toast = new ToastNotification(toastXml);

                        //// Show the toast. Be sure to specify the AppUserModelId on your application's shortcut!
                        //ToastNotificationManager.CreateToastNotifier().Show(toast);
                        var dialog = new MessageDialog("Đăng ký thành công");
                        dialog.ShowAsync();
                        //Chuyển page
                        Frame frame = Window.Current.Content as Frame;
                        var currentView = SystemNavigationManager.GetForCurrentView();
                        //hide back button on title
                        currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
                        frame.Navigate(typeof(Login));
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
