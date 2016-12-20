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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WindowsOpendeurdagAppClient
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

        private void StackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OpleidingenFBO), null);
        }

        private void StackPanel_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Campussen), null);
        }

        private void StackPanel_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Nieuws), null);
        }

        private void StackPanel_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GebruikerFormuliers), null);
        }
        private void StackPanel_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Agenda), null);
        }
        private void adminlogin_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdminLogin), null);
        }
    }
}
