﻿#pragma checksum "C:\Users\Bram\Documents\Visual Studio 2015\Projects\WindowsOpendeurdagAppFinal9\WindowsOpendeurdagAppFinal\WindowsOpendeurdagAppClient\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "628EAB0CB4A637DADE4084A2BAA919A7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsOpendeurdagAppClient
{
    partial class MainPage : 
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
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 2:
                {
                    this.VisualStateMobile = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.VisualStateTablet = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.VisualStateDesktop = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.stack1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6:
                {
                    this.stack2 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7:
                {
                    this.stack3 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element8 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 81 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element8).Tapped += this.StackPanel_Tapped_4;
                    #line default
                }
                break;
            case 9:
                {
                    this.agenda = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element10 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 71 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element10).Tapped += this.StackPanel_Tapped_2;
                    #line default
                }
                break;
            case 11:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element11 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 75 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element11).Tapped += this.StackPanel_Tapped_3;
                    #line default
                }
                break;
            case 12:
                {
                    this.gegevens = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 13:
                {
                    this.nieuws = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 14:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element14 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 61 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element14).Tapped += this.StackPanel_Tapped;
                    #line default
                }
                break;
            case 15:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element15 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 65 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element15).Tapped += this.StackPanel_Tapped_1;
                    #line default
                }
                break;
            case 16:
                {
                    this.campus = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 17:
                {
                    this.bedrijf = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 18:
                {
                    this.home = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 19:
                {
                    this.adminlogin = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 54 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.adminlogin).Tapped += this.adminlogin_Tapped;
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

