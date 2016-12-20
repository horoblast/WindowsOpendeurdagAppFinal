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
    public sealed partial class Campussen : Page
    {
        public Campussen()
        {
            this.InitializeComponent();
        }

        private void home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void StackPanel_Tapped_Vesalius(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Vesalius), null);
        }

        private void StackPanel_Tapped_Schoonmeersen(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Schoonmeersen), null);
        }

        private void StackPanel_Tapped_GroteSikkel(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Grote_Sikkel), null);
        }
        private void StackPanel_Tapped_Melle(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Melle), null);
        }

        private void StackPanel_Tapped_Ledeganck(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ledeganck), null);
        }

        private void StackPanel_Tapped_Mercator(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Mercator), null);
        }

        private void StackPanel_Tapped_Bijloke(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Bijloke), null);
        }

        private void StackPanel_Tapped_Aalst(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Aalst), null);
        }


    }
}
