﻿#pragma checksum "C:\Users\sofie\Downloads\Groep2_Delaeter_Sofie_Dobbelaere_Bram\WindowsOpendeurdagAppClient\SchoonmeersenRondleiding.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "93B32BB727FFA57B833E82987B697266"
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
    partial class SchoonmeersenRondleiding : 
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
                    this.verdiepingen = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element6 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 105 "..\..\..\SchoonmeersenRondleiding.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element6).Tapped += this.StackPanel_Tapped_Vierde_verdieping;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element7 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 99 "..\..\..\SchoonmeersenRondleiding.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element7).Tapped += this.StackPanel_Tapped_Derde_verdieping;
                    #line default
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element8 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 92 "..\..\..\SchoonmeersenRondleiding.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element8).Tapped += this.StackPanel_Tapped_Tweede_verdieping;
                    #line default
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element9 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 86 "..\..\..\SchoonmeersenRondleiding.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element9).Tapped += this.StackPanel_Tapped_Eerste_verdieping;
                    #line default
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element10 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 79 "..\..\..\SchoonmeersenRondleiding.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element10).Tapped += this.StackPanel_Tapped_Gelijkvloers;
                    #line default
                }
                break;
            case 11:
                {
                    this.planschoonmeersen = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 12:
                {
                    this.home = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 48 "..\..\..\SchoonmeersenRondleiding.xaml"
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

