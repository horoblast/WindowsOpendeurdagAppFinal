﻿#pragma checksum "C:\Users\jonas\Documents\WindowsOpendeurdagAppFinal\WindowsOpendeurdagAppClient\OpleidingenFBO.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B6B3BE587EDBC057EE212A124FDBEAE2"
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
    partial class OpleidingenFBO : 
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
                    this.opleidingen = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6:
                {
                    this.opleidingen2 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element7 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 79 "..\..\..\OpleidingenFBO.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element7).Tapped += this.StackPanel_Tapped_2;
                    #line default
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element8 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 84 "..\..\..\OpleidingenFBO.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element8).Tapped += this.StackPanel_Tapped_3;
                    #line default
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element9 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 67 "..\..\..\OpleidingenFBO.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element9).Tapped += this.StackPanel_Tapped;
                    #line default
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element10 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 72 "..\..\..\OpleidingenFBO.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element10).Tapped += this.StackPanel_Tapped_1;
                    #line default
                }
                break;
            case 11:
                {
                    this.home = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 47 "..\..\..\OpleidingenFBO.xaml"
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

