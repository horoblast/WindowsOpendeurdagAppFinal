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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WindowsOpendeurdagAppClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OpleidingenFBO : Page
    {
        public OpleidingenFBO()
        {
            this.InitializeComponent();
        }

        private void home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void StackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Bedrijfsmanagement), null);
        }

        private void StackPanel_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Officemanagement), null);
        }

        private void StackPanel_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Retailmanagement), null);
        }

        private void StackPanel_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Toegepasteinformatica), null);
        }
    }
}
