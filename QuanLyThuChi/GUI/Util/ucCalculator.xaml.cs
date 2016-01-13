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

namespace QuanLyThuChi.GUI.Util
{
    public sealed partial class ucCalculator : UserControl
    {
        public static string result = "0";
        private bool isX = false;
        private bool isDiv = false;
        private bool isMinus = false;
        private bool isPlus = false;
        private string number1 = "";
        private string number2 = "";
        public ucCalculator()
        {
            this.InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Grid grid = (this.Parent as Grid);
            grid.Children.Clear();
            grid.Visibility = Visibility.Collapsed;
            if (!(isX || isDiv || isPlus || isMinus) && number1 != "")
            {
                result = number1;
            }
            this.txtResult.Text = "0";
            this.number1 = "";
            this.number2 = "";
            isX = false;
            isDiv = false;
            isMinus = false;
            isPlus = false;
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            this.txtResult.Text = "0";
            this.number1 = "";
            this.number2 = "";
            isX = false;
            isDiv = false;
            isMinus = false;
            isPlus = false;
        }

        private void btnX_Click(object sender, RoutedEventArgs e)
        {
            isX = true;
            isDiv = false;
            isMinus = false;
            isPlus = false;
            if (number1 == "")
                number1 = "0";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            isX = false;
            isDiv = true;
            isMinus = false;
            isPlus = false;
            if (number1 == "")
                number1 = "0";
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (isX || isDiv || isPlus || isMinus)
            {
                if(number2 != "")
                    number2 = number2.Remove(number2.Length - 1);
                txtResult.Text = number2;
            }
            else
            {
                if (number1 != "")
                    number1 = number1.Remove(number1.Length - 1);
                txtResult.Text = number1;
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (isX || isDiv || isPlus || isMinus)
            {
                number2 += "7";
                txtResult.Text = number2;
            }
            else
            {
                number1 += "7";
                txtResult.Text = number1;
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (isX || isDiv || isPlus || isMinus)
            {
                number2 += "8";
                txtResult.Text = number2;
            }
            else
            {
                number1 += "8";
                txtResult.Text = number1;
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (isX || isDiv || isPlus || isMinus)
            {
                number2 += "9";
                txtResult.Text = number2;
            }
            else
            {
                number1 += "9";
                txtResult.Text = number1;
            }
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            isX = false;
            isDiv = false;
            isMinus = true;
            isPlus = false;
            if (number1 == "")
                number1 = "0";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (isX || isDiv || isPlus || isMinus)
            {
                number2 += "4";
                txtResult.Text = number2;
            }
            else
            {
                number1 += "4";
                txtResult.Text = number1;
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (isX || isDiv || isPlus || isMinus)
            {
                number2 += "5";
                txtResult.Text = number2;
            }
            else
            {
                number1 += "5";
                txtResult.Text = number1;
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (isX || isDiv || isPlus || isMinus)
            {
                number2 += "6";
                txtResult.Text = number2;
            }
            else
            {
                number1 += "6";
                txtResult.Text = number1;
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            isX = false;
            isDiv = false;
            isMinus = false;
            isPlus = true;
            if (number1 == "")
                number1 = "0";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (isX || isDiv || isPlus || isMinus)
            {
                number2 += "1";
                txtResult.Text = number2;
            }
            else
            {
                number1 += "1";
                txtResult.Text = number1;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (isX || isDiv || isPlus || isMinus)
            {
                number2 += "2";
                txtResult.Text = number2;
            }
            else
            {
                number1 += "2";
                txtResult.Text = number1;
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (isX || isDiv || isPlus || isMinus)
            {
                number2 += "3";
                txtResult.Text = number2;
            }
            else
            {
                number1 += "3";
                txtResult.Text = number1;
            }
        }

        private void btn000_Click(object sender, RoutedEventArgs e)
        {
            if (isX || isDiv || isPlus || isMinus)
            {
                number2 += "000";
                txtResult.Text = number2;
            }
            else
            {
                if(number1 != "")
                    number1 += "000";
                txtResult.Text = number1;
            }
        }

        private void btnComma_Click(object sender, RoutedEventArgs e)
        {
            if (isX || isDiv || isPlus || isMinus)
            {
                number2 += ".";
                txtResult.Text = number2;
            }
            else
            {
                number1 += ".";
                txtResult.Text = number1;
            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            double dResult = 0;
            if (isPlus)
            {
                dResult = Double.Parse(number1) + Double.Parse(number2);
            }
            else if (isMinus)
            {
                dResult = Double.Parse(number1) - Double.Parse(number2);
            }
            else if (isX)
            {
                dResult = Double.Parse(number1) * Double.Parse(number2);
            }
            else if (isDiv)
            {
                dResult = Double.Parse(number1) / Double.Parse(number2);
            }
            else
                dResult = Double.Parse(number1);

            txtResult.Text = dResult.ToString();
            result = dResult.ToString();
            number1 = dResult.ToString();
            number2 = "";
            isX = false;
            isDiv = false;
            isMinus = false;
            isPlus = false;
        }
    }
}
