﻿#pragma checksum "C:\Users\Bram\Documents\Visual Studio 2015\Projects\WindowsOpendeurdagAppFinal9\WindowsOpendeurdagAppFinal\WindowsOpendeurdagAppClient\Retailmanagement.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "47825A43B71662950161FC66801AE1AC"
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
    partial class Retailmanagement : 
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
                    this.home = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 46 "..\..\..\Retailmanagement.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.home).Tapped += this.home_Tapped;
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

