﻿#pragma checksum "C:\Users\s4i\Documents\GitHubVisualStudio\w10_QuanLyThuChi\QuanLyThuChi\GUI\Welcome.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1829D8B5F881C225DDF150E2F414A50C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThuChi.GUI
{
    partial class Welcome : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.backgroundImage = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                }
                break;
            case 2:
                {
                    this.Phone = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.Tablet = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.Desktop = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.Nen = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6:
                {
                    this.Logo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7:
                {
                    this.btnCreateAccount = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 49 "..\..\..\GUI\Welcome.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCreateAccount).Click += this.btnCreateAccount_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.btnLogin = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 50 "..\..\..\GUI\Welcome.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnLogin).Click += this.btnLogin_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

