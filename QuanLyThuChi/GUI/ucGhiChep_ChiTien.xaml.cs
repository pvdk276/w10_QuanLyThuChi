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
// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace QuanLyThuChi.GUI
{
    public sealed partial class ucGhiChep_ChiTien : UserControl
    {
        public ucGhiChep_ChiTien()
        {
            this.InitializeComponent();
            txbTien.GotFocus += TxbTien_GotFocus;
            txbTien.LostFocus += TxbTien_LostFocus;
            BLL_GhiChep BLL_GhiChep = new BLL_GhiChep();
            cmbMucChi.ItemsSource = BLL_GhiChep.GetHangMucChi();
            cmbMucChi.DisplayMemberPath = "TenHangMucChi";
        } 

        private void TxbTien_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txbTien.Text == "")
                txbTien.Text = "0";
        }

        private void TxbTien_GotFocus(object sender, RoutedEventArgs e)
        {
            txbTien.Text = "";
        }

           
        
    }
}
